using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.FavqsModels.RequestModels
{
    // Dto - data transfer object
    public class CreateSessionRequest
    {
        public User User { get; set; }
    }
}