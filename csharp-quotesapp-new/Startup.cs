using csharp_quotesapp_new.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_quotesapp_new
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddHttpClient<IFavqsClient, FavqsClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://favqs.com/api/");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Token token=6ec3ac06e0c549325cffffbb6ff79c85");
            });

            return services.BuildServiceProvider();
        }
    }
}