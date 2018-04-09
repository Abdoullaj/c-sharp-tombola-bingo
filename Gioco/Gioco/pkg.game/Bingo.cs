using System;
using System.Collections.Generic;
using System.Text;

namespace Gioco
{
    class Bingo : GameFactory
    {
        public Bingo() : base()
        {
            Console.Write("Bingo creato");
        }

        public override void TurnoGioco() {
            Console.Write("Turno bingo");
        }
    }
}
