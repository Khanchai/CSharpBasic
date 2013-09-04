using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public static class Practice
    {
        public static void InputAnimalsAndPrint()
        {
            var str = new StringBuilder();
            while (true)
            {
                Console.WriteLine("Input Animal's Name (if you want exist, input exit)");
                Console.Write("> ");
                var name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                str.Append(name + " ");

            }
            Console.WriteLine("Output Animal's Name : " + str.ToString().Trim());
            Console.ReadKey();
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Practice.InputAnimalsAndPrint();
        }
    }

    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name += name;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
