using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingSolutionsSamples.Order
{
    public interface IOrderCache
    {
        IEnumerable<NorthwindLibrary.Order> Get(string forUser);
        void Set(string forUser, IEnumerable<NorthwindLibrary.Order> orders);
    }
}
