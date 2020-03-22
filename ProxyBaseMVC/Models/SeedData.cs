using System;

using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using ProxyBaseModels;

using ProxyBaseMVC.Data;

namespace ProxyBaseMVC.Models {
    public static class SeedData {

        public static void Initialize(IServiceProvider serviceProvider) {
            using(var context = new ProxyBaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProxyBaseContext>>())) {
                if(context.Proxies.Any()) {
                    return;
                }



                //context.AddRange(testProxy);
                context.SaveChanges();
            }
        }
    }
}
