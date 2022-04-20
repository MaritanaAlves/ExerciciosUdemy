using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Exercicio
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

    }
}
