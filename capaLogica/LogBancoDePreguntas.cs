using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
namespace capaLogica
{
    public class LogBancoDePreguntas
    {
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogBancoDePreguntas _instancia = new LogBancoDePreguntas();
        //privado para evitar la instanciación directa
        public static LogBancoDePreguntas Instancia
        {
            get
            {
                return LogBancoDePreguntas._instancia;
            }
        }
        public List<EntBancoDePreguntas> ListarAsistencia()
        {
            return datBancoDePreguntas.Instancia.ListarBancoDePreguntas();

        }

        public void InsertarBanco(EntBancoDePreguntas Cli)
        {
            datBancoDePreguntas.Instancia.InsertarAsistencia(Cli);
        }
        public void ActualizarPregunta(EntBancoDePreguntas Cli)
        {
            datBancoDePreguntas.Instancia.ActualizarCliente(Cli);
        }
    }
}
