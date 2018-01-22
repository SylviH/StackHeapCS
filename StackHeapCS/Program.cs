using System;
namespace StackHeapCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get code from https://github.com/devcronberg/StackHeapCS

            Person p1 = new Person();
            p1.name = "a";
            p1.age = 10;

            Person p2 = new Person();
            p2.name = "b";
            p2.age = 20;

            Console.WriteLine("Initialize p1 and p2");
            Console.WriteLine("p1 = name " + p1.name + " age " + p1.age);
            Console.WriteLine("p2 = name " + p2.name + " age " + p2.age);
            Console.WriteLine();

            p1 = p2;
            Console.WriteLine("p1 = p2");
            Console.WriteLine("p1 = name " + p1.name + " age " + p1.age);
            Console.WriteLine("p2 = name " + p2.name + " age " + p2.age);
            Console.WriteLine();

            p1.age = 30;
            Console.WriteLine("p1.age = 30");
            Console.WriteLine("p1 = name " + p1.name + " age " + p1.age);
            Console.WriteLine("p2 = name " + p2.name + " age " + p2.age);

            // - Make sure Person is a struct, 
            //   run program, view and understand output
            // - Make sure Person is a class, 
            //   run program, view and understand output
            // - Make sure you understand the difference

            if (System.Diagnostics.Debugger.IsAttached)
                Console.ReadKey();
        }
    }
    struct Person // or class Person
    { 
        public string name;
        public int age;
    }
}