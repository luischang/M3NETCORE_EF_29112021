using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3NETCORE_MVCEF.CodeFirst.Models
{
    public class QatarDB2022 : DbContext
    {

        public QatarDB2022(DbContextOptions<QatarDB2022> options) : base(options)
        {

        }

        public virtual DbSet<Player> Player { get; set; }
    }
}
