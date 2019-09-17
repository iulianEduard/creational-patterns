using System;

namespace Creational.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFactoryMethod();

            DisplayAbtractFactory();

            DisplayBuidler();

            DisplayPrototype();

            Console.ReadKey();
        }

        static void DisplayFactoryMethod()
        {
            new FactoryMethod().Handle();
        }

        static void DisplayAbtractFactory()
        {
            new AbstractFactory().Run();
        }

        static void DisplayBuidler()
        {
            new BuilderPattern().Run();
        }

        static void DisplayPrototype()
        {
            new Prototype().Run();
        }
    }
}
