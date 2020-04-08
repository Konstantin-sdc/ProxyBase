using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using ProxyBaseMVC.Data;

using System;
using System.Linq;

namespace ProxyBaseMVC.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProxyBaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProxyBaseContext>>()))
            {
                if (context.Proxies.Any())
                {
                    return;
                }



                //context.AddRange(testProxy);
                context.SaveChanges();
            }
        }
    }
}
