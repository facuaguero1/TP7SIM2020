using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using TP7SIM.Logica.Helper;

namespace TP7SIM
{
    public partial class Frm_EcDif : Form
    {
        public double h;

        public Frm_EcDif()
        {
            InitializeComponent();
        }

        private void Frm_EcuacionDiferencial_Load(object sender, EventArgs e)
        {
            txt_h.Text = MySettings.HEcDifSecado.ToString();
        }


        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            btn_Graficar.Enabled = true;
            h = Convert.ToDouble(txt_h.Text, CultureInfo.InvariantCulture);

            dgv_Euler.Rows.Clear();
            // Vector de doble estado
            double[] anterior = new double[3];
            double[] actual = new double[3];

            // Condiciones Iniciales
            
            var t = 0.00;
            var H = 100;

            // Seteo de condiciones inciiales en el primer vector
            anterior[0] = Math.Round(t, 4);
            anterior[1] = H;
            anterior[2] = Math.Round(-5*Math.Pow(t,2)+2*H-200, 4);

            // Calculo...
            while (anterior[1] != 0)
            {
                actual = new double[3];
                dgv_Euler.Rows.Add(anterior[0].ToString(), anterior[1].ToString(), anterior[2].ToString());

                actual[0] = Math.Round(anterior[0] + h, 4);
                actual[1] = Math.Round(anterior[1] + (anterior[2] * h), 4);
                actual[2] = Math.Round(-5 * Math.Pow(actual[0], 2) + 2 * actual[1] - 200, 4);

                if (actual[1] <= 0) actual[1] = 0;

                anterior = actual;
            }

            dgv_Euler.Rows.Add(anterior[0].ToString(), anterior[1].ToString(), anterior[2].ToString());

            
            lbl_Result.Text = Math.Round((anterior[0]), 4).ToString();

        }
        
        private void btn_Graficar_Click(object sender, EventArgs e)
        {
            Grafico Grafico = new Grafico(dgv_Euler);
            Grafico.Show();
        }
    }
}
