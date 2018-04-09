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
        private List<int> nEstratti;
        private List<Persona> giocatori;
        private string[] stepStates;

        public GameFactory()
        {
            nEstratti = new List<int>();
            giocatori = new List<Persona>();
        }

        public List<Persona> GetPersone()
        {
            return giocatori;
        }

        public List<int> GetNEstratti()
        {
            return nEstratti;
        }

        public string GetState()
        {
            return state;
        }

        public EstrazioneNumeroRandom GetRandomGenerator()
        {
            return est;
        }

        abstract public void TurnoGioco();

        public void AggiungiGiocatori(Persona p)
        {
            giocatori.Add(p);
        }

        public abstract void CreaStati();

    }
       
}
