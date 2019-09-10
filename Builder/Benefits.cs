using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public class Benefits
    {
        private readonly List<string> _benefits = new List<string>();

        public Benefits(params string[] benefits)
        {
            _benefits.AddRange(benefits.ToList());
        }

        public string Show()
        {
            var benefits = string.Join(',', _benefits);

            return benefits;
        }

        public Benefits GetResult()
        {
            return this;
        }
    }
}
