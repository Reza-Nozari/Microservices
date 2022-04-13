using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task task = new Task(HelloWord);
            task.Start();

            Console.WriteLine("Main Task");

        }

        private static void HelloWord()
        {
            Console.WriteLine("Main Task");
        }
    }
}
