namespace Abstract.Factory
{
    /// <summary>
    /// Abstract product
    /// </summary>
    public abstract class Mine
    {
        private readonly int _level;
        private readonly int _availableRss;

        public Mine(int level, int baseRss)
        {
            _level = level;
            _availableRss = CalculateAvailableRss(baseRss);
        }

        public int GetAvailableRss()
        {
            return _availableRss;
        }

        private int CalculateAvailableRss(int baseRss)
        {
            return baseRss * Constants.MINE_MULTIPLIER * _level;
        }

        public override string ToString()
        {
            return $"Mine level: {_level}, available rss: {_availableRss}";
        }
    }
}
