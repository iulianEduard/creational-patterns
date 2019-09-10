using System;
using System.Collections.Generic;

namespace Abstract.Factory
{
    public class RomaniaFactory : KingdomFactory
    {
        public override List<Beast> GenerateBeasts()
        {
            return CreateBeasts();
        }

        public override List<Mine> GenerateMines()
        {
            return CreateMines();
        }

        private List<Beast> CreateBeasts()
        {
            int minNumberOfBeasts = 100;
            int maxNumberOfBeasts = 1000;

            int generatedNumberOfBeasts = GenerateNumberOfBeasts(minNumberOfBeasts, maxNumberOfBeasts);
            var beastsPerLevelGenerated = new int[Constants.MAX_NUMBER_OF_BEASTS_PER_LEVEL];

            var generatedBeasts = new List<Beast>();

            for (int i = 1; i <= generatedNumberOfBeasts; i++)
            {
                var beast = CreateBeast(out int generatedBeastLevel);
                generatedBeasts.Add(beast);
            }

            return generatedBeasts;
        }

        private Beast CreateBeast(out int level)
        {
            var random = new Random();
            int beastType = random.Next(1, 3);
            level = random.Next(1, 8);

            if (beastType == 1)
                return new Vampire(level);

            return new Werewoulf(level);
        }

        private int GenerateNumberOfBeasts(int min, int max)
        {
            var random = new Random();
            var generatedNumber = random.Next(min, max + 1);

            Console.WriteLine($"Number of beasts to be generated: {generatedNumber}");

            return generatedNumber;
        }

        private List<Mine> CreateMines()
        {
            int minNumberOfMines = 100;
            int maxNumberOfMines = 1000;

            int generatedNumberOfMines = GenerateNumberOfMines(minNumberOfMines, maxNumberOfMines);
            var minesPerLevelGenerated = new int[Constants.MAX_NUMBER_OF_BEASTS_PER_LEVEL];

            var generatedMines = new List<Mine>();

            for (int i = 1; i <= generatedNumberOfMines; i++)
            {
                var beast = CreateMine(out int generatedBeastLevel);
                generatedMines.Add(beast);
            }

            return generatedMines;
        }

        private Mine CreateMine(out int level)
        {
            var random = new Random();
            int beastType = random.Next(1, 3);
            level = random.Next(1, 8);

            if (beastType == 1)
                return new SilverMine(level);

            return new IronMine(level);
        }

        private int GenerateNumberOfMines(int min, int max)
        {
            var random = new Random();
            var generatedNumber = random.Next(min, max + 1);

            Console.WriteLine($"Number of mines to be generated: {generatedNumber}");

            return generatedNumber;
        }
    }
}
