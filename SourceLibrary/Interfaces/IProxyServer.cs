using System;
using System.Collections.Generic;

namespace SourceLibrary {
    /// <summary>Proxy Server.</summary>
    public interface IProxyServer {
        /// <summary>Ip address.</summary>
        string Ip { get; set; }

        /// <summary>Is work or not.</summary>
        bool IsWork { get; set; }

        /// <summary><see cref="DateTime"/> of last response.</summary>
        DateTime LastResponse { get; set; }

        /// <summary>Server port.</summary>
        int Port { get; set; }

        /// <summary>Protocols, used by this server.</summary>
        IEnumerable<ProtocolsEnum> Protocols { get; set; }
        int ResponseTime { get; set; }

    }
}