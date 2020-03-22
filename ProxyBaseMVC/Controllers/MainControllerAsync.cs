using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProxyBaseModels;

using ProxyBaseMVC.Data;

namespace ProxyBaseMVC.Controllers {

    /// <summary>Абстрактый класс контролёра.</summary>
    /// <typeparam name="T">Тип сущности.</typeparam>
    public abstract class MainControllerAsync<T> : Controller where T : EntityModel {

        /// <summary>Контекст.</summary>
        public ProxyBaseContext Context { get; }

        /// <summary>Набор сущностей <see cref="T"/>.</summary>
        protected virtual DbSet<T> ModelSet => Context.Set<T>();

        /// <summary>Возвращает новый экземпляр и создаёт контекст.</summary>
        /// <param name="context">Контекст.</param>
        protected MainControllerAsync(ProxyBaseContext context) {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>Возвращает страницу общего списка.</summary>
        public virtual async Task<IActionResult> Index() {
            return View(await ModelSet.ToListAsync().ConfigureAwait(false));
        }

        /// <summary>Возвращает страницу подробных сведений.</summary>
        /// <param name="id">Идентификатор сущности.</param>
        public virtual async Task<IActionResult> Details(int? id) {
            if(id == null) {
                return NotFound();
            }
            var model = await ModelSet.FirstOrDefaultAsync(m => m.Id == id).ConfigureAwait(false);
            if(model == null) {
                return NotFound();
            }
            return View(model);
        }

        /// <summary>Возвращает страницу создания сущности.</summary>
        public virtual IActionResult Create() => View();

        /// <summary>
        /// Записывает новую сущность в <see cref="Context"/>. 
        /// Возвращает страницу общего списка <see cref="MainControllerAsync{T}.Index"/> если создание было успешным.
        /// </summary>
        /// <param name="model">Экземпляр <see cref="T"/> для записи.</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Create([Bind("Description,Id")] T model) {
            if(ModelState.IsValid) {
                ModelSet.Add(model);
                await Context.SaveChangesAsync().ConfigureAwait(false);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        /// <summary>Возвращает данные сущности для редактирования.</summary>
        /// <param name="id">Идентификатор сущности.</param>
        public virtual async Task<IActionResult> Edit(int? id) {
            if(id == null) {
                return NotFound();
            }
            var model = await ModelSet.FindAsync(id);
            if(model == null) {
                return NotFound();
            }
            return View(model);
        }

        /// <summary>
        /// Изменяет и сохраняет сущность в <see cref="Context"/>. 
        /// Возвращает страницу общего списка <see cref="MainControllerAsync{T}.Index"/> если создание было успешным.
        /// </summary>
        /// <param name="id">Идентификатор сущности.</param>
        /// <param name="model">Экземпляр <see cref="T"/> для записи.</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Edit(int id, [Bind("Description,Id")] T model) {
            if(model is null) {
                throw new ArgumentNullException(nameof(model));
            }
            if(id != model.Id) {
                return NotFound();
            }
            if(ModelState.IsValid) {
                try {
                    Context.Update(model);
                    await Context.SaveChangesAsync().ConfigureAwait(false);
                }
                catch(DbUpdateConcurrencyException) {
                    if(!ModelExists(model.Id)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        /// <summary>Возвращает данные сущности для удаления.</summary>
        /// <param name="id">Идентификатор сущности.</param>
        public virtual async Task<IActionResult> Delete(int? id) {
            if(id == null) {
                return NotFound();
            }
            var model = await ModelSet.FirstOrDefaultAsync(m => m.Id == id).ConfigureAwait(false);
            if(model == null) {
                return NotFound();
            }
            return View(model);
        }

        /// <summary>
        /// Удаляет сущность из <see cref="Context"/>
        /// Возвращает страницу общего списка <see cref="MainControllerAsync{T}.Index"/>.
        /// </summary>
        /// <param name="id">Идентификатор сущности.</param>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> DeleteConfirmed(int id) {
            var model = await ModelSet.FindAsync(id);
            ModelSet.Remove(model);
            await Context.SaveChangesAsync().ConfigureAwait(false);
            return RedirectToAction(nameof(Index));
        }

        private bool ModelExists(int id) {
            return ModelSet.Any(e => e.Id == id);
        }

    }

}