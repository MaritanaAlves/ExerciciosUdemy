using System;
using System.Collections.Generic;
using System.Text;

namespace _35_Exercicio_Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
