using System.ComponentModel.DataAnnotations;
namespace SourceLibrary {

    /// <summary>Представляет элементы, которые существуют в большинстве классов этой библиотееки.</summary>
    public abstract class StandartMembers : IStandartMembers {

        [Display(Name = "Имя")]
        public virtual string Name { get; set; }

        [Display(Name = "Примечание")]
        public virtual string Description { get; set; }

        /// <summary>Возвращает строковое представление экземпляра — <see cref="Name"/></summary>
        /// <returns><see cref="Name"/></returns>
        public override string ToString() {
            return Name;
        }

    }

}
