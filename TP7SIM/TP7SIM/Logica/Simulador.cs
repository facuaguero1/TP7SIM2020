using System;
using System.Collections.Generic;
using System.Collections;
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

                _Auto = new Auto(relojInicio, 1),

                ProximoCliente = 1,


                ColaQuitarAlfombra = new List<Auto>(),
                ColaAspirarAlfombra = new List<Alfombra>(),
                ColaPonerAlfombra = new List<Auto>(),
                ColaLavado = new List<Auto>(),
                ColaSecado = new List<Auto>(),
                ColaAlfombrasListas = new Hashtable(),
                

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
            
            e_anterior._LLegada.CalcularProximaLlegada(e_anterior.Reloj);
            //form.MostrarEnGrilla(e_anterior);
            
            var clientes = 0;
            while (clientes < MySettings.CantMaxClientes)
            {


                var e_actual = new Evento(e_anterior);
                e_actual.EventoAnterior = e_anterior;
                //determinamos el nro de evento
                e_actual.NroEvento = e_anterior.NroEvento + 1;

                //determinamos el tipo
                e_actual.Tipo = DeterminarTipoEvento(e_actual);

                switch (e_actual.Tipo)
                {
                    case Evento.TipoEvento.LlegadaCliente:
                        e_actual.LlegadaCliente_Event();
                        clientes++;
                        break;
                    case Evento.TipoEvento.FinQuitarAlfombras:
                        e_actual.FinQuitarAlfombras_Event();
                        break;
                    case Evento.TipoEvento.FinAspirado:
                        e_actual.FinAspirarAlfombras_Event();
                        break;
                    case Evento.TipoEvento.FinLavado1:
                        e_actual.FinLavado_Event(e_actual.EmpleadoLavado1);
                        break;
                    case Evento.TipoEvento.FinLavado2:
                        e_actual.FinLavado_Event(e_actual.EmpleadoLavado2);
                        break;
                    case Evento.TipoEvento.FinSecado:
                        e_actual.FinSecado_Event();
                        break;
                    case Evento.TipoEvento.FinPonerAlfombras:
                        e_actual.FinPonerAlfombras_Event();
                        break;
                    /*

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
                        break;*/
                }

                //diasSimulados++; //TODO: Esta linea no deberia esta ren la version final, se conserva solo a fines de testing

                
                e_anterior = e_actual;
                /*
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
                form.progressbar.Value = diasSimulados;*/
            }

            form.PintarCeldas();
        }

        private static Evento.TipoEvento DeterminarTipoEvento(Evento evActual)
        {
            var evAnterior = evActual.EventoAnterior;
            var earliest = evActual.Reloj;//la fecha determinada por el metodo anterior
            

            int iteracion = 0;
            while (true)
            {
                evActual.Reloj = earliest = DeterminarTiempoReloj(evActual);
                if (evAnterior._LLegada.FechaProximaLlegada == earliest) return Evento.TipoEvento.LlegadaCliente;
                if (evAnterior.EmpleadoQA.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinQuitarAlfombras;
                if (evAnterior.EmpleadoLavado1.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinLavado1;
                if (evAnterior.EmpleadoLavado2.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinLavado2;
                if (evAnterior.EmpleadoSecado.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinSecado;
                if (evAnterior.EmpleadoSecado.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinSecado;
                if (evAnterior.EmpleadoPA.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinPonerAlfombras;
                
                Console.Write("");
            }

            return Evento.TipoEvento.EventoNoRegistrado;
        }

        private static DateTime DeterminarTiempoReloj(Evento ev)
        {

            DateTime proxLlegada;
            proxLlegada = ev._LLegada.FechaProximaLlegada;


            var arr = new List<DateTime>
            {

                ev.EmpleadoQA.FechaProximoFinAtencion,
                ev.EmpleadoAA.FechaProximoFinAtencion,
                ev.EmpleadoPA.FechaProximoFinAtencion,
                ev.EmpleadoLavado1.FechaProximoFinAtencion,
                ev.EmpleadoLavado2.FechaProximoFinAtencion,
                ev.EmpleadoSecado.FechaProximoFinAtencion,
                proxLlegada
            };

            var fechaMinima = arr.Min();

            while (fechaMinima <= ev.Reloj)
            {
                //la fecha fue menor a el reloj anterior
                arr.Remove(fechaMinima);

                if (arr.Count == 0)
                {
                    //es un cierre
                    return ev.Reloj;
                }
                fechaMinima = arr.Min();

            }


            if (fechaMinima == DateTime.MaxValue) throw new Exception("El reloj no deberia tener una fecha maxima...");
            if (fechaMinima == DateTime.MinValue) throw new Exception("El reloj no deberia tener una fecha minima...");

            return fechaMinima;
        }
    }
}
