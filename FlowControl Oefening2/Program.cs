using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl_Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geef een getal in:");
            int j = Int32.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i <= j; i++)
            {
                Console.WriteLine($"de getallen zijn: {i} ");
                k = k + i;
                Console.WriteLine($"de som is: {k}");
            }
        }
    }
}
