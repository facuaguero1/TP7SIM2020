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

        //Rango de eventos que se mostrara
        public static int desde { get; set; }

        public static int hasta { get; set; }

        //Tiempos las areas de tiempo constante

        public static double TiempoQuitarAlfombras { get; set; }

        public static double TiempoPonerAlfombras { get; set; }

        //Paso de la ecuacion diferencial para el tiempo de secado
        public static double HEcDifSecado { get; set; }

        public static class Distribuciones
        {
            public static class UniformeAspirado
            {
                public static double a { get; set; }
                public static double b { get; set; }

                public static double Calcular()
                {
                    var prob = Simulador.Generador.NextDouble();
                    return a + prob * (b - a);
                }
            }

            public static class UniformeLavado
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

        public static class EcDiferencial
        {
            
            public static double CalcularCantidadMinutos()
            {
                // Vector de doble estado
                double[] anterior = new double[3];
                double[] actual = new double[3];

                // Condiciones Iniciales
                var t = 0.00;
                var h = MySettings.HEcDifSecado;
                var H = 100;

                // Seteo de condiciones inciiales en el primer vector
                anterior[0] = Math.Round(t, 4);
                anterior[1] = H;
                anterior[2] = Math.Round((-5*Math.Pow(t,2)) + (2*H) - 200, 4);

                // Calculo...
                while (anterior[1] != 0)
                {
                    actual = new double[3];
                    actual[0] = Math.Round(anterior[0] + h, 4);
                    actual[1] = Math.Round(anterior[1] + (anterior[2] * h), 4);
                    actual[2] = Math.Round((-5 * Math.Pow(actual[0], 2)) + (2 * actual[1]) - 200, 4);

                    if (actual[1] <= 0) actual[1] = 0;

                    anterior = actual;
                }

                return anterior[0];
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
