using Funq;
using ServiceStack;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ApiHost : AppHostHttpListenerPoolBase
    {
        public ApiHost(string serviceName, params Assembly[] assembliesWithServices) 
            : base(serviceName, assembliesWithServices)
        {
        }

        public override void Configure(Container container)
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 10000;

            Plugins.Add(new ServerEventsFeature());
            SetConfig(new HostConfig
            {
                DebugMode = true,
                EnableFeatures = Feature.All,
            });
            JsConfig.Init(new Config
            {
                DateHandler = DateHandler.ISO8601,
                ExcludeTypeInfo = true,
                ExcludeDefaultValues = true,
                IncludeNullValues = false
            });

            
        }
    }
}
