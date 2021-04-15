using System;
using System.Collections.Generic;
using System.Linq;
using Expendedora.Libreria.Clases;
using Expendedora.Libreria.Exceptions;

namespace Expendedora.Libreria
{
    public class ExpendedoraMaq
    {
        List<Lata> latas = new List<Lata>();
        string proveedor;
        int capacidadMaxima;
        int productos;
        double dinero;
        bool encendida;


        public ExpendedoraMaq(string proveedor, int capacidadMaxima, double dinero)
        {
            this.proveedor = proveedor;
            this.capacidadMaxima = capacidadMaxima;
            this.dinero = dinero;
            encendida = false;
        }

        public int Productos { get => productos; }
        public string Dinero { get => "$" + dinero; }
        public bool Encendida { get => encendida; }


        public string ListLatas
        {
            get
            {
                string resultado = "";
                foreach(Lata lata in latas)
                {
                    resultado += lata.Print + "\n";
                }
                return resultado;
            }
        }

        public string VerStock
        {
            get
            {
                string resultado = "";
                foreach(Lata lata in latas)
                {
                    resultado += lata.Descripcion + "\n";
                }
                return resultado;
            }
        }


        public void VenderLata(string codigo, double pago, out double vuelto)
        {
            Lata lata = latas.SingleOrDefault(l => l.Codigo == codigo);
            if (lata != null)
            {
                if (lata.Cantidad > 0)
                {
                    if (pago >= lata.Precio)
                    {
                        dinero += pago;
                        vuelto = pago - lata.Precio;
                        lata.Vender();
                    }
                    else
                    {
                        throw new DineroInsuficienteException();
                    }
                }
                else
                {
                    throw new SinStockException();
                }
            } else
            {
                throw new Exception("Codigo ingresado invalido");
            }
        }

        public void AddLata(Lata lata)
        {
            if (productos < capacidadMaxima)
            {
                if (latas.SingleOrDefault(lat => lata.Codigo == lat.Codigo) == null)
                {
                    latas.Add(lata);
                    productos += lata.Cantidad;
                } else
                {
                    throw new CodigoExistenteException();
                }
            } else
            {
                throw new CapacidadExcedidaException();
            }
        }

        public void Encender()
        {
            encendida = true;
        }
        public void Apagar()
        {
            encendida = false;
        }
         
    }
}
