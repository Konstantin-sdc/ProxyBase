namespace SourceLibrary
{
    using System;

    /// <summary>Основные протоколы прокси-серверов.</summary>
    [Flags]
    public enum ProtocolsEnum
    {
        /// <summary>http protocol.</summary>
        http,
        /// <summary>https protocol.</summary>
        https,
        /// <summary>socks4 protocol.</summary>
        socks4 = 4,
        /// <summary>sock5 protocol.</summary>
        sock5 = 5
    }

}
