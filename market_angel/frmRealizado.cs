using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_angel
{
    public partial class frmRealizado : Form
    {
        string mensaje;
        public frmRealizado(string mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
        }

        private void frmRealizado_Load(object sender, EventArgs e)
        {
            lbMensaje.Text = mensaje;
        }

        private void buniAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
