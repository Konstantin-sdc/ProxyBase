using SourceLibrary;

namespace ProxyBaseModels {

    /// <summary>Класс модели для типа <see cref="SourceLibrary.ProxyServer"/>.</summary>
    public class ProxyModel : EntityModel {

        public ProxyModel() {
            ProxyServer = new ProxyServer();
        }

        public ProxyServer ProxyServer { get; set; }
    }

}
