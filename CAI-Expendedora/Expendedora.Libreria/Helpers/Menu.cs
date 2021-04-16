using System;
namespace Expendedora.Libreria.Helpers
{
    public class Menu
    {

        string[] opciones;
        private string titulo;

        public Menu(string titulo, string[] opciones)
        {  //Constructor
            this.titulo = titulo;
            this.opciones = opciones;
        }

        public string print()
        {
            string resultado = "";
            resultado += titulo + "\n";
            try
            {
                if (!isEmpty())
                {
                    for (int i = 0; i < opciones.Length; i++)
                    {
                        resultado += ("\t" + (i + 1) + ". " + opciones[i] + "\n");
                    }
                }
            }
            catch (Exception ave)
            {
                Console.WriteLine(ave.Message);
            }
            return resultado;
        }

        public int elegir()
        {
            
            try
            {
                int opcionElegida = Validador.pedirInt(print());
                string opcion = opciones[opcionElegida - 1]; //Esto me va a tirar el error
                Console.Clear();
                return opcionElegida;
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine("No existe esa opcion");
            }

            return -1;
        }

        public bool isEmpty()
        {
            if (this.opciones.Length == 0)
            {
                throw new Exception("No hay opciones para mostrar");
            }
            return !(this.opciones.Length > 0);
        }
    }

}
