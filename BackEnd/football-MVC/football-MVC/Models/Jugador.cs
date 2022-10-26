using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace football_MVC.Models
{
    public class Jugador
    {


        [Required]
            [MinLength(2)]
           
            public int Id { get; set; }
            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public string Nacionalidad { get; set; }
            public DateTime FdeN { get; set; }

            public Posiciones Posicion { get; set; }

            public string Foto { get; set; }

            public string CamisetaImagen { get; set; }
            
            public string NumeroCamiseta { get; set; }





    }
   

}
