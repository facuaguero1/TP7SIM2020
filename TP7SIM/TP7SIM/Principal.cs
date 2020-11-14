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
using TP7SIM.Logica.Autos;

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
                ta(e_actual._LLegada.TiempoEntreLlegadas), e_actual._LLegada.FechaProximaLlegada.ToString("dd/MM - HH:mm:ss"), "",
                e_actual._Auto.NroAuto, "",
                e_actual.ColaQuitarAlfombra.Count, printCola(e_actual.ColaQuitarAlfombra), "",
                e_actual.EmpleadoQA.Estado, s(e_actual.EmpleadoQA.AutoActual), ta(e_actual.EmpleadoQA.TiempoDeAtencion), date(e_actual.EmpleadoQA.FechaProximoFinAtencion), "",
                e_actual.ColaLavado.Count, printCola(e_actual.ColaLavado), "",
                e_actual.EmpleadoLavado1.Estado, s(e_actual.EmpleadoLavado1.AutoActual), ta(e_actual.EmpleadoLavado1.TiempoDeAtencion), date(e_actual.EmpleadoLavado1.FechaProximoFinAtencion), "",
                e_actual.EmpleadoLavado2.Estado, s(e_actual.EmpleadoLavado2.AutoActual), ta(e_actual.EmpleadoLavado2.TiempoDeAtencion), date(e_actual.EmpleadoLavado2.FechaProximoFinAtencion), "",
                e_actual.ColaSecado.Count, printCola(e_actual.ColaSecado) , "",
                e_actual.EmpleadoSecado.Estado, s(e_actual.EmpleadoSecado.AutoActual), ta(e_actual.EmpleadoSecado.TiempoDeAtencion), date(e_actual.EmpleadoSecado.FechaProximoFinAtencion), "",
                e_actual.ColaAspirarAlfombra.Count, printCola(e_actual.ColaAspirarAlfombra), "",
                e_actual.EmpleadoAA.Estado, s(e_actual.EmpleadoAA.AlfombraActual), ta(e_actual.EmpleadoAA.TiempoDeAtencion), date(e_actual.EmpleadoAA.FechaProximoFinAtencion), "",
                e_actual.ColaPonerAlfombra.Count, printCola(e_actual.ColaPonerAlfombra), AlfombrasListas.ToString(), "",
                e_actual.EmpleadoPA.Estado, s(e_actual.EmpleadoPA.AutoActual), ta(e_actual.EmpleadoPA.TiempoDeAtencion), date(e_actual.EmpleadoPA.FechaProximoFinAtencion), ""
            );
        }

    
        private static string date(DateTime d)
        {
            if (d == DateTime.MinValue) return "-";
            else return d.ToString();
        }

        private static string ta(TimeSpan t)
        {
            if (t == TimeSpan.Zero) return "-";
            else return t.ToString();
        }

        private static string s(Auto a)
        {
            if (a != null) return a.NroAuto.ToString();
            else return "-";
        }

        private static string s(Alfombra a)
        {
            if (a != null) return a.nroAuto.ToString();
            else return "-";
        }

        private static string printCola(List<Auto> autos)
        {
            string salida = "-";

            if (autos.Count == 0)
            {
                return salida;
            }

            foreach (Auto auto in autos)
            {
                if (auto != null)
                {
                    salida += auto.NroAuto.ToString() + "-";
                }

            }

            return salida;
        }

        private static string printCola(List<Alfombra> alfs)
        {
            string salida = "-";

            if (alfs.Count == 0)
            {
                return salida;
            }

            foreach (Alfombra alf in alfs)
            {
                if (alf != null)
                {
                    salida += alf.nroAuto.ToString() + "-";
                }

            }

            return salida;
        }

    }
}
