using Biblioteca;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;

            Boligrafo boliAzul = new Boligrafo(60, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.ForegroundColor = boliAzul.Color;
            Console.WriteLine($"Tinta restante: {boliAzul.CantidadTinta}");
            //boliAzul.Recargar();
            boliAzul.Pintar(30, out dibujo);
            Console.WriteLine($"{dibujo}");
            Console.WriteLine($"Tinta restante: {boliAzul.CantidadTinta}");

            Console.ForegroundColor = boliRojo.Color;
            Console.WriteLine($"Tinta restante: {boliRojo.CantidadTinta}");
            boliRojo.Pintar(60, out dibujo);
            Console.WriteLine($"{dibujo}");
            Console.WriteLine($"Tinta restante: {boliRojo.CantidadTinta}");

            Console.ResetColor();
        }
    }
}