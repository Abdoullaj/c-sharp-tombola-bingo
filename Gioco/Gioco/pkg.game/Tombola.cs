using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Gioco
{
    class Tombola : GameFactory
    {

        public Tombola()
        {
            Console.Write("Tombola creata");
        }
        
        public override void turnoGioco()
        {
            Console.Write("Turno Tombola");
        }


    }
}
