using Contracts.FavqsModels;
using Contracts.FavqsModels.RequestModels;
using Contracts.FavqsModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace csharp_quotesapp_new.Clients
{
    public class FavqsClient : IFavqsClient
    {
        private readonly HttpClient _httpClient;

        public FavqsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CreateSessionResponse> CreateSession(CreateSessionRequest request)
        {
            var url = "session";

            var response = await _httpClient.PostAsJsonAsync(url, request);

            return await response.Content.ReadFromJsonAsync<CreateSessionResponse>();
        }

        public Task<Quote> GetQuote(int id)
        {
            var url = $"quotes/{id}";

            return _httpClient.GetFromJsonAsync<Quote>(url);
        }
    }
}