using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora.Models
{
    public class PagedListViewModel<T>
    {
        public IEnumerable<T> Entities { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
