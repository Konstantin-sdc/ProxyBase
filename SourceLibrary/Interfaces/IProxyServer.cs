namespace SourceLibrary {
    using System;
    using System.Collections.Generic;

    /// <summary>Proxy Server.</summary>
    internal interface IProxyServer {

        /// <summary>IP-address.</summary>
        IIPaddress Ip { get; set; }

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