﻿using System;

using Autofac;

using BetterCms.Core.Modules;
using BetterCms.Events;
using BetterCms.Module.GoogleAnalytics.Accessors;

namespace BetterCms.Module.GoogleAnalytics
{
    public class GoogleAnalyticsModuleDescriptor : CmsModuleDescriptor
    {
        internal const string ModuleName = "google_analytics";

        internal const string ModuleId = "de5280e4-99e6-4c95-ac06-1c31312b82ec";

        private readonly ICmsConfiguration cmsConfiguration;

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override Guid Id
        {
            get
            {
                return new Guid(ModuleId);
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name
        {
            get
            {
                return ModuleName;
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public override string Description
        {
            get
            {
                return "The Google Analytics integration module for Better CMS.";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAnalyticsModuleDescriptor"/> class
        /// </summary>
        /// <param name="configuration">The configuration</param>
        public GoogleAnalyticsModuleDescriptor(ICmsConfiguration configuration)
            : base(configuration)
        {
            cmsConfiguration = configuration;
            RootEvents.Instance.PageRendering += Events_PageRendering;
        }

        /// <summary>
        /// Register a routes for the google analytics module.
        /// </summary>
        /// <param name="context">The module context.</param>
        /// <param name="containerBuilder">The container builder.</param>
        public override void RegisterCustomRoutes(CmsModuleRegistrationContext context, ContainerBuilder containerBuilder)
        {
            context.MapRoute(
                "bcms-google-sitemap",
                GoogleAnalyticsModuleHelper.GetSitemapUrl(cmsConfiguration),
                new { area = AreaName, controller = "GoogleSitemap", action = "Index" });
        }

        /// <summary>
        /// Add google analytics script accessor to Page.
        /// </summary>
        /// <param name="args">The args.</param>
        private void Events_PageRendering(PageRenderingEventArgs args)
        {
            args.RenderPageData.JavaScripts.Add(new GoogleAnalyticsScriptAccessor(cmsConfiguration));
        }

    }
}