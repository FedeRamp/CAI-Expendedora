using System;
namespace Expendedora.Libreria.Exceptions
{
    public class SinStockException : Exception
    {
        public override string Message => "No hay stock del producto pedido";
    }
}
