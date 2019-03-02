using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica05Productos.Models
{
    public class Producto
    {
        // Para tomar la PK por default se debe nombrar Id
        // Sino se desea usar este nombre se debe colocar la anotacion [KEY]
        public int Id { get; set; }

        [Required]  // Data Annotations para que sea obligatoria
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        // Rango de valores aceptado para el campo existencia
        [Range(0,99,ErrorMessage ="La existencia debe estar en el rango de 0 a 99")]
        public int Existencias { get; set; }

        [Display(Name ="Producto Descontinuado")]
        public bool Descontinuado { get; set; }

        // Ciertos tipos de datos, por naturaleza no son opcionales como el Decimal
           
    }
}
