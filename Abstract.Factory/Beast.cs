namespace Abstract.Factory
{
    public abstract class Beast
    {
        private readonly int _level;
        private readonly int _health;

        public Beast(int level, int baseHealth)
        {
            _level = level;
            _health = CalculateHealth(baseHealth);
        }

        public int GetHealth()
        {
            return _health;
        }

        private int CalculateHealth(int baseHealth)
        {
            return baseHealth * _level * Constants.BEAST_HEALTH_MULTIPLIER;
        }

        public override string ToString()
        {
            return $"Beast level: {_level}, health: {_health}";
        }
    }
}
