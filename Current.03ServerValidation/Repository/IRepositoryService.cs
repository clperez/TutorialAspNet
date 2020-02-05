using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial._01Cookies.Models;

namespace Tutorial._01Cookies.Repository
{
    public interface IRepositoryService 
    {

        IEnumerable<GuestResponse> Responses { get; }
        void AddResponse(GuestResponse response);
    }
}
