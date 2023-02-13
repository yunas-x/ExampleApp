using System;
using System.IO;
using System.Text;

namespace Example_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass.SetPrint(new ConsolePrinter());
            var example = new ExampleClass("old");
            example.Print();
            ExampleClass newExample = new NewExampleClass("new", 1);
            newExample.Print();
            var returnable = example.ReturnFirstChar();
            Console.WriteLine(returnable());
            example.ExampleString = "elder";
            Console.WriteLine(returnable());
            var output = new StringBuilder();
            var stringWriter = new StringWriter(output);
            var originalOutput = Console.Out;
            Console.SetOut(stringWriter);
            Console.WriteLine("writer");
            Console.SetOut(originalOutput);
            Console.WriteLine(output.ToString());


        }
    }
}
