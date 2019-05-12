using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Program
    {
        static List<string> Args;
       static List<string> Flags;

        static void Main(string[] args)
        {
            Args = new List<string>(args);
            ParserFlags();

            Console.WriteLine($"Flags: {String.Join(",",Flags)}");
            Console.WriteLine($"Args: {String.Join(",",Args)}");


        }

        static void ParserFlags() {
            foreach (string Arg in Args) {
                if (new Regex(@"^--").IsMatch(Arg)) Flags.Add(Arg);
            }
        }
    }
}
