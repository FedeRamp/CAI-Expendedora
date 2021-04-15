using System;
using Expendedora.Libreria;
using Expendedora.Libreria.Clases;
using Expendedora.Libreria.Helpers;

namespace CAIExpendedora
{
    class MainClass
    {
        private static ExpendedoraMaq expendedora;

        public static void Main(string[] args)
        {
            expendedora = new ExpendedoraMaq("Expendelux", 500, 500);

            string encender = "";
            while (encender == "")
            {
                Console.Clear();
                if(expendedora.Encendida)
                {
                    
                    
                }

                else
                {
                    encender = Validador.pedirString("1. Encender Maquina");
                    if (encender == "1")
                    {
                        expendedora.Encender();
                    }
                    else
                    {
                        encender = "";
                    }

                }
                
            }

        }



        public static void MenuPrincipal()
        {
            string[] opciones = {"1. Ver productos disponibles",
                                 "2. Agregar nuevo producto",
                                 "3. Comprar producto",
                                 "4. Mostrar balance",
                                 "5. Mostrar stock" };
            Menu menu = new Menu("Elija una opcion:", opciones);
            switch (menu.elegir())
            {
                case 1:
                    MostrarProductos();
                    break;
                case 2:
                    AgregarProducto();
                    break;
                case 3:
                    ComprarProducto();
                    break;
                case 4:
                    MostrarBalance();
                    break;
                case 5:
                    MostrarStock();
                    break;
                default:
                    break;
            }
        }

        private static void MostrarStock()
        {
            Console.WriteLine(expendedora.VerStock);
        }

        private static void MostrarBalance()
        {
            Console.WriteLine($"La maquina tiene {expendedora.Dinero} y {expendedora.Productos} latas");
        }

        private static void ComprarProducto()
        {
            throw new NotImplementedException();
        }

        private static void AgregarProducto()
        {
            string codigo = Validador.pedirString("Ingresar codigo");
            string nombre = Validador.pedirString("Ingresar nombre");
            string sabor = Validador.pedirString("Ingresar sabor");
            double precio = Validador.pedirDouble("Ingresar precio");
            int volumen = Validador.pedirInt("Ingresar Volumen");
            int cantidad = Validador.pedirInt("Ingresar Cantidad");
            Lata lata = new Lata(codigo,nombre,sabor,precio,volumen,cantidad);
            expendedora.AddLata(lata);
        }

        private static void MostrarProductos()
        {
            Console.WriteLine(expendedora.ListLatas);
        }
    }


 
}
