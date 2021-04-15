using System;
namespace Expendedora.Libreria.Helpers
{
    public class Validador
    {

        public static string pedirString(string mensaje)
        {
            string resultado = "";
            do
            {
                Console.WriteLine(mensaje);
                resultado = Console.ReadLine();
                if (resultado == "") Console.WriteLine("Algo, no vacío");
            } while (resultado == "");

            return resultado;
        }

        public static int pedirInt(string mensaje)
        {
            string entrada = "";
            int resultado;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out resultado))
                {
                    Console.WriteLine("No se ingreso un numero");
                    entrada = "";
                }
            } while (entrada == "");
            return resultado;
        }
    }
}
