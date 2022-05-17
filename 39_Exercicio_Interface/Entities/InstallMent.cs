using System;

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
    }
}
