using Contracts.FavqsModels.RequestModels;
using Contracts.FavqsModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_quotesapp_new.Clients
{
    internal interface IFavqsClient
    {
        Task<CreateSessionResponse> CreateSession(CreateSessionRequest request);

        /*        Task GetQuote();

                Task AddQuote();*/
    }
}