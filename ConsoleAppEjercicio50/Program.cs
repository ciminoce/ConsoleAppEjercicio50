using System;

namespace ConsoleAppEjercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de nros al azar");
            Random r = new Random();//Clase para la generación de nros al azar;
            int sumador = 0;
            int contador = 0;
            do
            {
                var nroGenerado = r.Next(1, 101);//Devuelve nros entre 1 y n-1
                contador++;
                sumador += nroGenerado;
                Console.WriteLine($"Nro genrado: {nroGenerado} suma parcial:{sumador}");

            } while (sumador<=1000);

            Console.WriteLine($"Se generaron {contador} nros");
        }
    }
}
