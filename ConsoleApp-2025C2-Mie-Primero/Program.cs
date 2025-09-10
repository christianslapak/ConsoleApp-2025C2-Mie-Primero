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

        }
    }
}
