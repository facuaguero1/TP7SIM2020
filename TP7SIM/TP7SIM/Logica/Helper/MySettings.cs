using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7SIM.Logica.Helper
{
    class MySettings
    {
        //Horario de inicio de la simulacion
        public static DateTime HorarioInicio => DateTime.Parse("11/11/2020 00:00");

        //Cantidad maxima de clientes
        public static int CantMaxClientes { get; set; }

        //Minutos por llegada de cliente
        public static double MediaLlegadas { get; set; }


        //Tiempos de cada area

        public static double TiempoQuitarAlfombras { get; set; }

        public static double TiempoAreaAspiradoUniformeA { get; set; }

        public static double TiempoAreaAspiradoUniformeB { get; set; }

        public static double TiempoLavadoUniformeA { get; set; }

        public static double TiempoLavadoUniformeB { get; set; }

        public static double TiempoPonerAlfombras { get; set; }

        //Paso de la ecuacion diferencial para el tiempo de secado
        public static double HEcDifSecado { get; set; }

        public static class Distribuciones
        {
            public static class Uniforme
            {
                public static double a { get; set; }
                public static double b { get; set; }

                public static double Calcular()
                {
                    var prob = Simulador.Generador.NextDouble();
                    return a + prob * (b - a);
                }
            }


            public static class Exponencial
            {
                public static double Calcular(double media)
                {
                    var prob = Simulador.Generador.NextDouble();
                    return -media * Math.Log(1 - prob);
                }
            }

        }
        public static TimeSpan RoundTimeSpan(int precision, TimeSpan ts)
        {
            const int timespan_size = 7;
            int factor = (int)Math.Pow(10, (timespan_size - precision));

            TimeSpan roundedTimeSpan =
                new TimeSpan(((long)Math.Round((1.0 * ts.Ticks / factor)) * factor));

            return roundedTimeSpan;
        }
    }
}
