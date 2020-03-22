namespace SourceLibrary {

    /// <summary>Протокол.</summary>
    public class Protocol : IProtocol {

        /// <summary>Возвращает новый экземпляр <see cref="Protocol"/>.</summary>
        public Protocol() { }

        /// <summary>Возвращает новый экземпляр <see cref="Protocol"/> с заданным названием.</summary>
        /// <param name="name">Название протокола.</param>
        public Protocol(ProtocolsEnum type) {
            Type = type;
        }

        public ProtocolsEnum Type { get; set; }
    }

}
