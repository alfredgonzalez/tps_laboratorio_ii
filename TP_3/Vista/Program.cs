using System;
using Entidades;


namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Novela novela = new Novela(Novela.EGenero.Terror, 5000, "Alfredo Gonzalez");
            Novela novela2 = new Novela(Novela.EGenero.Policial, 3500, "Garcia Marquez");
            Comic cm = new Comic(3500, "Akira Torishama", Comic.ETipoComic.Oriental);
            Comic cm2 = new Comic(5000, "Satori Kioto", Comic.ETipoComic.Occidental);
            DateTime dt = DateTime.UtcNow;
            novela.CalcularVenta();
            Console.WriteLine($"{novela.ToString()}");
            Console.ReadKey();
            novela2.CalcularVenta();
            Console.WriteLine($"{novela2}");

            Console.WriteLine($"{cm}");

            Console.WriteLine($"{cm2.CalcularVenta()}");
            Console.WriteLine($"{cm2}");
            


            
        }
    }
}
