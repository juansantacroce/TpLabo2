using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLabo2
{
    public partial class Frm_Ventas_Sustanciales : Form
    {
        public Frm_Ventas_Sustanciales()
        {
            InitializeComponent();
        }

        private void Frm_Ventas_Sustanciales_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtMonto.Text = string.Empty;
            dtpFechaDesde.Value= DateTime.Now;
            dtoFechaHasta.Value= DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
