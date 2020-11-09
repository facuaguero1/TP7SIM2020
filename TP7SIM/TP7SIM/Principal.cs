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
    public partial class Principal : Form
    {
        public Principal()
        {
            var formCfg = new Frm_ConfiguracionParametros();
            formCfg.SetValoresPorDefecto();
            formCfg.btn_ConfirmarParametros_Click(null, null);
            InitializeComponent();
        }
    }
}
