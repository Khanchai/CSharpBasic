using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public static class Practice
    {
        public static void InputAnimalsAndPrint()
        {
            var listStr = new List<string>();

            for (; ; )
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
            Console.WriteLine("Output Animal's Name : " + String.Join(" ", listStr));
            Console.ReadKey();
        }

        public static void InputAnimalsAndPrintClass()
        {
            var lst = new List<Animal>();
            for (; ; )
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
            Console.WriteLine("Output Animal's Name : " + String.Join(" ", lst));
            Console.ReadKey();
        }

        public static void ExampleArray()
        {
            char[] vowels1 = new char[] { 'A', 'E', 'I', 'O', 'U' };
            char[] vowels2 = new char[5];

            int[] a = new int[1000];

            vowels2[0] = 'a';
            vowels2[1] = 'e';
            vowels2[2] = 'i';
            vowels2[3] = 'o';
            vowels2[4] = 'u';

            for (int i = 0; i < vowels1.Length; i++)
            {
                Console.WriteLine(vowels1[i]);
            }
            for (int i = 0; i < vowels2.Length; i++)
            {
                Console.WriteLine(vowels2[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine(a[123]);

            Console.ReadKey();
        }

        public static void ExampleArray2D()
        {
            var matrix1 = new int[3][];
            var matrix2 = new int[][]
                        {
                            new int[]{1,2,3}, 
                            new int[]{4,5,6}, 
                            new int[]{7,8,9}, 
                        };

            for (int i = 0; i < matrix1.Length; i++)
            {
                Console.WriteLine(matrix1[i].GetValue(i));
            }


            for (int i = 0; i < matrix2.Length; i++)
            {
                matrix2[i] = new int[3];
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    Console.WriteLine(matrix2[i][j] = i * 3 + j);
                }
            }

            char[] arr = { 'a', 'e', 'i', 'o', 'u' };

            int[,] rectangularMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[][] jaggedMatrix = { new int[] { 10, 20, 30 }, new int[] { 40, 50, 60 }, new int[] { 70, 80, 90 } };

            for (int x = 0; x < jaggedMatrix.Length; x++)
            {
                for (int y = 0; y < jaggedMatrix.Length; y++)
                {
                    Console.WriteLine(jaggedMatrix[x][y]);

                }
            }
            Console.WriteLine("\n");
            for (int x = 0; x < rectangularMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < rectangularMatrix.GetLength(1); y++)
                {
                    Console.WriteLine(rectangularMatrix[x, y]);

                }
            }

            Console.ReadKey();
        }

        public static int Factorial(int x)
        {
            if (x == 0) return 1;

            return x * Factorial(x - 1); ;
        }
    }

    public static class Practice2
    {
        public struct Point1 { public int X, Y; }
        public class Point2 { public int X, Y; }

        public struct Str { public string str1, str2;  }
        public static void StructVsClass()
        {
            Str[] s = new Str[100];
            var str = s[50].str1;

            Point1[] a = new Point1[1000];
            int x = a[500].X;
            Point2[] b = new Point2[1000];
            int y = b[500].X;

            Console.WriteLine(str);

            Console.WriteLine(x);
            Console.WriteLine(y);

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

    class Program
    {
        static void Main(string[] args)
        {
//                        int x = 8;
//                        Test.Reference(ref x);
//                        Console.WriteLine(x);
//
//                        var sb = new StringBuilder();
//                        Test.Str(sb);
//                        Console.WriteLine(sb);
//
//                        var x = "Ant";
//                        var y = "Cat";
//                        Test.Swap(ref x, ref y);
//                        Console.WriteLine(x);
//                        Console.WriteLine(y);
//
//                        string a, b;
//                        Test.Split("Stevie Ray Vaugh",out a, out b);
//                        Console.WriteLine(a);
//                        Console.WriteLine(b);
//
//                        Random ran = new Random();
//                        var x = ran.Next(1, 13);
//                        Test.ShowCard(x);
//                        for (int i = 1; i < 14; i++)
//                        {
//                            Test.ShowCard(i);
//                        }
//                        Test.ShowCard(-1);
//
//                        int i = 0;
//                        startLoop:
//                        if (i < 3)
//                        {
//                            Console.WriteLine(i);
//                            i++;
//                            goto startLoop;
//                        }

            for (int i = 0; i < 4; ++i)
            {
                if ((i % 2) == 0)
                    continue;
                Console.WriteLine(i);
            }

            var x = "";
            if(x==null) throw new ArgumentException();


            Console.ReadKey();
        }
    }

    class Test
    {
        public static void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1:
                    goto case 12;
                default:
                    Console.WriteLine(cardNumber);
                    break;
            }
        }

        public static void TellMeWhateCanDo(int age)
        {
            if (age >= 35)
            {
                Console.WriteLine("You can be President!!");
            }
            else if (age >= 21)
            {
                Console.WriteLine("You can be drink!!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You can be vote!!");
            }
            else
            {
                Console.WriteLine("You can be wait!!");
            }
        }

        public static void Split(string name, out string firstNames, out string lastName)
        {
            var i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        public static void Swap(ref string a, ref string b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static void Reference(ref int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        public static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        public static void Str(StringBuilder str)
        {
            str.Append("test");
            str = null;
        }
    }
}
