using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Gioco
{
    class Tombola : GameFactory
    {

        public Tombola():base()
        {
         

        }
        
        public override void TurnoGioco()
        {
            Boolean end = false;
            while (!end)
            {
                int numeroEstratto = base.GetRandomGenerator().Estrazione();
                for(int indexPersone = 0; indexPersone < base.GetPersone().Count; indexPersone++)
                {
                    Persona persona = base.GetPersone()[indexPersone];
                    for (int indiceCartelle = 0; indiceCartelle < persona.GetCartelle().Count; indiceCartelle++)
                    {
                        Cartella cartella = persona.GetCartelle()[indiceCartelle];
                        for (int riga = 0; riga < cartella.GetMatrice().Length; riga++)
                        {
                            for(int colonna = 0; colonna < cartella.GetMatrice().GetLength(riga); colonna++)
                            {

                            }
                        }
                    }
                    
                }

            }
        }


    }
}
