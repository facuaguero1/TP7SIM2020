using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7SIM.Logica;

namespace TP7SIM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            var formCfg = new Frm_ConfiguracionParametros();
            formCfg.SetValoresPorDefecto();
            formCfg.btn_ConfirmarParametros_Click(null, null);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            Frm_ConfiguracionParametros form = new Frm_ConfiguracionParametros();
            form.ShowDialog();
        }

        private void btnIniciarSimulacion_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Simulador.Simular(this);
        }

        public void PintarCeldas()
        {

            Color color;
            string tipo = String.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value == null) break;
                tipo = row.Cells[1].Value.ToString();

                switch (tipo)
                {
                    case "LlegadaCliente":
                        color = Color.PapayaWhip;
                        break;
                    case "FinQuitarAlfombras":
                        color = Color.LightSeaGreen;
                        break;
                    case "FinPonerAlfombras":
                        color = Color.Green;
                        break;
                    case "FinLavado1":
                    case "FinLavado2":
                        color = Color.Khaki;
                        break;
                    case "Inicio":
                        color = Color.HotPink;
                        break;

                    default:
                        color = Color.White;
                        break;
                }

                row.DefaultCellStyle.BackColor = color;
            }
        }
    }
}
