using System;
using YaTranslate.Core;
using CommandLine;

namespace YaTranslate
{

    public class Options
    {
        [Option('l', "languages", Required = false, HelpText = "Showing if list supported languages")]
        public bool Languages { get; set; }

        [Option('t', "token", Required = true, HelpText = "Token of the app")]
        public string Token { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProgramCore core = new ProgramCore(args);
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                   {
                       if (o.Languages)
                       {
                           Console.WriteLine(o.Token);
                           core.Languages();
                       }
                   });
        }
    }
}
