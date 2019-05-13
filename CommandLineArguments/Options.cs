using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Options
    {
        private string fileconfig;
        public string FileConfig { get { return fileconfig; } }
        private bool help;
        public bool Help{get { return help; } }

        public Options(string[] _args)  {

            ParseArgs(_args);

        }

        private void ParseArgs(string[] _args)
        {
            Stack<string> args = new Stack<string>(_args.Reverse());
            string key;

            if (args.Count >= 1)
            {
                key = args.Pop();
            }
            else
            {
                key = "";
            }

            if (new Regex(@"^\-(\-fileconfig|f)$",RegexOptions.IgnoreCase).IsMatch(key))
            {
                if (args.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You not set value for \"{key}\"");
                    Console.ResetColor();
                    Environment.Exit(1);

                }
                else if (args.Count > 1) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: the parameter \"{key}\" is set to more than one value");
                    Console.ResetColor();
                    Environment.Exit(1);
                }

                fileconfig = args.Pop();
                if (new Regex(@"^\-{1,2}\w+$", RegexOptions.IgnoreCase).IsMatch(fileconfig))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You set unknow parameter \"{fileconfig}\"");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
                //Console.WriteLine($"Key: {key} {Environment.NewLine} Path to file: {fileconfig}");
            }
            else if (new Regex(@"^\-(\-help|h)$", RegexOptions.IgnoreCase).IsMatch(key))
            {
                help = true;
                Console.WriteLine("Using programm: prog  [--fileconfig|-f] full_path_to_file");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine($"This programm not know parameter \"{key}\"");
                Environment.Exit(1);
            }
        }

            #region Old reshenie

            //    string[] _flag = new string[] { };
            //    bool addProp = false;
            //    bool GetKey = false;
            //    List<string> GetParam =new List<string>();
            //    Dictionary<string, List<string>> param = new Dictionary<string, List<string>>();

            //    foreach (string _arg in _args)
            //    {
            //        if (!addProp)
            //        {

            //            {
            //                if (GetKey && GetParam.Count>0) {
            //                    param.Add(_flag.ToString(), GetParam);
            //                }


            //                if (SearchFlags(_arg))
            //                {
            //                    addProp = false;
            //                    _flag += _arg;
            //                    GetKey = true;

            //                }
            //                else
            //                {
            //                    Console.WriteLine("Exit from prog");
            //                    Environment.Exit(0);
            //                }
            //            }
            //            else
            //            {
            //                GetParam.Add(_arg);
            //            }
            //        }


            //    }           

            //}

            //private bool SearchFlags(string _arg)
            //{

            //    if (new Regex(@"^\-(\-fileconfig|f)$").IsMatch(_arg))
            //    {
            //        Console.WriteLine(_arg);
            //        return true;
            //    }
            //    if (new Regex(@"^\-(\-help|h)$").IsMatch(_arg))
            //    {
            //        Console.WriteLine(_arg.ToString());
            //        return true;
            //    }

            //    Console.WriteLine($"I am don`t know parameter \"{_arg}\"");
            //    return false;





            //}

            #endregion

        }
    }
