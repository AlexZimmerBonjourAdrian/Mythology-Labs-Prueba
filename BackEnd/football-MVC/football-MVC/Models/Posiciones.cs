using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace football_MVC.Models
{
    public class Posiciones
    {
        public enum Posicion { Portero, DefensaCentral, DefensaLateral, MedioCentro, MediaPunta, MedioCentroDefensivo, InteriorDerecho, InteriorIzquierdo, DelanteroCentro, SegundaPunta, Extremo, None, Banca, Tecnico };
    }
}
