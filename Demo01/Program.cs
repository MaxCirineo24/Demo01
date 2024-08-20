using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int area = 0;
            int perimetro = 0;
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            area = rectangulo.CalcularArea();
            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El area es:");
            Console.WriteLine(area);
            Console.WriteLine("El perimetro es:");
            Console.WriteLine(perimetro);

            Persona1 persona1 = new Persona1
            {
                Nombres = "Max",
                Apellidos = "Cirineo",
            };
            persona1.AsignarNombresCompletos();
            Console.WriteLine(persona1.NombresCompletos);

            Console.WriteLine("Hola Mundo");
            Console.Read();
        }
    }
}
