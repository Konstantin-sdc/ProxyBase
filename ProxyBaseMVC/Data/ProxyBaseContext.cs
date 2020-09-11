namespace ProxyBaseMVC.Data
{
    using Microsoft.EntityFrameworkCore;

    public class QWER { }

    public class ProxyBaseContext : DbContext
    {

        public ProxyBaseContext(DbContextOptions<ProxyBaseContext> options) : base(options) { }

    }

}