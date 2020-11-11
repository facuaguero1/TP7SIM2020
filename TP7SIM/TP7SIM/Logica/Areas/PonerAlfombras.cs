using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Autos;
using TP7SIM.Logica.Helper;
using TP7SIM.Logica.Eventos;

namespace TP7SIM.Logica.Areas
{
    class PonerAlfombras
    {
        public EstadoArea Estado { get; set; }

        public TimeSpan TiempoDeAtencion { get; set; }

        public DateTime FechaProximoFinAtencion { get; set; }

        public Auto AutoActual { get; set; }

        public void TomarCliente(Auto auto, DateTime reloj, Evento eActual)
        {
            if (auto == null) //no hay alfombra en cola
            {
                Estado = EstadoArea.Libre;
                TiempoDeAtencion = TimeSpan.Zero;
            }
            else
            {
                AutoActual = auto;

                if (!eActual.ColaAlfombrasListas.ContainsKey(auto.NroAuto))
                {
                    Estado = EstadoArea.EnEspera;
                    TiempoDeAtencion = TimeSpan.Zero;
                    FechaProximoFinAtencion = DateTime.MinValue;
                }
                else
                {

                    Estado = EstadoArea.Ocupado;
                    FechaProximoFinAtencion = reloj.AddHours(MySettings.TiempoPonerAlfombras / 60).AddMilliseconds(37);
                    TiempoDeAtencion = MySettings.RoundTimeSpan(0, FechaProximoFinAtencion - reloj);
                }
                
            }
        }

        public void SalirDeEspera(Alfombra alfombra, DateTime reloj)
        {
            Estado = EstadoArea.Ocupado;
            FechaProximoFinAtencion = reloj.AddHours(MySettings.TiempoPonerAlfombras / 60).AddMilliseconds(37);
            TiempoDeAtencion = MySettings.RoundTimeSpan(0, FechaProximoFinAtencion - reloj);
        }

        public void Liberar()
        {
            Estado = EstadoArea.Libre;
            TiempoDeAtencion = TimeSpan.Zero;
            FechaProximoFinAtencion = DateTime.MinValue;
            AutoActual = null;
        }
    }
}
