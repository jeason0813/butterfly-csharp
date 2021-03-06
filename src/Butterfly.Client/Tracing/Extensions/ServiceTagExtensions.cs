﻿using Butterfly.OpenTracing;

namespace Butterfly.Client.Tracing
{
    public static class ServiceTagExtensions
    {
        public static TagCollection ServiceApplicationName(this TagCollection tags, string applicationName)
        {
          return  tags?.Set(ServiceTags.ServiceApplicationName, applicationName);
        }
        
        public static TagCollection ServiceEnvironment(this TagCollection tags, string environment)
        {
            return  tags?.Set(ServiceTags.ServiceEnvironment, environment);
        }
        
        public static TagCollection ServiceHost(this TagCollection tags, string host)
        {
            return  tags?.Set(ServiceTags.ServiceHost, host);
        }
    }
}