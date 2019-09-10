using Builder;
using System;

namespace Creational.Patterns
{
    public class BuilderPattern
    {
        public void Run()
        {
            BenefitsDirector benefitsDirector = new BenefitsDirector();

            BenefitsBuilder basicBenefitsBuilder = new BasicBenefits();
            benefitsDirector.Construct(basicBenefitsBuilder);
            Benefits basicBenefits = basicBenefitsBuilder.GetResult();
            Console.WriteLine($"Type {basicBenefitsBuilder.GetType().Name}: {basicBenefits.Show()}");

            BenefitsBuilder premiumBenefitsBuilder = new PremiumBenefits();
            benefitsDirector.Construct(premiumBenefitsBuilder);
            Benefits premiumBenefits = premiumBenefitsBuilder.GetResult();
            Console.WriteLine($"Type {premiumBenefitsBuilder.GetType().Name}: {premiumBenefits.Show()}");
        }
    }
}
