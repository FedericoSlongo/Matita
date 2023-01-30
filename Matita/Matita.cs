namespace Matita
{
    public class Matita
    {
        public int lunghezza { get; private set;} = 10;
        public string colore { get; private set; } = "nero";
        public string cio_che_ha_scritto { get; protected set; }  = "";

        public string Scrivi(string come_argomento_una_stringa)
        {
            //Se la stringa è meno di 10 non deve rimuovere lunghezza quindi la returno subito
            if (come_argomento_una_stringa.Length < 10)
                return come_argomento_una_stringa;

            string returna_questa_stringa_di_caratteri_utilizzabili = "";
            for (int i = 0; i < come_argomento_una_stringa.Length; i++)
            {
                if (lunghezza == 0)
                    break;
                if (i % 10 == 0)
                    lunghezza--;
                returna_questa_stringa_di_caratteri_utilizzabili += come_argomento_una_stringa[i];
            }
            cio_che_ha_scritto += returna_questa_stringa_di_caratteri_utilizzabili;
            return returna_questa_stringa_di_caratteri_utilizzabili;
        }
    }

    public class MatitaConGommino : Matita
    {
        int numero_cancellature_rimaste_a_disposizione = 5;

        public void Cancella(int numero_K_di_caratteri_da_eliminare)
        {
            int counter = 0;
            if (cio_che_ha_scritto.Length >= numero_K_di_caratteri_da_eliminare)
            {
                numero_cancellature_rimaste_a_disposizione = numero_cancellature_rimaste_a_disposizione - (numero_K_di_caratteri_da_eliminare / 5);
                if (numero_cancellature_rimaste_a_disposizione > 0)
                {
                    for (int i = cio_che_ha_scritto.Length - 1; i >= numero_K_di_caratteri_da_eliminare; i--)
                    {
                        counter += cio_che_ha_scritto[i] == ' ' ? 1 : 0;
                    }
                    base.cio_che_ha_scritto = cio_che_ha_scritto.Remove(cio_che_ha_scritto.Length - 1 - numero_K_di_caratteri_da_eliminare - counter);
                }
            }
        }
    }
}
