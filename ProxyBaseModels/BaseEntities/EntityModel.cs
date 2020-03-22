using System.ComponentModel.DataAnnotations;

namespace ProxyBaseModels {

    /// <summary>Исходный класс модели.</summary>
    public class EntityModel : IEntityModel {

        [Key]
        [Display(Name = "Идентификатор в БД")]
        public int Id { get; set; }

        /// <summary>
        /// Возвращает сообщение <see cref="System.InvalidOperationException(string)"/> при недопустимом обращении к члену класса.
        /// </summary>
        protected virtual string InvalidCall {
            get => "Обращение к этому члену класса недопустимо.";
            set { }
        }

    }

}