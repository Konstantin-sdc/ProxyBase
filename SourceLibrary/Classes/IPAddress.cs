using System;
using System.ComponentModel.DataAnnotations;

namespace SourceLibrary {

    /// <summary>IP-address class.</summary>
    public class IPAddress : IIPaddress, IPrimaryKey {

        public int Id { get; set; }

        /// <summary>IPv4 address.</summary>
        [MinLength(7)]
        [MaxLength(15)]
        public string IPString {
            get => IPString;
            set {
                if (value.Length < 7 || value.Length > 15) throw new ArgumentOutOfRangeException(value);
            }
        }

        public IGeoLocation Location { get; set; }

    }

}
