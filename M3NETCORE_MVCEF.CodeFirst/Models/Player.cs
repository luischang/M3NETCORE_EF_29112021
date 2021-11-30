using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M3NETCORE_MVCEF.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name ="Nombre del Futbolista")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "N° de Camiseta")]
        [Required(ErrorMessage = "El número de camiseta es obligatorio y tiene que ser un número menor a 100")]
        public int Dorsal { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "Edad")]
        public int Age { get; set; }
        [Column(TypeName = "Date")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }
    }
}
