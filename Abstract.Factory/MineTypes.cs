using System;

namespace Abstract.Factory
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class IronMine : Mine
    {
        private readonly int _level;

        public IronMine(int level) : base(level, Constants.IRON_MINE_RSS)
        {
            _level = level;
        }

        public void DisplayMine()
        {
            Console.WriteLine($"Mine level: {_level} has {GetAvailableRss()}");
        }
    }

    public class SilverMine : Mine
    {
        private readonly int _level;

        public SilverMine(int level) : base(level, Constants.SILVER_MINE_RSS)
        {
            _level = level;
        }

        public void DisplayMine()
        {
            Console.WriteLine($"Mine level: {_level} has {GetAvailableRss()}");
        }
    }
}
