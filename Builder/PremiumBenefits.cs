namespace Builder
{
    public class PremiumBenefits : BenefitsBuilder
    {
        public override void BuildAddBenefits()
        {
            Benefits = new Benefits("VISA Gold Card", "0.05% cash-back");
        }

        public override Benefits GetResult()
        {
            return Benefits;
        }
    }
}
