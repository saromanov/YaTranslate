﻿using System;

namespace YaTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ProgramCore core = new ProgramCore())
            {
                core.Execute();
            }
        }
    }
}
