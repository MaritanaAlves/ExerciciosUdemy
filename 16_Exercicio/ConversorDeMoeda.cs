using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Exercicio
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarEmReal(double comprar, double cotacaoDoDolar)
        {
            double Total = comprar * cotacaoDoDolar;
            return Total + Total * Iof / 100.00;
        }
    }
}
