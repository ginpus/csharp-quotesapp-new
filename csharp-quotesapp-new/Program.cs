using csharp_quotesapp_new.Clients;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Contracts.FavqsModels.RequestModels;

namespace csharp_quotesapp_new
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = new Startup().ConfigureServices();

            var favqsClient = serviceProvider.GetService<IFavqsClient>();

            var createSessionRequest = new CreateSessionRequest
            {
                User = new User
                {
                    Login = "vakejer210",
                    Password = "apiapi"
                }
            };

            var response = await favqsClient.CreateSession(createSessionRequest);

            Console.WriteLine(response.UserToken); ;
        }
    }
}