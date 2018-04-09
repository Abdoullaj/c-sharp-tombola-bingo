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
            Console.WriteLine("Nuova Tombola");
            Console.ReadKey();
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
                for(int indexPersone = 0; indexPersone < base.GetPersone().Count; indexPersone++)
                {
                    Persona p = base.GetPersone()[indexPersone];
                    Check(p,numeroEstratto);
                }

            }
        }

        

        private void Check (Persona p, int n)
        {
            for (int indiceCartelle = 0; indiceCartelle < p.GetCartelle().Count; indiceCartelle++)
            {
                Cartella cartella = p.GetCartelle()[indiceCartelle];
                for (int riga = 0; riga < cartella.GetMatrice().Length; riga++)
                {
                    int counter = 0;
                    for (int colonna = 0; colonna < cartella.GetMatrice().GetLength(riga); colonna++)
                    {
                        cartella.CheckNumero(n);
                        if (cartella.GetMatrice()[riga, colonna] == 0)
                        {
                            counter++;
                            SetState(states[counter],p);
                        }
                        
                    }
                }
                if (cartella.CartellaFinita())
                {
                    SetState("tombola", p);
                    break;
                }
            }
        }


        private void SetState(string newState,Persona p)
        {
            if (!state.Contains(newState))
            {
                state += newState;
                Console.WriteLine($"{p.GetUser()} ha fatto {newState}");
            }
        }
    }

}
