using System;
using YaTranslate.Core;

namespace YaTranslate
{
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
