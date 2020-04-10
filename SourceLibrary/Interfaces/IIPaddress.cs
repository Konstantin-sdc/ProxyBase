namespace SourceLibrary {

    /// <summary>Internet Protocol Address.</summary>
    public interface IIPaddress {

        /// <summary>IP-address in string notation.</summary>
        public string IPString { get; set; }

        /// <summary>IP-address location.</summary>
        public IGeoLocation Location { get; set; }

    }

}
