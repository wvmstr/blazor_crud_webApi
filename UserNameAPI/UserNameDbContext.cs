using Microsoft.EntityFrameworkCore;
using UserNameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserNameAPI
{
    public class UserNameDbContext : DbContext
    {
        public DbSet<UserName> UserNames { get; set; }

        public UserNameDbContext(DbContextOptions<UserNameDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region "Seed Data"

            builder.Entity<UserName>().HasData(
                new { NameId = 1, Service = "Outlook.com", Email = "myladys21111@live.com", Password = "", created = DateTime.UtcNow, modified = DateTime.UtcNow }
            );

            builder.Entity<UserName>().HasKey(u => u.NameId);

            #endregion
        }

    }
}
