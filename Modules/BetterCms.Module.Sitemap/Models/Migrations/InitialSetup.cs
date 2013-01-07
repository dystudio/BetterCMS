﻿using BetterCms.Core.DataAccess.DataContext.Migrations;
using BetterCms.Core.Models;

using FluentMigrator;

namespace BetterCms.Module.Sitemap.Models.Migrations
{
    /// <summary>
    /// Database structure setup.
    /// </summary>
    [Migration(1)]
    public class InitialSetup : DefaultMigration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialSetup"/> class.
        /// </summary>
        public InitialSetup() : base(NavigationModuleDescriptor.ModuleName)
        {
        }

        /// <summary>
        /// The up.
        /// </summary>
        public override void Up()
        {
            CreateSitemapNodesTable();
        }

        /// <summary>
        /// The down.
        /// </summary>
        public override void Down()
        {
            RemoveSitemapNodesTable();
        }

        /// <summary>
        /// The create sitemap nodes table.
        /// </summary>
        private void CreateSitemapNodesTable()
        {
            Create
               .Table("SitemapNodes")
               .InSchema(SchemaName)

               .WithCmsBaseColumns()
               .WithColumn("Title").AsString(MaxLength.Name).NotNullable()
               .WithColumn("Url").AsString(MaxLength.Url).NotNullable()
               .WithColumn("DisplayOrder").AsInt32().NotNullable()
               .WithColumn("ParentNodeId").AsGuid().Nullable();

            Create
                .ForeignKey("FK_Cms_SitemapNodes_ParentNodeId_SitemapNodes_Id")
                .FromTable("SitemapNodes").InSchema(SchemaName).ForeignColumn("ParentNodeId")
                .ToTable("SitemapNodes").InSchema(SchemaName).PrimaryColumn("Id");

            Create
                .Index("IX_Cms_SitemapNodes_Title")
                .OnTable("SitemapNodes").InSchema(SchemaName).OnColumn("Title").Ascending();

            Create
                .Index("IX_Cms_SitemapNodes_ParentNodeId")
                .OnTable("SitemapNodes").InSchema(SchemaName).OnColumn("ParentNodeId").Ascending();
        }

        /// <summary>
        /// The remove sitemap nodes table.
        /// </summary>
        private void RemoveSitemapNodesTable()
        {
            Delete.ForeignKey("FK_Cms_SitemapNodes_ParentNodeId_SitemapNodes_Id").OnTable("SitemapNodes").InSchema(SchemaName);
            Delete.Index("IX_Cms_SitemapNodes_Title").OnTable("SitemapNodes").InSchema(SchemaName);
            Delete.Index("IX_Cms_SitemapNodes_ParentNodeId").OnTable("SitemapNodes").InSchema(SchemaName);
            Delete.Table("SitemapNodes").InSchema(SchemaName);
        }
    }
}