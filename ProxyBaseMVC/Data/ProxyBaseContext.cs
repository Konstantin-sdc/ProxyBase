﻿using Microsoft.EntityFrameworkCore;

namespace ProxyBaseMVC.Data {

    public class ProxyBaseContext : DbContext {

        public ProxyBaseContext(DbContextOptions<ProxyBaseContext> options) : base(options) { }


    }

}