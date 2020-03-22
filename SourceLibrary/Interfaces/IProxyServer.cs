using System;
using System.Collections.Generic;

namespace SourceLibrary {

    public interface IProxyServer {

        /// <summary>Ip v4 адрес.</summary>
        string Ip { get; set; }

        /// <summary>Порт сервера.</summary>
        int Port { get; set; }

        /// <summary>Работает ли сервер.</summary>
        bool IsWork { get; set; }

        /// <summary>Задержка, милисекунд.</summary>
        int ResponseTime { get; set; }

        /// <summary>Используемые протоколы.</summary>
        IEnumerable<ProtocolsEnum> Protocols { get; set; }

        /// <summary>Время последнего ответа.</summary>
        DateTime LastResponse { get; set; }

    }

}
