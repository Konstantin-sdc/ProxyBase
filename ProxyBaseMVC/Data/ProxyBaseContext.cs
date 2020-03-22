using Microsoft.EntityFrameworkCore;

using ProxyBaseModels;

namespace ProxyBaseMVC.Data {

    public class ProxyBaseContext : DbContext {

        public ProxyBaseContext(DbContextOptions<ProxyBaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            if(modelBuilder is null) {
                throw new System.ArgumentNullException(nameof(modelBuilder));
            }
            //ClearDb(modelBuilder);
            base.OnModelCreating(modelBuilder);
            //Build(modelBuilder);
        }

        private void ClearDb(ModelBuilder modelBuilder) {
            modelBuilder.Ignore<ProxyModel>();
            modelBuilder.Ignore<ProtocolModel>();
        }

        private void Build(ModelBuilder modelBuilder) {

            var proxies = modelBuilder.Entity<ProxyModel>().OwnsOne(o => o.ProxyServer);
            proxies.Property(p => p.Ip).HasColumnName("Ip");
            proxies.Property(p => p.IsWork).HasColumnName("IsWork");
            proxies.Property(p => p.Port).HasColumnName("Port");
            proxies.Property(p => p.LastResponse).HasColumnName("LastResponse");
            proxies.Property(p => p.Protocols).HasColumnName("Protocols");
            proxies.Property(p => p.ResponseTime).HasColumnName("ResponseTime");

            var protocols = modelBuilder.Entity<ProtocolModel>().OwnsOne(o => o.Protocol);
            protocols.HasIndex(p => p.Type).IsUnique();

        }

        /// <summary>Набор сущностей <see cref="ProxyModel"/> в БД.</summary>
        public DbSet<ProxyModel> Proxies { get; set; }

        /// <summary>Набор сущностей <see cref="ProtocolModel"/> в БД.</summary>
        public DbSet<ProtocolModel> Protocols { get; set; }

    }

}
