namespace Factory.Method
{
    /// <summary>
    /// Concrete creator class
    /// </summary>
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new SkillsPage());
        }
    }
}
