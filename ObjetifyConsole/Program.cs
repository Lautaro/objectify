using Conzap;
using Objectify;
using System;
using System.IO;
using System.Linq;

namespace ObjetifyConsole
{
    class Program
    {
        static string NL = Environment.NewLine;
        static void Main(string[] args)
        {
            var text = GetFileContent();
            var props = new StringToProperties(text).properties.ToDictionary(p => p[0], p => p[1]);
            var membersOfClass = new ParseToObject<MyClass>(props).ToString();
            //   Console.WriteLine($"Hello World! {NL} {props.ToString()}");
            ConzapTools.KeyInput(membersOfClass);
            
        }

        private static string GetFileContent()
        {

            var filePath = $"{Directory.GetCurrentDirectory()}/TestData/TestData.txt";

            return File.ReadAllText(filePath);

        }
    }
}
