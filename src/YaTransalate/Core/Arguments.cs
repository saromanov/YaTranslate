using System;
using CommandLine;

public class Options
{
    [Option('l', "languages", Required = false, HelpText = "Showing if list supported languages")]
        public bool Languages { get; set; }
}

public class ArgumentParser {
    private string[] args;
    public ArgumentParser(string[] args) {
        args = args;
    }

    public void Run(){
        Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (o.Languages)
                       {
                           Console.WriteLine("Languages");
                       }
                   });
    }
}