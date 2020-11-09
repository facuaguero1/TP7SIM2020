using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Helper;

namespace TP7SIM.Logica.Eventos
{
    class Llegada
    {
        public TimeSpan TiempoEntreLlegadas { get; set; }
        public DateTime FechaProximaLlegada { get; set; }

        public void CalcularProximaLlegada(DateTime reloj)
        {
            double minutos = MySettings.Distribuciones.Exponencial.Calcular(MySettings.MediaLlegadas);
            FechaProximaLlegada = reloj.AddMinutes(minutos).AddMilliseconds(7);
            TiempoEntreLlegadas = MySettings.RoundTimeSpan(0, FechaProximaLlegada - reloj);
        }
    }
}
