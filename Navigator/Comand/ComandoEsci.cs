using Dominio;

namespace Comand
{
    public class ComandoEsci : IComando
    {
        public static readonly string codiceComando = "0";
        public static readonly string descrizioneComando = "Esci";

        public string GetCodiceComando()
        {
            return codiceComando;
        }

        public string GetDescrizioneComando()
        {
            return descrizioneComando;
        }

        public void Esegui(NaviGator istanza)
        {
            //torna al menu precedente oppure esce se non ci sono menu precedenti
        }
    }

}