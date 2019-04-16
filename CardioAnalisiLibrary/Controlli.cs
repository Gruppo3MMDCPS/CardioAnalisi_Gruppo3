using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    class Controlli
    {
        //Metodo per controllare età 
        public static int ControlloEta(int età)
        {
            int risultato = 0;
            try
            {
                Convert.ToInt32(età);
                if (età > 0 && età <= 120)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = -1;
                }
            }
            catch (Exception)
            {
                risultato = -1;
            }

            return risultato;
        }

        //Metodo per controllare frequenza
        public static int ControlloFrequenza(int frequenza)
        {
            int risultato = 0;
            try
            {
                Convert.ToInt32(frequenza);
                if (frequenza > 0 && frequenza <= 200)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = -1;
                }
            }
            catch (Exception)
            {
                risultato = -1;
            }

            return risultato;
        }

        //metodo per controllare Peso
        public static double ControlloPeso(double peso)
        {
            int risultato = 0;
            try
            {
                Convert.ToDouble(peso);
                if (peso > 0 && peso <= 700)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = -1;
                }
            }
            catch (Exception)
            {
                risultato = -1;
            }

            return risultato;
        }


        //metodo per controllare durata 
        public static double ControlloDurata(double durata)
        {
            int risultato = 0;
            try
            {
                Convert.ToDouble(durata);
                if (durata >= 0 && durata <= 40)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = -1;
                }
            }
            catch (Exception)
            {
                risultato = -1;
            }

            return risultato;
        }
    }
}
