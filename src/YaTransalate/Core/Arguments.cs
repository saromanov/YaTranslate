using System;
using CommandLine;

namespace YaTranslate.Core {
     private class Options
     {
         [Option('l', "languages", Required = false, HelpText = "Showing if list supported languages")]
         public bool Languages { get; set; }
     }

     private class ArgumentParser {
         private string args;
         public ArgumentParser([]string args) {
             this.args = args;
         }

     }

}