namespace SourceLibrary {

    /// <summary>City interface.</summary>
    public interface ICity {

        /// <summary>City title.</summary>
        string Title { get; set; }

        /// <summary>City Country.</summary>
        ICountry Country { get; set; }

    }

}
