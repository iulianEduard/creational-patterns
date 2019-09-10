using System.Collections.Generic;

namespace Abstract.Factory
{
    public abstract class KingdomFactory
    {
        public abstract List<Mine> GenerateMines();

        public abstract List<Beast> GenerateBeasts();
    }
}
