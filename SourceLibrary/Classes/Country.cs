namespace SourceLibrary
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>Country class.</summary>
    public class Country : ICountry
    {

        [MaxLength(100)]
        public string Title { get; set; }

    }

}
