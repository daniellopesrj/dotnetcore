using System;

namespace designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ICMS icms = new ICMS();
            ISS iss = new ISS();

            CalcularImposto c = new CalcularImposto();
            
            Console.WriteLine("Design Pattern : Strategy");

            Console.WriteLine(c.Calcular(1000,iss));



        }
    }




}
