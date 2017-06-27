using System;
using System.Runtime.Caching;

namespace IMQ1.Caching.Fibonacci.Library
{
    public class CustomMemmoryCache : ICacher
    {
        private ObjectCache _cache;

        public CustomMemmoryCache()
        {
            _cache = MemoryCache.Default;
        }

        public object GetValue(string key)
        {
            if (_cache.Contains(key))
            {
                return (int)_cache.Get(key);
            }
            return null;
        }

        public void SetValue(string key, object value)
        {
            _cache.Add(key, value, new DateTimeOffset(DateTime.Now + new TimeSpan(0, 2, 0)));
        }
    }
}
