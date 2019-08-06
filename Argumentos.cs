using EjecutaScripts;
using System.Text;

namespace EjecutaSps
{
    public class Argumentos
    {
        private StringBuilder builder;

        public string Cadena
        {
            get { return builder.ToString(); }
        }

        public Argumentos()
        {
            builder = new StringBuilder();
        }

        private void AgregarEspacioEnBlanco()
        {
            builder.Append(' ');
        }

        public void AgregarArgumento(string argumento, string valor = "")
        {
            builder.Append(argumento);

            if (!string.IsNullOrEmpty(valor))
            {
                AgregarEspacioEnBlanco();
                builder.Append($"{Literales.EscapeComillasDobles}{valor}{Literales.EscapeComillasDobles}");
            }

            AgregarEspacioEnBlanco();
        }
    }
}
