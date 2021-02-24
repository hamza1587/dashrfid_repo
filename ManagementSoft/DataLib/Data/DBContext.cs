using DataLib.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Associations> Associations { get; set; }
        public DbSet<ReadersInventory> ReadersInventory { get; set; }
        public DbSet<ReadingRPASFlux> ReadingRPASFlux { get; set; }
        public DbSet<ReadingTagsFlux> ReadingTagsFlux { get; set; }
        public DbSet<RFIDLocations> RFIDLocations { get; set; }
        public DbSet<RFIDNotifications> RFIDNotifications { get; set; }
        public DbSet<RFIDSysStatus> RFIDSysStatus { get; set; }
        public DbSet<TagsInventory> TagsInventory { get; set; }
        [Obsolete]
        public DbQuery<TimeSpent> TimeSpent { get; set; }
        [Obsolete]
        public DbQuery<TimeSpentOperations> TimeSpentOperations { get; set; }

        [Obsolete]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Query<TimeSpentOperations>().ToView("TimeSpentOperations");
           modelBuilder.Query<TimeSpent>().ToView("TimeSpent");
        }


    }
}
