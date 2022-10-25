using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace football_MVC.Models
{
    public class Jugador
    {

        public class Usuario
        {
            [Required]
            [MinLength(2)]
            public string Name { get; set; }

            [MinLength(2)]
            public int NumberShirt { get; set; }

            
            public Cuadro Club { get; }


            public string Position { get; set; }






        }
    }
}
