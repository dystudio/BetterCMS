﻿using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Pages.Pages.Page
{
    [Route("/pages/{PageId}", Verbs = "GET")]
    [Route("/pages/by-url/{PageUrl*}", Verbs = "GET")]
    [DataContract]
    public class GetPageRequest : RequestBase<GetPageModel>, IReturn<GetPageResponse>
    {
        [DataMember]
        public System.Guid? PageId
        {
            get
            {
                return Data.PageId;
            }
            set
            {
                Data.PageId = value;
            }
        }

        [DataMember]
        public string PageUrl
        {
            get
            {
                return Data.PageUrl;
            }
            set
            {
                Data.PageUrl = value;
            }
        }
    }
}