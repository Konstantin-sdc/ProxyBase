using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProxyBaseModels;

using ProxyBaseMVC.Data;

namespace ProxyBaseMVC.Controllers {

    /// <summary>Класс контролёра для работы с <see cref="ProxyBaseContext.Proxies"/></summary>
    public class ProxiesController : MainControllerAsync<ProxyModel> {
        public ProxiesController(ProxyBaseContext context) : base(context) { }

        public override async Task<IActionResult> Index() {
            var result = ModelSet.Include(o => o.City);
            return View(await result.ToListAsync().ConfigureAwait(false));
        }

    }

}