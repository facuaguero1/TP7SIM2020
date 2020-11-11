using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Autos;
using TP7SIM.Logica.Helper;

namespace TP7SIM.Logica.Areas
{
    class AspirarAlfombras
    {
        public EstadoArea Estado { get; set; }

        public TimeSpan TiempoDeAtencion { get; set; }

        public DateTime FechaProximoFinAtencion { get; set; }

        public Alfombra AlfombraActual { get; set; }

        public void TomarCliente(Alfombra a, DateTime reloj)
        {
            if (a == null) //no hay alfombra en cola
            {
                Estado = EstadoArea.Libre;
                TiempoDeAtencion = TimeSpan.Zero;
            }
            else
            {
                Estado = EstadoArea.Ocupado;

                FechaProximoFinAtencion = reloj.AddHours(MySettings.Distribuciones.UniformeAspirado.Calcular() / 60).AddMilliseconds(37);
                a.FechaFinAspirarAlfombras = FechaProximoFinAtencion;
                TiempoDeAtencion = MySettings.RoundTimeSpan(0, FechaProximoFinAtencion - reloj);

                AlfombraActual = a;
            }
        }

        public void Liberar()
        {
            Estado = EstadoArea.Libre;
            TiempoDeAtencion = TimeSpan.Zero;
            FechaProximoFinAtencion = DateTime.MinValue;
            AlfombraActual = null;
        }
    }
}
