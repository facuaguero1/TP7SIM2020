using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Autos;
using TP7SIM.Logica.Areas;
using TP7SIM.Logica.Helper;

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

        public int ProximoCliente { get; set; }

        public DateTime Reloj { get; set; }

        public List<Auto> ColaQuitarAlfombra { get; set; }

        public List<Alfombra> ColaAspirarAlfombra { get; set; }

        public List<Auto> ColaPonerAlfombra { get; set; }

        public Hashtable ColaAlfombrasListas { get; set; }

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
            FinPonerAlfombras,
            EventoNoRegistrado
        }

        public Evento(Evento ea)
        {
            _LLegada = new Llegada()
            {
                FechaProximaLlegada = ea._LLegada.FechaProximaLlegada
            };
            if (ea.ProximoCliente <= MySettings.CantMaxClientes) { ProximoCliente = ea.ProximoCliente; }

           
            ProximoCliente = ea.ProximoCliente;

            ColaQuitarAlfombra = new List<Auto>(ea.ColaQuitarAlfombra);
            ColaAspirarAlfombra = new List<Alfombra>(ea.ColaAspirarAlfombra);
            ColaLavado = new List<Auto>(ea.ColaLavado);
            ColaSecado = new List<Auto>(ea.ColaSecado);
            ColaPonerAlfombra = new List<Auto>(ea.ColaPonerAlfombra);
            ColaAlfombrasListas = new Hashtable(ea.ColaAlfombrasListas);

            EmpleadoQA = new QuitarAlfombras()
            {
                Estado = ea.EmpleadoQA.Estado,
                FechaProximoFinAtencion = ea.EmpleadoQA.FechaProximoFinAtencion,
                AutoActual = ea.EmpleadoQA.AutoActual
            };
            EmpleadoAA = new AspirarAlfombras()
            {
                Estado = ea.EmpleadoAA.Estado,
                FechaProximoFinAtencion = ea.EmpleadoAA.FechaProximoFinAtencion,
                AlfombraActual = ea.EmpleadoAA.AlfombraActual
            };
            EmpleadoLavado1 = new Lavado()
            {
                Estado = ea.EmpleadoLavado1.Estado,
                FechaProximoFinAtencion = ea.EmpleadoLavado1.FechaProximoFinAtencion,
                AutoActual = ea.EmpleadoLavado1.AutoActual
            };
            EmpleadoLavado2 = new Lavado()
            {
                Estado = ea.EmpleadoLavado2.Estado,
                FechaProximoFinAtencion = ea.EmpleadoLavado2.FechaProximoFinAtencion,
                AutoActual = ea.EmpleadoLavado2.AutoActual
            };
            EmpleadoSecado = new Secado()
            {
                Estado = ea.EmpleadoSecado.Estado,
                FechaProximoFinAtencion = ea.EmpleadoSecado.FechaProximoFinAtencion,
                AutoActual = ea.EmpleadoSecado.AutoActual
            };
            EmpleadoPA = new PonerAlfombras()
            {
                Estado = ea.EmpleadoPA.Estado,
                FechaProximoFinAtencion = ea.EmpleadoPA.FechaProximoFinAtencion,
                AutoActual = ea.EmpleadoPA.AutoActual
            };

        }

        public void LlegadaCliente_Event()
        {
            var llegadaNueva = new Llegada();
            
            _LLegada = llegadaNueva;
            

            //Setea los datos del nuevo cliente
            var nAuto = new Auto(Reloj, EventoAnterior.ProximoCliente);

            if (EventoAnterior.ProximoCliente < MySettings.CantMaxClientes)
            {
                ProximoCliente = EventoAnterior.ProximoCliente + 1;
                llegadaNueva.CalcularProximaLlegada(Reloj);
            }
            else
            {
                ProximoCliente = 0;
                llegadaNueva.TiempoEntreLlegadas = TimeSpan.Zero;
                llegadaNueva.FechaProximaLlegada = DateTime.MinValue;
            }

            _Auto = nAuto;
            

            if (EmpleadoQA.Estado == EstadoArea.Ocupado)
            {
                ColaQuitarAlfombra.Add(nAuto);
            }
            else
            {
                EmpleadoQA.TomarCliente(_Auto, Reloj);
            }
        }

        public void FinQuitarAlfombras_Event()
        {
            _Auto = EventoAnterior.EmpleadoQA.AutoActual;

            if (ColaQuitarAlfombra.Count > 0)
            {
                EmpleadoQA.TomarCliente(ColaQuitarAlfombra[0], Reloj);
                ColaQuitarAlfombra.RemoveAt(0);
            }
            else
            {
                EmpleadoQA.Liberar();
            }

            // Se quita la alfombra
            Alfombra alfombra = EventoAnterior.EmpleadoQA.AutoActual._Alfombra;
            _Auto._Alfombra = null;
            if (EmpleadoAA.Estado == EstadoArea.Ocupado)
            {
                ColaAspirarAlfombra.Add(alfombra);
            }
            else
            {
                EmpleadoAA.TomarCliente(alfombra, Reloj);
            }

            //Se decide el lavado
            if (EmpleadoLavado1.Estado == EstadoArea.Ocupado && EmpleadoLavado2.Estado == EstadoArea.Ocupado)
            {
                ColaLavado.Add(_Auto);
            }
            else
            {
                if (EmpleadoLavado1.Estado == EstadoArea.Libre)
                {
                    EmpleadoLavado1.TomarCliente(_Auto, Reloj);
                }
                else
                {
                    EmpleadoLavado2.TomarCliente(_Auto, Reloj);
                }
            }
        }

        public void FinAspirarAlfombras_Event()
        {
            _Auto = new Auto(Reloj, EventoAnterior.EmpleadoAA.AlfombraActual.nroAuto);
            Alfombra alfombra = EventoAnterior.EmpleadoAA.AlfombraActual;

            if (ColaAspirarAlfombra.Count > 0)
            {
                EmpleadoAA.TomarCliente(ColaAspirarAlfombra[0], Reloj);
                ColaAspirarAlfombra.RemoveAt(0);
            }
            else
            {
                EmpleadoAA.Liberar();
            }

            if (EmpleadoPA.Estado == EstadoArea.EnEspera && EmpleadoPA.AutoActual.NroAuto == alfombra.nroAuto)
            {
                EmpleadoPA.SalirDeEspera(alfombra, Reloj);
            }
            else
            {
                ColaAlfombrasListas.Add(alfombra.nroAuto, alfombra);
            }
        }

        public void FinLavado_Event(Lavado empleado)
        {
            _Auto = empleado.AutoActual;
            empleado.FechaProximoFinAtencion = DateTime.MinValue;
            if (EmpleadoSecado.Estado == EstadoArea.Ocupado)
            {
                ColaSecado.Add(empleado.AutoActual);
            }
            else
            {
                EmpleadoSecado.TomarCliente(empleado.AutoActual, Reloj);
            }
        }

        public void FinSecado_Event()
        {
            _Auto = EmpleadoSecado.AutoActual;
            //La liberación de una estación de lavado se da recién cuando finaliza el secado
            if (EmpleadoLavado1.AutoActual != null && EmpleadoSecado.AutoActual.NroAuto == EmpleadoLavado1.AutoActual.NroAuto)
            {
                AdministrarEmpleado_FinSecado(EmpleadoLavado1);
            }
            else
            {
                AdministrarEmpleado_FinSecado(EmpleadoLavado2);
            }

            if (ColaSecado.Count > 0)
            {
                EmpleadoSecado.TomarCliente(ColaSecado[0], Reloj);
                ColaSecado.RemoveAt(0);
            }
            else
            {
                EmpleadoSecado.Liberar();
            }

            if (EmpleadoPA.Estado != EstadoArea.Libre)
            {
                ColaPonerAlfombra.Add(_Auto);
            }
            else
            {
                EmpleadoPA.TomarCliente(_Auto, Reloj, this);
            }
        }

        private void AdministrarEmpleado_FinSecado(Lavado empleadoLavado)
        {
            if (ColaLavado.Count > 0)
            {
                empleadoLavado.TomarCliente(ColaLavado[0], Reloj);
                ColaLavado.RemoveAt(0);
            }
            else
            {
                empleadoLavado.Liberar();
            }
        }

        public void FinPonerAlfombras_Event()
        {
            _Auto = EmpleadoPA.AutoActual;

            if (ColaPonerAlfombra.Count > 0)
            {
                EmpleadoPA.TomarCliente(ColaPonerAlfombra[0], Reloj, this);
                ColaPonerAlfombra.RemoveAt(0);
            }
            else
            {
                EmpleadoPA.Liberar();
            }
            
        }
    }
}
