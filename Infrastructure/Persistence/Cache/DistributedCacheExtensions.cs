using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Persistence.Cache
{
    public static class DistributedCacheExtensions
    {
        public static async Task<T?> GetAsync<T>(this IDistributedCache cache, string key) 
        {
            var value = await cache.GetStringAsync(key);
            return value != null ? JsonConvert.DeserializeObject<T>(value) : default;           
        }

        public static async Task SetAsync<T>(this IDistributedCache cache, string key, T value, DistributedCacheEntryOptions? options = null) 
        {
            var valueString = JsonConvert.SerializeObject(value);
            options = options is null ? new DistributedCacheEntryOptions() : options;
          
            await cache.SetStringAsync(key, valueString, options);
        }
    }
}
