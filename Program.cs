using System;
using YaTranslate.Core;
using CommandLine;

namespace YaTranslate
{

    public class Options
    {
        [Option('l', "languages", Required = false, HelpText = "Showing if list supported languages")]
        public bool Languages { get; set; }
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
                           core.Languages();
                       }
                   });
        }
    }
}
