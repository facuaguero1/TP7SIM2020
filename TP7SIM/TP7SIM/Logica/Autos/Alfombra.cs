using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7SIM.Logica.Autos
{
    class Alfombra
    {
        public int nroAuto { get; set; }

        public DateTime FechaFinAspirarAlfombras { get; set; }

        public Alfombra(int n)
        {
            nroAuto = n;
        }
    }
}
