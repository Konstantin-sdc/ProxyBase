using System.ComponentModel.DataAnnotations;

namespace SourceLibrary {

    /// <summary>Country class.</summary>
    public class Country : ICountry {

        [MaxLength(100)]
        public string Title { get; set; }

    }

}
