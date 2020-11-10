using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Autos;
using TP7SIM.Logica.Areas;

namespace TP7SIM.Logica.Eventos
{
    class Evento
    {
        public Evento()
        {
        }

        public Evento EventoAnterior { get; set; }

        public int NroEvento { get; set; }

        public Auto _Auto { get; set; }

        public DateTime Reloj { get; set; }

        public List<Auto> ColaQuitarAlfombra { get; set; }

        public List<Alfombra> ColaAspirarAlfombra { get; set; }

        public List<Auto> ColaPonerAlfombra { get; set; }

        public List<Auto> ColaLavado { get; set; }

        public List<Auto> ColaSecado { get; set; }

        public QuitarAlfombras EmpleadoQA { get; set; }

        public AspirarAlfombras EmpleadoAA { get; set; }

        public PonerAlfombras EmpleadoPA { get; set; }

        public Lavado EmpleadoLavado1 { get; set; }

        public Lavado EmpleadoLavado2 { get; set; }

        public Secado EmpleadoSecado { get; set; }

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
