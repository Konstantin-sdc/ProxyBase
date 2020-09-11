namespace SourceLibrary {
    using System;

    /// <summary>Geographical coordinates.</summary>
    public class GeoLocation : IGeoLocation, IPrimaryKey {

        public int Id { get; set; }

        public double Latitude {
            get => Latitude;
            set {
                if (value < -90 || value > 90) throw new ArgumentOutOfRangeException(value.ToString());
            }
        }

        public double Longtitude {
            get => Longtitude;
            set {
                if (value < -180 || value > 180) throw new ArgumentOutOfRangeException(value.ToString());
            }
        }

        /// <summary>Return connected string <see cref="Latitude"/>,<see cref="Longtitude"/></summary>
        public override string ToString() {
            Latitude.ToString();
            return $"{Latitude},{Longtitude}";
        }

    }

}
