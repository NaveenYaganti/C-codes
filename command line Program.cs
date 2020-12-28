using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArguments_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No of command line arguments:" + args.Length);
            foreach (string arg in args)
                Console.WriteLine(arg);
            Console.ReadLine();
        }
    }
}
