using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Gioco
{
    abstract class GameFactory
    {
        private EstrazioneNumeroRandom est = new EstrazioneNumeroRandom();
        string state;
        private ArrayList nEstratti, giocatori;

        public GameFactory()
        {
            nEstratti = new ArrayList();
            giocatori = new ArrayList();
        }

        public void estraiNumeri()
        {
           
        }

        abstract public void turnoGioco();

        public void AggiungiGiocatori(Persona p)
        {
            giocatori.Add(p);
        }

    }
}
