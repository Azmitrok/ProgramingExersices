using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExersicesConsoleApp
{
    public class AsyncExamples
    {
        public void Main()
        {
            Operation operation = new Operation();

            //string result = operation.RunSlowOperation();
            //Task<string> result = operation.RunSlowOperationTask();
            Task<string> result = operation.RunSlowOperationTaskAsync();
            operation.RunTrivialOperation();

            Console.WriteLine("Return value of slow operation: {0}", result);
            Console.WriteLine("The main thread has run complete on thread number {0}", Thread.CurrentThread.ManagedThreadId);            
        }

        public void MultiThreadParallel()
        {
            var files = Directory.GetFiles("C:\\Data", "*.*", SearchOption.AllDirectories).ToList();

            var sw = Stopwatch.StartNew(); //start timer
            files.ForEach(f =>  File.ReadAllBytes(f).GetHashCode()); //do work - serial
            sw.Stop(); //stop
            Console.WriteLine("Run MS - Serial: " + sw.ElapsedMilliseconds);             

            sw.Restart();
            files.AsParallel().ForAll(f => File.ReadAllBytes(f).GetHashCode()); //parallel
            sw.Stop();
            Console.WriteLine("Run MS - Parallel: " + sw.ElapsedMilliseconds);
            
        }
    }

    public class Operation
    {
        public string RunSlowOperation()
        {
            Console.WriteLine("Slow operation running on thread id {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("Slow operation about to finish on thread id {0}", Thread.CurrentThread.ManagedThreadId);
            return "This is very slow...";
        }

        public Task<string> RunSlowOperationTask()
        {
            return Task.Factory.StartNew<string>(RunSlowOperation);
        }

        public async Task<string> RunSlowOperationTaskAsync()
        {
            Console.WriteLine("Slow operation running on thread id {0}", Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(2000);
            Console.WriteLine("Slow operation about to finish on thread id {0}", Thread.CurrentThread.ManagedThreadId);
            return "This is very slow...";
        }

        public void RunTrivialOperation()
        {
            string[] words = new string[] { "i", "love", "dot", "net", "four", "dot", "five" };
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
