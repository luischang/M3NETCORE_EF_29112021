using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3NETCORE_EF.CodeFirst.Models
{
    [Table("PlayerPosition")]
    public class PlayerPosition
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public string Code { get; set; }
        public virtual List<Player> Player { get; set; } 

    }
}
