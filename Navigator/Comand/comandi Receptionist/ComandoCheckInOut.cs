using Dominio;

namespace Comand
{
    public class ComandoCheckInOut : IComando
    {
        public static readonly string codiceComando = "1" ;
        public static readonly string descrizioneComando = "Check-in/Check-out";

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
            ConsoleCheckInOut ch = new ConsoleCheckInOut();
            ch.Start(istanza);
        }
    }

}