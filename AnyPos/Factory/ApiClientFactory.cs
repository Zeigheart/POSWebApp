using AnyPos.POSApi;
using AnyPos.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AnyPos.Factory
{
    public static class ApiClientFactory
    {
        private static Uri apiUri;

        public static Lazy<ApiClient> restClient = new Lazy<ApiClient>(
            () => new ApiClient(apiUri), LazyThreadSafetyMode.ExecutionAndPublication);

        static ApiClientFactory()
        {
            apiUri = new Uri(ApplicationSettings.ProductAPIBase);
        }

        public static ApiClient Instance
        {
            get
            {
                return restClient.Value;
            }
        }
    }
}
