using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _12_Exercicio
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorToralEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $"
                + ValorToralEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
