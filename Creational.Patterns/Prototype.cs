using Prototype;

namespace Creational.Patterns
{
    public class Prototype
    {
        public void Run()
        {
            var android1 = new Android(300, 1, 25);
            android1.DisplayInternalData();

            Android android2 = (Android)android1.Clone();
            android2.DisplayInternalData();

            android2.ChangeIQ(200);

            android1.DisplayInternalData();
            android2.DisplayInternalData();
        }
    }
}
