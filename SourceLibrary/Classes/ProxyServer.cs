using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SourceLibrary
{

    /// <summary>Прокси сервер.</summary>
    [Serializable]
    public sealed class ProxyServer
    {

        [field: NonSerialized]
        [MinLength(7)]
        [MaxLength(15)]
        public string Ip { get; set; }

        [Range(0, 65535)]
        public int Port
        {
            get => Port;
            set
            {
                if (value < 0 || value > 65535) throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public bool IsWork { get; set; }
        public int ResponseTime { get; set; }
        public IEnumerable<ProtocolsEnum> Protocols { get; set; }

        [field: NonSerialized]
        public DateTime LastResponse { get; set; }

    }

}
