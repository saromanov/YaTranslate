using System;
using YaTranslate.Core;
using CommandLine;

namespace YaTranslate
{
    public class Options
    {
        [Option('h', "help", Required = false, HelpText = "Showing of help info")]
        public bool Verbose { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                System.Console.WriteLine("Please enter arguments");
                return;
            }
            using (ProgramCore core = new ProgramCore())
            {
                core.Execute();
            }
        }
    }
}
