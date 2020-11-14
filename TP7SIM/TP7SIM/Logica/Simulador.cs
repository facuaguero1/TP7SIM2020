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
    public class Simulador
    {
        public static Random Generador = new Random();

        public static void Simular(Principal form)
        {
            DateTime relojInicio = MySettings.HorarioInicio;

            var maxEventos = MySettings.CantMaxClientes * 6 ;
            form.progressbar.Maximum = maxEventos;

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
            form.MostrarEnGrilla(e_anterior);

            Console.WriteLine(e_anterior.Tipo + "    " + e_anterior.Reloj + "    ");

            var eventos = 0;
            while (eventos < maxEventos)
            {
                eventos++;
                //Console.WriteLine("Cantidad de eventos: " +  eventos);
                //if(eventos % 500 == 0) System.GC.Collect();
                var e_actual = new Evento(e_anterior);
                e_actual.EventoAnterior = e_anterior;
                //determinamos el nro de evento
                e_actual.NroEvento = e_anterior.NroEvento + 1;

                //determinamos el tipo
                e_actual.Tipo = DeterminarTipoEvento(e_actual);
                //Console.WriteLine(e_actual.Tipo + "    " + e_actual.Reloj + "    ");

                switch (e_actual.Tipo)
                {
                    case Evento.TipoEvento.LlegadaCliente:
                        e_actual.LlegadaCliente_Event();
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
                }
                e_anterior = e_actual;
                form.progressbar.Value = eventos;
                
                if (eventos >= MySettings.desde && eventos <= MySettings.hasta)
                {
                    form.MostrarEnGrilla(e_actual);
                }
            }
            form.PintarCeldas();
            Console.WriteLine("Longitud hashtable: " + e_anterior.ColaAlfombrasListas.Count);
        }

        private static Evento.TipoEvento DeterminarTipoEvento(Evento evActual)
        {
            var evAnterior = evActual.EventoAnterior;
            var earliest = evActual.Reloj;//la fecha determinada por el metodo anterior
          

            int iteracion = 0;
            /*while (true)
            {*/
                evActual.Reloj = earliest = DeterminarTiempoReloj(evActual);
            //Console.WriteLine("Earliest" + earliest);
            if (evAnterior._LLegada.FechaProximaLlegada == earliest) return Evento.TipoEvento.LlegadaCliente;
            if (evAnterior.EmpleadoQA.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinQuitarAlfombras;
            if (evAnterior.EmpleadoLavado1.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinLavado1;
            if (evAnterior.EmpleadoLavado2.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinLavado2;
            if (evAnterior.EmpleadoSecado.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinSecado;
            if (evAnterior.EmpleadoAA.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinAspirado;
            if (evAnterior.EmpleadoPA.FechaProximoFinAtencion == earliest) return Evento.TipoEvento.FinPonerAlfombras;

            //Console.Write("");
            //}
     
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
            var arr2 = new List<DateTime>();
            
            /*for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("---- " + arr[i]);
            }*/

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != DateTime.MinValue) arr2.Add(arr[i]);
            }

            var fechaMinima = arr2.Min();
            /*
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
            if (fechaMinima == DateTime.MinValue) throw new Exception("El reloj no deberia tener una fecha minima...");*/

            return fechaMinima;
        }
    }
} 
