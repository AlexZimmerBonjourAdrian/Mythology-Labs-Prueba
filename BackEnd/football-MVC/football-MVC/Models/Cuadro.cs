using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace football_MVC.Models
{
    public class Cuadro
    {
        [Required]
        public string name { get; set; }

        public string pais { get; set; }

        public Jugador[] Jugadores { get; set; }

        [MinLength(4)]
        public string Formation { get; set; }

    }
}
