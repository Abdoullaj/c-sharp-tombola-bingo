using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Gioco
{
    abstract class EstrazioneNumeroRandom
    {
        private ArrayList nEstratti;
        private Random rnd= new Random();

        public EstrazioneNumeroRandom()
        {
            nEstratti = new ArrayList();
        }

        public int Estrazione()
        {
            int estratto = rnd.Next(1,100);
            if (nEstratti.Contains(estratto))
            {
                return Estrazione();
            }
            else
            {
                nEstratti.Add(estratto);
                return estratto;
            }
        }
    }
}
