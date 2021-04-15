using System;
namespace Expendedora.Libreria.Clases
{
    public class Lata
    {
        string codigo;
        string nombre;
        string sabor;
        double precio;
        double volumen;
        double precioPorLitro;
        int cantidad;

        public Lata(string codigo, string nombre, string sabor, double precio, double volumen, int cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.sabor = sabor;
            this.precio = precio;
            this.volumen = volumen;
            this.cantidad = cantidad;
            this.precioPorLitro = (1000 / volumen) * precio;
        }

        public string Print
        {
            get
            {
                return $"{this.codigo}) {this.nombre} [{this.cantidad}] ${this.precio}";
            }
        }


        public string Descripcion
        {
            get
            {
                return $"{this.nombre} - {this.sabor} $ {this.precio} \n\t $/L {this.precioPorLitro} - stock:[{this.cantidad}]";
            }
        }

        public void Vender()
        {
            this.cantidad--;
        }

        public string Codigo { get => codigo; }
        public string Nombre { get => nombre; }
        public double Precio { get => precio; }
        public int Cantidad { get => cantidad; }
    }
}
