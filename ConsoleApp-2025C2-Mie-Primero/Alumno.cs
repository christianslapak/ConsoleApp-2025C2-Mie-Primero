using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp_2025C2_Mie_Primero
{
    internal class Alumno:Persona
    {
        public int legajo { get; set; }
        public string materia { get; set; }
    }

    public string MostrarDatos()
    {
        string mensaje = "";
        mensaje = base.MostrarDatos() + " " + legajo + " " + materia;
        return mensaje;
    }
}
