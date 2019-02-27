using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersicesConsoleApp
{
    public class Basics
    {
        public void BoxingUnboxingExample()
        {
            int num = 23; // 23 will assigned to num

            Object obj = num; // Boxing

            int int1 = (int)obj;

            Console.WriteLine("int = " + int1); //implicit boxing.

            Console.WriteLine("int = " + int1.ToString()); //correct

            var start = DateTime.Now;

            for(int i = 0; i < 500; i++)
            {
                Console.WriteLine(string.Format("values are {0}, {1}, {2};", i, i+1, i+2));
            }

            var time1 = (DateTime.Now - start).Milliseconds;
            Console.WriteLine($"Loop took {time1} miliseconds");

            start = DateTime.Now;

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(string.Format("values are {0}, {1}, {2};", i.ToString(), (i + 1).ToString(), (i + 2).ToString()));
            }

            var time2 = (DateTime.Now - start).Milliseconds;

            Console.WriteLine($"Loop took {time2} miliseconds");

            //ArrayList, HashTable - do not use because of boxing/unboxing!
        }
    }
}
