namespace Builder
{
    public abstract class BenefitsBuilder
    {
        protected Benefits Benefits;

        public abstract void BuildAddBenefits();

        public abstract Benefits GetResult();
    }
}
