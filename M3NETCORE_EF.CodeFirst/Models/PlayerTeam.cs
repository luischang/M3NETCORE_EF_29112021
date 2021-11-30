using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3NETCORE_EF.CodeFirst.Models
{
    public class PlayerTeam
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        //public DateTime StartDate { get; set; }
        //public DateTime FinishDate { get; set; }

        public virtual Player Player { get; set; }
        public virtual Team  Team { get; set; }
    }
}
