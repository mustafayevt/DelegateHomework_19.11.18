using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomework._19._11._18
{
    delegate void Func(string tmp);
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter string");
                var str = Console.ReadLine();
                Func funcDell = MyClass.Space;
                funcDell += MyClass.Reverse;
                Console.ForegroundColor = ConsoleColor.Red;
                Run.runFunc(funcDell, str);
                Console.ReadKey();
            }
        }
    }

    class MyClass
    {
        public static void Space(string str)
        {
            char[] newString = new char[(str.Length * 2) -1];
            for (int i = 0, h = 0; i < str.Length - 1; i++)
            {
                newString[h++] = str[i];
                newString[h++] = '_';
            }
            newString[newString.Length-1] = str[str.Length - 1];
            Console.WriteLine(newString);
        }

        public static void Reverse(string str)
        {
            char[] newString = new char[str.Length];
            for (int i = (str.Length - 1), h = 0; i != -1; i--)
            {
                newString[h++] = str[i];
            }
            Console.WriteLine(newString);
        }
    }

    class Run
    {
        public static void runFunc(Func func, string str)
        {
            func(str);
        }
    }


}
