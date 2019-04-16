﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        //Punto 1
        //Metodo per calcolare la frequenzaMin 
        public static int CalcoloFrequenzaMin(int età)
        {
            int Controllo = Controlli.ControlloEta(età); //Richiamo la classe controlli per controllare la età
            int frequenzaMin = 0;

            if (Controllo != -1) //Se il metodo restituisce un valore int diverso da -1  significa che i controlli sono andati bene.
            {
                int frequenzaConsigliata = 220 - età;

                frequenzaMin = Convert.ToInt32(frequenzaConsigliata * 0.7);
            }
            else
            {
                frequenzaMin = -1;
            }
            return frequenzaMin;
        }

        //Metodo per calcolare la frequenzaMax 
        public static int CalcoloFrequenzaMax(int età)
        {
            int Controllo = Controlli.ControlloEta(età); //Richiamo la classe controlli per controllare la età
            int frequenzaMax = 0;

            if (Controllo != -1) //Se il metodo restituisce un valore int diverso da -1  significa che i controlli sono andati bene.
            {
                int frequenzaConsigliata = 220 - età;
                frequenzaMax = Convert.ToInt32(frequenzaConsigliata * 0.9);
            }
            else
            {
                frequenzaMax = -1;
            }

            return frequenzaMax;
        }

        //Punto 2
        //Metodo che permetta di interpretare i valori di frequenza cardiaca a riposo
        public static string FreqCardiacaRiposo(int BattitiAlMinuto)
        {
            string valoreFrequenza = "";
            int ControlloFrequenza = Controlli.ControlloFrequenza(BattitiAlMinuto); //Richiamo la classe controlli e il metodo controlloFrequenza per fare i controlli sulla frequenza inserita
            if (ControlloFrequenza != -1)
            {
                if (BattitiAlMinuto < 60)
                {
                    valoreFrequenza = "Bradicardia";

                }
                else if (BattitiAlMinuto >= 60 && BattitiAlMinuto <= 100)
                {
                    valoreFrequenza = "Normale";


                }
                else if (BattitiAlMinuto > 100)
                {
                    valoreFrequenza = "Tachicardia";
                }
            }
            else
            {
                valoreFrequenza = "-1";
            }
            return valoreFrequenza;
        }

    }
}