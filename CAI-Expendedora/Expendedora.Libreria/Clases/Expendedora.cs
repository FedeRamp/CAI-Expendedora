using System;
using System.Collections.Generic;
using System.Linq;
using Expendedora.Libreria.Clases;
using Expendedora.Libreria.Exceptions;

namespace Expendedora.Libreria
{
    public class Expendedora
    {
        List<Lata> latas = new List<Lata>();
        string proveedor;
        int capacidadMaxima;
        int stock;
        double dinero;
        bool encendida;


        public Expendedora(string proveedor, int capacidadMaxima, double dinero)
        {
            this.proveedor = proveedor;
            this.capacidadMaxima = capacidadMaxima;
            this.dinero = dinero;
            encendida = false;
        }


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
            if (stock < capacidadMaxima)
            {
                if (latas.SingleOrDefault(lat => lata.Codigo == lat.Codigo) == null)
                {
                    latas.Add(lata);
                    stock += lata.Cantidad;
                } else
                {
                    throw new CodigoExistenteException();
                }
            } else
            {
                throw new CapacidadExcedidaException();
            }
        }
    }
}
