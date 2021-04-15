using System;
namespace Expendedora.Libreria.Exceptions
{
    public class CodigoExistenteException : Exception
    {
        public override string Message => "Ya existe el codigo ingresado";

    }
}
