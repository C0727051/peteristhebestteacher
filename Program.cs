using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0727051
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();
            dogs.Add("Bulldog");
            dogs.Add("Poodie");
            dogs.Add("Retriever");
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog + "");
            //}
            //Console.ReadLine();
            int[] a1 = new int[](1, 3, 5, 7, 9, 11);

        foreach (int i in a1)
            {
                Console.WriteLine("the value of i is" + i);
            }

        }

    }
}
