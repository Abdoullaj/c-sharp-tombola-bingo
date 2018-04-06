using System;
using System.Collections.Generic;
using System.Text;

namespace Gioco
{
    class Bingo : GameFactory
    {
        public Bingo()
        {
            Console.Write("Bingo creato");
        }

        public override void turnoGioco() {
            Console.Write("Turno bingo");
        }
    }
}
