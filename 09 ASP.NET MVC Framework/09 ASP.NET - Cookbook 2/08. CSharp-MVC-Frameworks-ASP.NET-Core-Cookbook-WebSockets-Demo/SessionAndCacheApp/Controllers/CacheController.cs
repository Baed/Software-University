using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace SessionAndCacheApp.Controllers
{
    public class CacheController : Controller
    {
        private readonly IMemoryCache cache;

        public CacheController(IMemoryCache cache)
        {
            this.cache = cache;
        }

        public IActionResult Index()
        {
            const string cacheDateKey = "Cache_Current_Date";

            var value = this.cache.Get<string>(cacheDateKey);

            if (value == null)
            {
                value = DateTime.UtcNow.ToLongTimeString();
                this.cache.Set(cacheDateKey, value, DateTimeOffset.UtcNow.AddMinutes(30));
            }

            return View(model: value);
        }
    }
}
