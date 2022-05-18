using System;
using System.Collections.Generic;

namespace _39_Exercicio_Interface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<InstallMent> InstallMents { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            InstallMents = new List<InstallMent>();
        }

        public void AddInstallMent(InstallMent installMent)
        {
            InstallMents.Add(installMent);
        }
    }
}
