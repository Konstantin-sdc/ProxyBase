using System.ComponentModel.DataAnnotations;

namespace SourceLibrary {

    /// <summary>Представляет элементы, которые существуют в большинстве классов этой библиотееки.</summary>
    public interface IStandartMembers {

        /// <summary>Примечание.</summary>
        [Display(Name = "Примечание")]
        string Description { get; set; }

        /// <summary>Имя или название.</summary>
        [Display(Name = "Имя")]
        string Name { get; set; }

    }

}