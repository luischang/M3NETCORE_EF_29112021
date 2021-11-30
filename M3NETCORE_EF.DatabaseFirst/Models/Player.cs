using System;
using System.Collections.Generic;

#nullable disable

namespace M3NETCORE_EF.DatabaseFirst.Models
{
    public partial class Player
    {
        public Player()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Dorsal { get; set; }
        public int Age { get; set; }
        public int? PlayerPositionId { get; set; }

        public virtual PlayerPosition PlayerPosition { get; set; }
        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
