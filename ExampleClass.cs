using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Example_App
{
    public class ExampleClass: IComparable<ExampleClass>, IEquatable<ExampleClass>, IPrintable
    {
        private string exampleString;
        private static Exception e;

        static private IPrint printer;

        public string ExampleString
        {
            get
            {
                return exampleString;
            }
            set
            {
                if (value == null)
                {
                    exampleString = String.Empty;
                }
                else
                {
                    exampleString = value;
                }
            }
        }

        public static void SetPrint(IPrint print)
        {
            ExampleClass.printer = print;
        }

        public void Print()
        {
            printer?.Print(this);
        }

        public ExampleClass(string str)
        {
            ExampleString = str;
        }


        public ExampleClass(string str, IPrint print)
        {
            ExampleString = str;
            printer = print;
        }

        public Func<char> ReturnFirstChar()
        {
            return () => { return exampleString[0]; };
        }

        public int CompareTo([AllowNull] ExampleClass example)
        {
            if (example == null || example.ExampleString == null)
            {
                throw e;
            }
            else
            {
                return example.ExampleString.CompareTo(example.ExampleString);
            }
        }

        public override string ToString()
        {
            return ExampleString;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals([AllowNull] ExampleClass example)
        {
            if (example == null || example.ExampleString == null)
            {
                throw e;
            }
            else
            {
                return example.ExampleString.Equals(example.ExampleString);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string GetInfo()
        {
            return ToString();
        }
    }
}
