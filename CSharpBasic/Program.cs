using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public static class Practice
    {
        public static void InputAnimalsAndPrint()
        {
            var listStr = new List<string>();

            for (;;)
            {
                Console.WriteLine("Input Animal's Name (if you want exist, input exit)");
                Console.Write("> ");
                var name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                listStr.Add(name);
            }
            Console.WriteLine("Output Animal's Name : " +string.Join(" ",listStr));
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<Animal>();
            for(;;)
            {
                Console.WriteLine("Input Animal's Name (if you want exist, input exit)");
                Console.Write("> ");
                var a = Console.ReadLine();
                
                if (a != "exit")
                {
                    var animal = new Animal(a);
                    lst.Add(animal);
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("Output Animal's Name : " + string.Join(" ", lst));
            Console.ReadKey();
        }
    }

    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
