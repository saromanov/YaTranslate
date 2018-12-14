using System;
using CommandLine;

namespace YaTranslate.Core {
     private class Options
     {
         [Option('l', "languages", Required = false, HelpText = "Showing if list supported languages")]
         public bool Languages { get; set; }
     }

     private class ArgumentParser {
         ArgumentParser(args[]string) {
             
         }

     }

}