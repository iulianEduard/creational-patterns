using Factory.Method;

namespace Creational.Patterns
{
    public class FactoryMethod
    {
        public void Handle()
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (var doc in documents)
            {
                System.Console.WriteLine($"Document type of: {doc.GetType().Name}");
                System.Console.WriteLine("Has the following pages:");

                for(int i = 0; i < doc.Pages.Count; i++)
                {
                    System.Console.WriteLine($"Page nr: {i} is {doc.Pages[i].GetType().Name}");
                }
            }
        }
    }
}
