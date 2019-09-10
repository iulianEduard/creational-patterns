namespace Abstract.Factory
{
    public class Vampire : Beast
    {
        private readonly int _level;

        public Vampire(int level) : base(level, Constants.BEAST_BASE_VAMPIRE_HEALTH)
        {
            _level = level;
        }

        public void DisplayHealth()
        {
            System.Console.WriteLine($"Vampire level: {_level} has {GetHealth()} health");
        }
    }

    public class Werewoulf : Beast
    {
        private readonly int _level;

        public Werewoulf(int level) : base(level, Constants.BEAST_BASE_WEREWOULF_HEALTH)
        {
            _level = level;
        }

        public void DisplayHealth()
        {
            System.Console.WriteLine($"Werewoulf level: {_level} has {GetHealth()} health");
        }
    }
}
