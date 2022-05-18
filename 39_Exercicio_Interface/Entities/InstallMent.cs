using System;
using System.Globalization;

namespace _39_Exercicio_Interface.Entities
{
    class InstallMent
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public InstallMent(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
