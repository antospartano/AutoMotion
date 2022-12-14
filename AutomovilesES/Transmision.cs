using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles.Models
{
    [Table(name: "Transmisiones")]

    public class Transmision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Transmision Del Vehiculo")]
        public int Id { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("Tipo")]
        [Display(Name = "Tipo de transmision")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
