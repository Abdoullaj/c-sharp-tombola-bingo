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
            if (type == 't')
            {
                cartella = new int[3,5];
                costo = 0.5;
            }
            else
            {

                cartella = new int[3, 10];
                costo = 1;
            
            }
        }

        public double GetCosto()
        {
            return costo;
        }

        public Cartella GetCartella()
        {
            return this;
        }
    }
}
