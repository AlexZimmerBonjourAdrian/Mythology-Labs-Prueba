using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace football_MVC.Models
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public Cuadro Cuadro1 { get; set; }

        public Cuadro Cudro2 { get; set; }

        public DateTime DiaHora { get; set; }

     
    }
}
