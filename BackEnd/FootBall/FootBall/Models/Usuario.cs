using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBall.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string correo { get; set; }

        public string username { get; set; }

        public string password { get; set; }
    }
}
