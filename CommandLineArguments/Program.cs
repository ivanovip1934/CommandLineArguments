using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> Args = new Stack<String>(args.Reverse());

            string Verb;

            #region Get Verb using  if - esle

            if (Args.Count >= 1)
            {
                Verb = Args.Pop();
            }
            else
            {
                Verb = "";
                Console.WriteLine("Not set parameters");
                Environment.Exit(0);

            }
            #endregion



            Console.WriteLine($"Verb: {Verb}");

            switch (Verb.ToUpper()) {
                case "FILE":
                    Console.WriteLine($"Hello , file name is:  {Args.Pop()}");
                    break;
                case "HELP":
                    Console.WriteLine("Dis programs is test parameters for program");
                    break;
                default:
                    Console.WriteLine("Not parse parameters");
                    break;
            }

        }
    }
}
