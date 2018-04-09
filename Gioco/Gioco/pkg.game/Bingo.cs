using System;
using System.Collections.Generic;
using System.Text;

namespace Gioco
{
    class Bingo : GameFactory
    {
        private EstrazioneNumeroRandom est = new EstrazioneNumeroRandom();
        private Boolean end;
        private string state;

        public Bingo() : base()
        {
            end = false;
            state = "";
            Console.WriteLine("Nuovo Bingo");
            CreazioneBingo();
        }

        private void CreazioneBingo()
        {
            Console.WriteLine("Quanti giocatori?");
            int nGiocatori = int.Parse(Console.ReadLine());
            for (int i = 0; i < nGiocatori; i++)
            {

                Console.WriteLine("User giocatore");
                string user = Console.ReadLine();

                Console.WriteLine("Quante cartelle vuole comprare?");
                int nCartelle = int.Parse(Console.ReadLine());

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

        public override void TurnoGioco() {
            while (!end)
            {
                if (state.Contains("bingo"))
                {
                    end = true;
                    break;
                }

                int numeroEstratto = est.Estrazione();
                base.AddToNumeriEstratti(numeroEstratto);
                Console.WriteLine($"{numeroEstratto}");
                for (int indexPersone = 0; indexPersone < base.GetPersone().Count; indexPersone++)
                {
                    Persona p = base.GetPersone()[indexPersone];
                    Check(p, numeroEstratto);
                }

            }
        }

        private void Check(Persona p, int n)
        {
            for (int indiceCartelle = 0; indiceCartelle < p.GetCartelle().Count; indiceCartelle++)
            {
                Console.WriteLine($"Dentro la cartella n {indiceCartelle} di {p.GetUser()}");
                Cartella cartella = p.GetCartelle()[indiceCartelle];
                cartella.CheckNumero(n);

                for (int i = 0; i < cartella.GetMatrice().GetLength(0); i++)
                {
                    if (cartella.CountZero(i) == 5 && !state.Contains("cinquina"))
                    {
                        state += "cinquina";
                        Console.WriteLine($"{p.GetUser()} ha fatto cinquina");
                        cartella.PrintSchema();
                        break;
                    }

                }
                if (cartella.CartellaFinita())
                {
                    SetEnd(p);
                    cartella.PrintSchema();
                    break;
                }
            }
        }

        private void SetEnd(Persona p)
        {
            if (!state.Contains("bingo"))
            {
                state += "bingo";
                Console.WriteLine($"{p.GetUser()} ha fatto bingo!");
            }
        }
    }


}
