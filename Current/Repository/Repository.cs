using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial._01Cookies.Models;

namespace Tutorial._01Cookies.Repository
{
    public class Repository : IRepositoryService
    {
        private List<GuestResponse> responses = new List<GuestResponse>();

        public Repository()
        {
        }

        public IEnumerable<GuestResponse> Responses {
            get
            {
                return responses;
            }
        }
        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
