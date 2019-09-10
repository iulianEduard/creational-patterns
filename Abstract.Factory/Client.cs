using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Factory
{
    public class Client
    {
        private readonly List<Beast> _beasts;
        private readonly List<Mine> _mines;

        public Client(KingdomFactory kingdomFactory)
        {
            _beasts = kingdomFactory.GenerateBeasts();
            _mines = kingdomFactory.GenerateMines();
        }

        public void Explore()
        {
            foreach (var beast in _beasts)
            {
                Console.WriteLine($"Beast type: {beast.GetType().Name}");
                Console.WriteLine($"{beast.ToString()}");
            }
        }
    }
}
