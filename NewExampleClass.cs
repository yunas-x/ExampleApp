using System;
using System.Collections.Generic;
using System.Text;

namespace Example_App
{
    public class NewExampleClass: ExampleClass
    {

        public int Number { get; private set; }

        public NewExampleClass(string str, int number) : base(str)
        {
            Number = number;
        }

        public NewExampleClass(string str, IPrint print, int number) : base(str, print)
        {
            Number = number;
        }

        public override string ToString()
        {
            return this.ExampleString + this.Number;
        }

    }
}
