using System;
using System.Collections.Generic;
using System.Text;

namespace MacroDriver
{
    class TBConsole
    {
        public static MacroDriver Form { get; set; }

        public static void WriteLine(string msg)
        {
            Form.Console.Text += msg + Environment.NewLine;
        }
    }
}
