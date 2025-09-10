using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2025C2_Mie_Primero
{
    internal class Persona
    {
        public int dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }

        public string MostrarDatos()
        {
            string mensaje = "";
            mensaje = "La persona es: " + dni + " " + apellido + " " + nombre;
            return mensaje;
        }
    }
}
