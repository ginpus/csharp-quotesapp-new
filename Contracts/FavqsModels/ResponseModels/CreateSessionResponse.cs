using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.FavqsModels.ResponseModels
{
    public class CreateSessionResponse
    {
        public string Login { get; set; }
        public string Email { get; set; }

        [JsonPropertyName("User-Token")]
        public string UserToken { get; set; }
    }
}