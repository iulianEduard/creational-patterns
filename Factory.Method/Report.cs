namespace Factory.Method
{
    /// <summary>
    /// Concrete Creator class
    /// </summary>
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionsPage());
        }
    }
}
