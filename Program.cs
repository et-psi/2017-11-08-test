using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additionneur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculateur");
            Console.WriteLine("============" + Environment.NewLine);

            Console.Write("Saisir une valeur réélle : ");
            double dblVal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("valeur saisie : " + dblVal1.ToString());


            Console.Read();
        }
    }
}
