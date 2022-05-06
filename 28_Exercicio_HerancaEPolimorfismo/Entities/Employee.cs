namespace _28_Exercicio_HerancaEPolimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueperHour{ get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valueperHour)
        {
            Name = name;
            Hours = hours;
            ValueperHour = valueperHour;
        }

        public virtual double Payment()
        {
            return Hours * ValueperHour;
        }
    }
}
