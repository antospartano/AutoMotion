using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles.Models
{
    [Table(name: "Marcas")]

    public class Marca
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("id")]
        [Display(Name = "Codigo de la marca")]
        public int Id { get; set; }


        [StringLength(60)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("nombre")]
        [Display(Name = "Marca")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
