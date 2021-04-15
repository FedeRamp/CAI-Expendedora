   using System;
namespace Expendedora.Libreria.Exceptions
{
    public class DineroInsuficienteException : Exception
    {
        public override string Message => "No se ingreso dinero suficiente";
    }
}
