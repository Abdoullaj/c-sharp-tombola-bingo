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
                    Console.Write(cartella[i, j]+" ");    
                }
                Console.WriteLine();

            }
        }

        public double GetCosto()
        {
            return costo;
        }
        
        public int [,] GetMatrice()
        {
            return cartella;
        }

        public void CheckNumero(int n)
        {
            for (int riga = 0; riga < cartella.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < cartella.GetLength(1); colonna++)
                {
                    if (cartella[riga, colonna] == n)
                    {
                        Console.WriteLine($"Casella presa dal numero {n}");
                        cartella[riga, colonna] = 0;
                        break;
                    }
                }
            }
            Console.WriteLine("Controllo di questa estrazione finito");
        }

        public int CountZero (int riga)
        {
            int counter = 0;
            for (int i = 0; i < cartella.GetLength(0); i++)
            {
                if (i == riga)
                {
                    for (int j = 0; j < cartella.GetLength(1); j++)
                    {
                        if (cartella[i, j] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }

        public Boolean CartellaFinita()
        {
            for (int riga = 0; riga < cartella.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < cartella.GetLength(1); colonna++)
                {
                    if (cartella[riga, colonna] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void PrintSchema()
        {
            for (int i = 0; i < cartella.GetLength(0); i++)
            {
                for (int j = 0; j < cartella.GetLength(1); j++)
                {
                    Console.Write(cartella[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
