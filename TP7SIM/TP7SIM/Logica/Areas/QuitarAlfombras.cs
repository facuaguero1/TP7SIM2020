using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Autos;
using TP7SIM.Logica.Helper;

namespace TP7SIM.Logica.Areas
{
    class QuitarAlfombras
    {
        public EstadoArea Estado { get; set; }

        public TimeSpan TiempoDeAtencion { get; set; }

        public DateTime FechaProximoFinAtencion { get; set; }

        public Auto AutoActual { get; set; }


        public void TomarCliente(Auto a, DateTime reloj)
        {
            if (a == null) //no hay pedido en cola
            {
                Estado = EstadoArea.Libre;
                TiempoDeAtencion = TimeSpan.Zero;
                //UltimaPreparacion = ProximoFinPreparacion.Value;
                //ProximoFinPreparacion = setearlo null;
                //PedidoActual = null;
            }
            else
            {
                Estado = EstadoArea.Ocupado;

                FechaProximoFinAtencion = reloj.AddHours(MySettings.TiempoQuitarAlfombras / 60).AddMilliseconds(37);
                a.FechaFinQuitarAlfombras = FechaProximoFinAtencion;
                TiempoDeAtencion = MySettings.RoundTimeSpan(0, FechaProximoFinAtencion - reloj);

                AutoActual = a;
            }
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
