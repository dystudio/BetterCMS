﻿using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.MediaManager.Images.Image
{
    [Route("/images/{ImageId}", Verbs = "GET")]
    [DataContract]
    public class GetImageRequest : RequestBase<GetImageModel>, IReturn<GetImageResponse>
    {
        [DataMember]
        public System.Guid ImageId
        {
            get
            {
                return Data.ImageId;
            }
            set
            {
                Data.ImageId = value;
            }
        }
    }
}