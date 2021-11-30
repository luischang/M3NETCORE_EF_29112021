using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3NETCORE_EF.CodeFirst.Models
{
    public class MundialQatarDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=*;User=MyUserDB;Pwd=MyPasswordDB";
            string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=QatarDB;Trusted_Connection=true;MultipleActiveResultSets=true";

            builder.UseSqlServer(cnx)
                    .LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(builder);

        }

        public virtual DbSet<Player> Player { get; set; }

        public virtual DbSet<PlayerPosition> PlayerPosition { get; set; }
        public virtual DbSet<Team> Team { get; set; }


    }
}
