using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemigo enemigo
                = new Enemigo();
            enemigo.x = 500;
            enemigo.y = 800;

            Console.WriteLine("X: " + enemigo.x);
            Console.WriteLine("y: " + enemigo.y);

            try
            {
                enemigo.Ganas = 5000;
                Console.WriteLine("Ganas: " + enemigo.Ganas);
            }
            catch
            {
                Console.WriteLine("Debes tener mas de 100 puntos");
            }
            Console.Read();
        }
    }
}
