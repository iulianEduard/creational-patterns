namespace Builder
{
    public class BasicBenefits : BenefitsBuilder
    {
        public override void BuildAddBenefits()
        {
            Benefits = new Benefits("Internet Banking", "0.01% cash-back");
        }

        public override Benefits GetResult()
        {
            return Benefits;
        }
    }
}
