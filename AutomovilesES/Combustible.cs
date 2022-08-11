using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles.Models
{
    [Table(name: "Combustibles")]

    public class Combustible
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Tipo de combustible")]
        public int Id { get; set; }


        [StringLength(20)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("nombre")]
        [Display(Name = "Combustible")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
