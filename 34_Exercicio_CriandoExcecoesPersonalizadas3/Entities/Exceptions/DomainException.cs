using System;

namespace _34_Exercicio_CriandoExcecoesPersonalizadas3.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
