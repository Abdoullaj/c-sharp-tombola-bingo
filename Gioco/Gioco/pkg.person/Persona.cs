using System;
using System.Collections;
using System.Text;

namespace Gioco
{
    class Persona
    {
        private String user;
        private ArrayList cartelle;


        public Persona(String us)
        {
            this.user = us;
            cartelle = new ArrayList();
        }

        public void CompraCartella(char gioco)
        {
            cartelle.Add(new Cartella(gioco));
        }


    }
}
