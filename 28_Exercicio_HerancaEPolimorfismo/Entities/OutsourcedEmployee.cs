namespace _28_Exercicio_HerancaEPolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hours, double valueperHour, double additionalCharge) : base(name, hours, valueperHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
