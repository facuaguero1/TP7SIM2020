using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7SIM
{
    public partial class Grafico : Form
    {
        DataGridView DataGrid { set; get; }

        public Grafico(DataGridView DataGrid)
        {
            InitializeComponent();
            this.DataGrid = DataGrid;

            ProcesarDatos();
        }

        private void ProcesarDatos()
        {
            foreach (DataGridViewRow item in DataGrid.Rows)
            {
                var tiempo = Double.Parse(item.Cells[0].Value.ToString());
                var tasaSecado = Double.Parse(item.Cells[1].Value.ToString());

                chart1.Series["Tiempo de secado"].Points.AddXY(tiempo, tasaSecado);
            }
        }
        public Grafico()
        {
            InitializeComponent();
        }
    }
}
