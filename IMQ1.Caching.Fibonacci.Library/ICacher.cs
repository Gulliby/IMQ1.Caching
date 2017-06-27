using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMQ1.Caching.Fibonacci.Library
{
    public interface ICacher
    {
        object GetValue(string key);

        void SetValue(string key, object value);
    }
}
