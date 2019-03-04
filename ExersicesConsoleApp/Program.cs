using ExersicesConsoleApp.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersicesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            //null-coalescing operator

            int? i = null;

            var res = i ?? default(int);

            //new Basics().BoxingUnboxingExample();
            //new AsyncExamples().Main();
            //new AsyncExamples().MultiThreadParallel();

            var duplicate = new Arrays().FindDuplicateInArrangedNumbers(new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine("duplicate = " + duplicate);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
