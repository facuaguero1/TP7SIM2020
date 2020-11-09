using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7SIM.Logica.Eventos
{
    class Evento
    {
        public Evento()
        {
        }

        public Evento EventoAnterior { get; set; }

        public int NroEvento { get; set; }

        public DateTime Reloj { get; set; }

        public TipoEvento Tipo { get; set; }

        public Llegada _LLegada { get; set; }

        public enum TipoEvento
        {
            Inicio,
            LlegadaCliente,
            FinQuitarAlfombras,
            FinAspirado,
            FinLavado1,
            FinLavado2,
            FinSecado,
            FinPonerAlfombras
        }

        public Evento(Evento ea)
        {
            _LLegada = new Llegada()
            {
                FechaProximaLlegada = ea._LLegada.FechaProximaLlegada
            };
        }
    }
}
