using System.ComponentModel.DataAnnotations;

namespace ProxyBaseModels {

    /// <summary>Исходный интерфейс модели.</summary>
    public interface IEntityModel {

        /// <summary>Первичный ключ.</summary>
        int Id { get; set; }

    }

}