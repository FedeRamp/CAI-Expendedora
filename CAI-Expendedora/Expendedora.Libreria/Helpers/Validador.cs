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
                if (resultado == "") Console.WriteLine("No se ingreso nada");
            } while (resultado == "");

            return resultado;
        }

        public static int pedirInt(string mensaje)
        {
            string entrada = "";
            int resultado;
            do
            {
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out resultado))
                {
                    Console.WriteLine("No se ingreso un numero");
                    entrada = "";
                }
            } while (entrada == "");
            return resultado;
        }

        public static double pedirDouble(string mensaje)
        {
            string entrada = "";
            double resultado;
            do
            {
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine();
                if (!double.TryParse(entrada, out resultado))
                {
                    Console.WriteLine("No se ingreso un numero");
                    entrada = "";
                }
            } while (entrada == "");
            return resultado;
        }
    }
}
