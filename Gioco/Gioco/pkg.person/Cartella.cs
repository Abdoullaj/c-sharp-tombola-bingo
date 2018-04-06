using System;
using System.Collections.Generic;
using System.Text;

namespace Gioco
{
    class Cartella
    {
        private int [,] cartella;
        private double costo;

        public Cartella(char type)
        {
            if (type == 'b')
            {
                cartella = new int[3,5];
                costo = 0.5;
            }
        }
    }
}
