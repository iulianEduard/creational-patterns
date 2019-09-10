using System.Collections.Generic;

namespace Factory.Method
{
    /// <summary>
    /// Creator abstract class
    /// </summary>
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages { get => _pages; set => _pages = value; }

        public abstract void CreatePages();
    }
}
