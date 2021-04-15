using System;
namespace Expendedora.Libreria.Exceptions
{
    public class CapacidadExcedidaException : Exception
    {
        public override string Message => "Capacidad maxima de la expendedora alcanzada";
    }
}
