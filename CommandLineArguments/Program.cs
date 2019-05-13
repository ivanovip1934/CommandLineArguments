using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Program
    {
         
       

        static void Main(string[] args)
        {
            Options opt = new Options(args);

            if (File.Exists(opt.FileConfig))
                Console.WriteLine($"File  {opt.FileConfig} is exist");
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: file NOT found: {opt.FileConfig}");
                Console.ResetColor();
                Environment.Exit(1);

            }



            // List<string> Args = new List<string>(args);
            //List<string> Flags = new List<string>();


            //Console.WriteLine($"Flags: {String.Join(",",Flags)}");
            //Console.WriteLine($"Args: {String.Join(",",Args)}");


        }

        //static List<string> ParserFlags( List<string> _args) {
        //    List<string> _flags = new List<string>();

        //    foreach (string _arg in _args) {
        //        if (new Regex(@"^(--\w+|-\w+|/\w+)").IsMatch(_arg)) _flags.Add(_arg);
        //    }
        //    return _flags;
        //}
    }
}
