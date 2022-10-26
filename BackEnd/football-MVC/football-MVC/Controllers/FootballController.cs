using football_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace football_MVC.Controllers
{
    public class FootballController : Controller
    {
        //public void ComprarJugadores(string Nombre, string Apellido, string nacionalidad, DateTime FdeN, Posiciones.Posiciones posicion = Posiciones.Posiciones.None,Bit);
        //{
        //}
        
        public  void VenderJugador(int idJugador, string NombreCuadro)
        {

        }
        
        public  void AgregarCuadro(int Nombre, Jugador[] jugadores,string Pais, string Formacion)
        {
            
        }
        
        public void AgregarCancha(string Nombre, string Pais, string Ciudad, string Estado)
        {

           

        }


        //public void AgregarCancha(int Nombre, string Pais, string Ciudad, string Estado, Partido[] Partidos)
        //{


        //}

        public void OranizarPatido(Cuadro cuadro_1, Cuadro cuadro_2, DateTime DiaHora, int IdCancha)
        {

        }

        public void AsgnarPosicion(int IdJugador, Posiciones.Posicion posicion)
        {
            
        }

       
       public IActionResult Error()


        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
        //GET: /Football/
        public string Index()
        {
            return "This is my default action....";
        }
        // GET: /Football/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
