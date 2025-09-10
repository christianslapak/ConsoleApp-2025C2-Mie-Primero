namespace ConsoleApp_2025C2_Mie_Primero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona p = new Persona();
            p.dni = 34567890;
            p.apellido = "De Paul";
            p.nombre = "Rodigo";

            Console.WriteLine(p.MostrarDatos());
            Console.ReadKey();

            Alumno a = new Alumno();
            a.dni = 40123456;
            a.apellido = "Gonzalez";
            a.nombre = "Alejandra";
            a.legajo = 213131;
            a.materia = "PNT1";

            Console.WriteLine(a.MostrarDatos());

        }
    }
}
