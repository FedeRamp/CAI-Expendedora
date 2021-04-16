using System;
using Expendedora.Libreria;
using Expendedora.Libreria.Clases;

namespace Expendedora.Libreria.Helpers
{
    public class Test
    {
        private static ExpendedoraMaq expendedora;

        public static ExpendedoraMaq MaquinaPrueba()
        {
            expendedora = new ExpendedoraMaq("Test", 250, 100);
            Lata lata1 = new Lata("01", "Fanta", "Naranja", 100, 1000, 10);
            Lata lata2 = new Lata("02", "CocaCola", "Cola", 150, 1000, 20);
            Lata lata3 = new Lata("03", "Mirinda", "Naranja", 75, 1000, 5);
            Lata lata4 = new Lata("04", "Manaos", "Pomelo Blanco", 50, 1250, 30);
            Lata lata5 = new Lata("05", "Nestle", "Agua", 40, 450, 15);

            expendedora.AddLata(lata1);
            expendedora.AddLata(lata2);
            expendedora.AddLata(lata3);
            expendedora.AddLata(lata4);
            expendedora.AddLata(lata5);

            return expendedora;
        }
    }
}
