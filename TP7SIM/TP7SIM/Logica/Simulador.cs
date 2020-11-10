using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7SIM.Logica.Helper;
using TP7SIM.Logica.Eventos;
using TP7SIM.Logica.Autos;
using TP7SIM.Logica.Areas;

namespace TP7SIM.Logica
{
    class Simulador
    {
        public static Random Generador = new Random();

        public static void Simular(Principal form)
        {
            DateTime relojInicio = MySettings.HorarioInicio;

            form.progressbar.Maximum = MySettings.CantMaxClientes;

            Evento e_anterior = new Evento
            {
                NroEvento = 0,
                Tipo = Evento.TipoEvento.Inicio,
                Reloj = relojInicio,
                _LLegada = new Llegada(),

                _Auto = new Auto(relojInicio),


                ColaQuitarAlfombra = new List<Auto>(),
                ColaAspirarAlfombra = new List<Alfombra>(),
                ColaPonerAlfombra = new List<Auto>(),
                ColaLavado = new List<Auto>(),
                ColaSecado = new List<Auto>(),
                

                EmpleadoQA = new QuitarAlfombras
                {
                    Estado = EstadoArea.Libre,
                    FechaProximoFinAtencion = DateTime.MinValue,
                },
                EmpleadoAA = new AspirarAlfombras
                {
                    Estado = EstadoArea.Libre,
                    FechaProximoFinAtencion = DateTime.MinValue,
                },
                EmpleadoLavado1 = new Lavado
                {
                    Estado = EstadoArea.Libre,
                    FechaProximoFinAtencion = DateTime.MinValue,
                },
                EmpleadoLavado2 = new Lavado
                {
                    Estado = EstadoArea.Libre,
                    FechaProximoFinAtencion = DateTime.MinValue,
                },
                EmpleadoSecado = new Secado
                {
                    Estado = EstadoArea.Libre,
                    FechaProximoFinAtencion = DateTime.MinValue,
                },
                EmpleadoPA = new PonerAlfombras
                {
                    Estado = EstadoArea.Libre,
                    FechaProximoFinAtencion = DateTime.MinValue,
                }



            };
            /*
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

            form.PintarCeldas();*/
            }
    }
}
