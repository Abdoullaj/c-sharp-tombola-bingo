using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Gioco
{
    class Tombola : GameFactory
    {
        private Boolean end;
        private string state;
        private string[] states;
        public Tombola():base()
        {
            end = false;
            state = base.GetState();
            CreaStati();
            Console.WriteLine("Nuova Tombola");
            CreazioneTombola();
        }

        private void CreazioneTombola()
        {
            Console.WriteLine("Quanti giocatori?");
            int nGiocatori = int.Parse(Console.ReadLine());
            for(int i = 0; i<nGiocatori; i++)
            {

                Console.WriteLine("User giocatore");
                string user = Console.ReadLine();

                Console.WriteLine("Quante cartelle vuole comprare?");
                int nCartelle= int.Parse(Console.ReadLine());

                Persona p = new Persona(user);
                for (int j = 0; j < nCartelle; j++)
                {
                    p.CompraCartella('t');
                }

                base.AddToGiocatori(p);
            }
            Console.WriteLine("Iscrizione completata");
            Console.WriteLine($"N giocatori: {base.GetPersone().Count}");
        }


        public override void CreaStati()
        {
            states = new string[] {"","","ambo", "terna", "quaterna", "cinquina"};
        }

        public override void TurnoGioco()
        {
            while (!end)
            {
                if (state.Contains("tombola"))
                {
                    end = true;
                    break;
                }

                int numeroEstratto = base.GetRandomGenerator().Estrazione();
                base.AddToNumeriEstratti(numeroEstratto);
                Console.WriteLine($"{numeroEstratto}");
                for (int indexPersone = 0; indexPersone < base.GetPersone().Count; indexPersone++)
                {
                    Persona p = base.GetPersone()[indexPersone];
                    Check(p, numeroEstratto);
                }

            }
        }

        

        private void Check (Persona p, int n)
        {
            for (int indiceCartelle = 0; indiceCartelle < p.GetCartelle().Count; indiceCartelle++)
            {
                Console.WriteLine($"Dentro la cartella n {indiceCartelle} di {p.GetUser()}");
                Cartella cartella = p.GetCartelle()[indiceCartelle];
                cartella.CheckNumero(n);

                for (int i = 0; i < cartella.GetMatrice().GetLength(0); i++)
                {
                    if (cartella.CountZero(i) > 1)
                    {
                        SetState(cartella.CountZero(i), p);
                        cartella.PrintSchema();
                        break;
                    }

                }
                if (cartella.CartellaFinita())
                {
                    SetEnd(p);
                    break;
                }
            }
        }


        private void SetState(int counter,Persona p)
        {
            string newState = states[counter];
            
            if (!state.Contains(newState))
            {
                state += newState;
                Console.WriteLine($"{p.GetUser()} ha fatto {newState}");
            }
        }

        private void SetEnd(Persona p)
        {
            if (!state.Contains("tombola"))
            {
                state += "tombola";
                Console.WriteLine($"{p.GetUser()} ha fatto tombola!");
            }
        }
    }

}
