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
using TP7SIM.Logica.Helper;
using TP7SIM.Logica.Eventos;

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
            setearCantidadDeEventos();
            Simulador.Simular(this);
        }

        private void setearCantidadDeEventos()
        {
            MySettings.desde = Convert.ToInt32(txtDesde.Text);
            MySettings.hasta = Convert.ToInt32(txtHasta.Text);
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

        internal void MostrarEnGrilla(Evento e_actual)
        {
            dataGridView1.Rows.Add(
                e_actual.NroEvento, e_actual.Tipo, e_actual.Reloj.ToString("dd/MM - HH:mm:ss"), "",
                e_actual._LLegada.TiempoEntreLlegadas, e_actual._LLegada.FechaProximaLlegada.ToString("HH:mm:ss"), "",
                e_actual._Auto.NroAuto, "",
                e_actual.ColaQuitarAlfombra.Count, e_actual.ColaQuitarAlfombra.ToString(), "",
                e_actual.EmpleadoQA.Estado, e_actual.EmpleadoQA.TiempoDeAtencion, e_actual.EmpleadoQA.FechaProximoFinAtencion, "",
                e_actual.ColaLavado.Count, e_actual.ColaLavado.ToString(), "",
                e_actual.EmpleadoLavado1.Estado, e_actual.EmpleadoLavado1.TiempoDeAtencion, e_actual.EmpleadoLavado1.FechaProximoFinAtencion, "",
                e_actual.EmpleadoLavado2.Estado, e_actual.EmpleadoLavado2.TiempoDeAtencion, e_actual.EmpleadoLavado2.FechaProximoFinAtencion, "",
                e_actual.ColaSecado.Count, e_actual.ColaSecado, "",
                e_actual.EmpleadoSecado.Estado, e_actual.EmpleadoSecado.TiempoDeAtencion, e_actual.EmpleadoSecado.FechaProximoFinAtencion, "",
                e_actual.ColaAspirarAlfombra.Count, e_actual.ColaAspirarAlfombra, "",
                e_actual.EmpleadoAA.Estado, e_actual.EmpleadoAA.TiempoDeAtencion, e_actual.EmpleadoAA.FechaProximoFinAtencion, "",
                e_actual.ColaPonerAlfombra.Count, e_actual.ColaPonerAlfombra, AlfombrasListas.ToString(), "",
                e_actual.EmpleadoPA.Estado, e_actual.EmpleadoPA.TiempoDeAtencion, e_actual.EmpleadoPA.FechaProximoFinAtencion, ""
            );
        }
    }
}
