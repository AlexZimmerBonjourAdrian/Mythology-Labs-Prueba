using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace football_MVC.Models
{
    public class Cancha
    {
        [Required]
        public string Name { get; set; }
        public string Estado { get; set; }

        public string Ciudad { get; set; }
        public string Pais { get; set; }
       
        



    }
}
