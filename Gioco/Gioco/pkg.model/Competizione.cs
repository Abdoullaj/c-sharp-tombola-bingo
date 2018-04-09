using System;
using System.Collections.Generic;
using System.Text;

namespace Gioco
{
    class Competizione
    {
       char type;
       public Competizione()
        {
            Console.WriteLine("tipo gioco");
            type = Convert.ToChar(Console.ReadLine());
            if (type != 'b' && type != 't')
            {
                Console.WriteLine("error, re-insert value");
            } else if ( type == 't' )
            {
                GameFactory g = new Tombola();
                g.TurnoGioco();
            } else
            {
                GameFactory g = new Bingo();
            }

            Console.ReadKey();
            

        }
    }
}
