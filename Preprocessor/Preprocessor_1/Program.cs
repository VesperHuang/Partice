#define DEBUG 
#undef DEBUG
#define TRACE
// /define:DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (DEBUG)
                Console.WriteLine("Debugging is enabled.");
            #elif (TRACE)
                Console.WriteLine("Tracing is enabled.");
            #else
                Console.WriteLine("Debugging is not enabled.");
            #endif

            Console.ReadLine();
        }
    }
}
