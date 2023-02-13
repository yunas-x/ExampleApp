using System;
using System.Collections.Generic;
using System.Text;

namespace Example_App
{
    internal class ConsolePrinter: IPrint
    {
        public void Print(IPrintable printable)
        {
            Console.WriteLine(printable.GetInfo());
        }
    }
}
