using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Helper;
using TP7SIM.Logica.Eventos;

namespace TP7SIM.Logica
{
    class Simulador
    {
        public static Random Generador = new Random();

        public static void Simular(Principal form)
        {
            DateTime relojInicio = MySettings.HorarioInicio;

            form.progressbar.Maximum = MySettings.DiasSimulacion;

            Evento e_anterior = new Evento
            {
                NroEvento = 0,
                Tipo = Evento.TipoEvento.Inicio,
                Reloj = relojInicio,
                _LLegada = new Llegada(),
                Pedido = new Pedido(relojInicio)
                {
                    FechaAbandono = DateTime.MinValue
                },
                ColaPedidos_APreparar = new List<Pedido>(),

                ColaPedidos_AEntregar = new List<Pedido>(),

                Empleado_1 = new Cocinero
                {
                    Estado = EstadoEmpleado.Libre,
                    FechaProximoFinPreparacion = DateTime.MinValue,
                    UltimaPreparacion = relojInicio
                },
                Empleado_2 = new Cocinero
                {
                    Estado = EstadoEmpleado.Libre,
                    FechaProximoFinPreparacion = DateTime.MinValue,
                    UltimaPreparacion = relojInicio
                },
                Empleado_3 = new Cocinero
                {
                    Estado = EstadoEmpleado.Libre,
                    FechaProximoFinPreparacion = DateTime.MinValue,
                    UltimaPreparacion = relojInicio
                },
                Repartidor = new Delivery
                {
                    Estado = EstadoEmpleado.Libre,
                    Mochila = new List<Pedido>(),
                    ProximoFinEntrega = DateTime.MinValue
                },
                _Turno = new Turno
                {
                    EstadoTurno = Turno.Estado.Abierto,
                    ProximoCierre = relojInicio.AddHours(MySettings.TiempoFinTurno)
                },

                resultadoFinSim = new ResultadoFinSim(),
                resultadoFinTurno = new ResultadoFinTurno()

            };
            e_anterior._Turno.CalcularProximaApertura(0);
            e_anterior._LLegada.CalcularProximaLlegada(e_anterior.Reloj);
            form.MostrarEnGrilla(e_anterior);

            var diasSimulados = 0;
            while (diasSimulados < MySettings.DiasSimulacion)
            {


                var e_actual = new Evento(e_anterior);
                e_actual.EventoAnterior = e_anterior;
                //determinamos el nro de evento
                e_actual.NroEvento = e_anterior.NroEvento + 1;


                //seteamos el nuevo valor de reloj
                //e_actual.Reloj = DeterminarTiempoReloj(e_anterior);

                //determinamos el tipo
                e_actual.Tipo = DeterminarTipoEvento(e_actual);

                switch (e_actual.Tipo)
                {
                    case Evento.TipoEvento.LLegadaPedido:
                        e_actual.LlegadaDePedido_Event();
                        break;
                    case Evento.TipoEvento.FinElaboracionCocinero1:
                        e_actual.FinDeElaboracion_Event(e_actual.Empleado_1);
                        break;
                    case Evento.TipoEvento.FinElaboracionCocinero2:
                        e_actual.FinDeElaboracion_Event(e_actual.Empleado_2);
                        break;
                    case Evento.TipoEvento.FinElaboracionCocinero3:
                        e_actual.FinDeElaboracion_Event(e_actual.Empleado_3);
                        break;
                    case Evento.TipoEvento.CancelacionPedido:
                        e_actual.CancelacionDePedido_Event();
                        break;
                    case Evento.TipoEvento.EntregaFinalizada:
                        e_actual.EntregaFinalizada_Event();
                        break;
                    case Evento.TipoEvento.FinTurno:
                        bool nuevoDia = e_actual.FinDeTurno_Event(diasSimulados);

                        if (nuevoDia)
                        {
                            if (form.rbn_Cada1000.Checked == true && (diasSimulados % 1000 == 0 || diasSimulados == MySettings.DiasSimulacion))
                            {
                                form.MostrarEnGrilla(e_actual);
                            };

                            diasSimulados++;

                            if (form.rbn_Cada1000.Checked == true && (diasSimulados % 1000 == 0 || diasSimulados == MySettings.DiasSimulacion - 1))
                            {
                                form.AgregarEspaciado("Dia: " + diasSimulados.ToString());
                            }
                        };


                        break;
                    case Evento.TipoEvento.InicioTurno:
                        e_actual.InicioTurno_Event(diasSimulados);
                        break;
                }

                //diasSimulados++; //TODO: Esta linea no deberia esta ren la version final, se conserva solo a fines de testing


                e_anterior = e_actual;
                if (form.rbn_DiaParticular.Checked == true)
                {
                    if (DiaAMostrar == 0)
                    {
                        form.MostrarEnGrilla(e_actual);
                    }
                    else
                    {
                        int horaDesde = Int32.Parse(form.txt_HoraDesde.Text);
                        if (DiaAMostrar - 1 == diasSimulados && e_actual.Reloj.Hour >= horaDesde)
                        {
                            form.MostrarEnGrilla(e_actual);
                        }

                    }
                }
                else
                {
                    if (diasSimulados % 1000 == 0 || diasSimulados == MySettings.DiasSimulacion - 1)
                    {
                        form.MostrarEnGrilla(e_actual);
                    }
                }
                form.progressbar.Value = diasSimulados;
            }

            form.PintarCeldas();
        }
    }
}
