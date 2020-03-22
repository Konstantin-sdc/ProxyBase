using SourceLibrary;
namespace ProxyBaseModels {

    /// <summary>Класс модели для <see cref="SourceLibrary.Protocol"/>.</summary>
    public class ProtocolModel : EntityModel {

        public ProtocolModel() {
            Protocol = new Protocol();
        }

        public Protocol Protocol { get; set; }

    }

}
