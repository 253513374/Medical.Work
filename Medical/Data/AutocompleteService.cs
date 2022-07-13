using Microsoft.Extensions.Caching.Memory;

namespace Medical.Data
{
    public class AutocompleteService
    {

        public IMemoryCache MemoryCache { set; get; }

        public AutocompleteService()
        {
            MemoryCache = new MemoryCache(new MemoryCacheOptions());
        }
    }
}