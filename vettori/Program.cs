using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
            Vector v2= new Vector(5, 6);
            
            Vector somma =v1+v2;
            Console.WriteLine(somma);
            Vector sottrazione =v1-v2;
            Console.WriteLine(sottrazione);
            Vector prodotto =v1*2;
            Console.WriteLine(prodotto);
            Vector prodottoo=2*v1;
            Console.WriteLine(prodottoo);
            Vector diviso = v1 / 2;
            Console.WriteLine(diviso);
            Vector positivo = +v1;
            Console.WriteLine(positivo);
            Vector negativo = -v1;
            Console.WriteLine(negativo);
            
            Console.ReadLine();

        }
    }
}
