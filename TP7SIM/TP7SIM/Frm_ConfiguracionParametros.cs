using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7SIM.Logica.Helper;
using System.Globalization;

namespace TP7SIM
{
    public partial class Frm_ConfiguracionParametros : Form
    {
        public Frm_ConfiguracionParametros()
        {
            InitializeComponent();
        }

        public void SetValoresPorDefecto()
        {
            txtMaxClientes.Text = "10";
            txtMediaLlegadas.Text = "10.00";
            txtQA.Text = "02.00";
            txtAA_A.Text = "03.00";
            txtAA_B.Text = "05.00";
            txtL_A.Text = "06.00";
            txtL_B.Text = "12.00";
            txtPA.Text = "03.00";
            txtHEcDif.Text = "1.00";
        }

        private void btnValoresPorDefecto_Click(object sender, EventArgs e)
        {
            SetValoresPorDefecto();
        }

        internal void btn_ConfirmarParametros_Click(object sender, EventArgs e)
        {
            MySettings.CantMaxClientes = Convert.ToInt32(txtMaxClientes.Text);
            MySettings.MediaLlegadas = double.Parse(txtMediaLlegadas.Text, CultureInfo.InvariantCulture);
            MySettings.TiempoQuitarAlfombras = Convert.ToDouble(txtQA.Text, CultureInfo.InvariantCulture);
            MySettings.Distribuciones.UniformeAspirado.a = Convert.ToDouble(txtAA_A.Text, CultureInfo.InvariantCulture);
            MySettings.Distribuciones.UniformeAspirado.b = Convert.ToDouble(txtAA_B.Text, CultureInfo.InvariantCulture);
            MySettings.Distribuciones.UniformeLavado.a = Convert.ToDouble(txtL_A.Text, CultureInfo.InvariantCulture);
            MySettings.Distribuciones.UniformeLavado.b = Convert.ToDouble(txtL_B.Text, CultureInfo.InvariantCulture);
            MySettings.TiempoPonerAlfombras = Convert.ToDouble(txtPA.Text, CultureInfo.InvariantCulture);
            MySettings.HEcDifSecado = Convert.ToDouble(txtHEcDif.Text, CultureInfo.InvariantCulture);

            this.Close();
        }
    }
}
