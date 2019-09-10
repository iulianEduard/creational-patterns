using Abstract.Factory;
using System;

namespace Creational.Patterns
{
    public class AbstractFactory
    {
        public void Run()
        {
            KingdomFactory romania = new RomaniaFactory();
            var romaniaKingdom = new Client(romania);
            romaniaKingdom.Explore();

            Console.ReadKey();
        }
    }
}
