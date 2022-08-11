using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles.Models
{
    [Table(name: "Paises")]

    public class Pais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Codigo del pais")]
        public int Id { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("nombre")]
        [Display(Name = "Nombre del pais")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
