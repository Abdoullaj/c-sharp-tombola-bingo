using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Gioco
{
    class Persona
    {
        private String user;
        private List <Cartella>cartelle;
        private double costoComplessivoCartelle;

        public Persona(String us)
        {
            this.user = us;
            cartelle = new List<Cartella>();
            costoComplessivoCartelle = 0;
        }

        public void CompraCartella(char gioco)
        {
            Console.WriteLine("user"+user+"buying cartella");
            Cartella c = new Cartella(gioco);
            cartelle.Add(c);
            costoComplessivoCartelle += c.GetCosto();
        }
        
        public String GetUser()
        {
            return user;
        }

        public List <Cartella>GetCartelle()
        {
            return cartelle;
        }

        public double GetCostoTotale()
        {
            return costoComplessivoCartelle;
        }

    }
}
