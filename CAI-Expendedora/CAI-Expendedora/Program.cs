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
                if(expendedora.Encendida)
                {
                    MenuPrincipal();
                    encender = "";
                }

                else
                {
                    encender = Validador.pedirString("1. Encender Maquina");
                    if (encender == "1")
                    {
                        expendedora.Encender();
                        encender = "";
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
            string[] opciones = {" Ver productos disponibles",
                                 " Agregar nuevo producto",
                                 " Comprar producto",
                                 " Mostrar balance",
                                 " Mostrar stock" };
            Menu menu = new Menu("Elija una opcion:", opciones);
            int opcion = menu.elegir();
            switch (opcion)
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
            MostrarProductos();
            string codigo = Validador.pedirString("Elige la que quieras");
            double pago = Validador.pedirDouble("Ingrese su dinero");
            double vuelto = 0;
            try
            {
                Lata lata = expendedora.VenderLata(codigo, pago, out vuelto);
                Console.WriteLine($"Vendido! {lata.Print}");
                if (vuelto != 0) Console.WriteLine($"Su vuelto: {vuelto}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AgregarProducto()
        {
            string codigo = Validador.pedirString("Ingresar codigo");
            string nombre = Validador.pedirString("Ingresar nombre");
            string sabor = Validador.pedirString("Ingresar sabor");
            double precio = Validador.pedirDouble("Ingresar precio");
            int volumen = Validador.pedirInt("Ingresar Volumen (en ml)");
            int cantidad = Validador.pedirInt("Ingresar Cantidad");
            try
            {
                Lata lata = new Lata(codigo, nombre, sabor, precio, volumen, cantidad);
                expendedora.AddLata(lata);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void MostrarProductos()
        {
            Console.WriteLine(expendedora.ListLatas);
        }
    }


 
}
