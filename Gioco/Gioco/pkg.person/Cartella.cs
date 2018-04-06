using System;
using System.Collections.Generic;
using System.Text;

namespace Gioco
{
    class Cartella
    {
        private int [,] cartella;
        private double costo;
        private int rows, columns;
        private EstrazioneNumeroRandom est = new EstrazioneNumeroRandom();


        public Cartella(char type)
        {
            if (type == 't')
            {
                rows = 3;
                columns = 5;
                cartella = new int[rows,columns];
                
                costo = 0.5;
            }
            else
            {
                rows = 3;
                columns = 10;
                cartella = new int[rows,columns];
                costo = 1;
            
            }
            RiempiCartella();
        }

        private void RiempiCartella()
        {
            Console.WriteLine(rows + ":" + columns);
            for(int i=0; i < rows;i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int number = est.Estrazione();
                    cartella[i, j] = number;
                    Console.WriteLine(cartella[i, j]);
                    Console.ReadKey();
                }
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
