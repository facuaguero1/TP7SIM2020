using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7SIM.Logica.Autos
{
    class Auto
    {
        public Auto(DateTime reloj)
        {
            FechaLlegada = reloj;
            _Alfombra = new Alfombra();
        }

        public DateTime FechaLlegada { get; set; }
        public DateTime FechaFinServicio { get; set; }
        public int NroAuto { get; set; }
        public Alfombra _Alfombra { get; set; }
    }
}
