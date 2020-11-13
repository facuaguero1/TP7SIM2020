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
                //Console.WriteLine("NUMERO DE AUTO EN PONER ALFOMBRA: " + auto.NroAuto.ToString());

                /*try
                {*/
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
                        AutoActual._Alfombra = (Alfombra)eActual.ColaAlfombrasListas[AutoActual.NroAuto];
                    }
                /*}
                catch (NullReferenceException)
                {
                    Console.WriteLine("Nro AUTO excepcion: " + auto.NroAuto.ToString());
                    Console.WriteLine("No pienso hacer nada respecto a esto.");
                }*/
                
            }
        }

        public void SalirDeEspera(Alfombra alfombra, DateTime reloj)
        {
            Estado = EstadoArea.Ocupado;
            FechaProximoFinAtencion = reloj.AddHours(MySettings.TiempoPonerAlfombras / 60).AddMilliseconds(37);
            TiempoDeAtencion = MySettings.RoundTimeSpan(0, FechaProximoFinAtencion - reloj);
            AutoActual._Alfombra = alfombra;
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
