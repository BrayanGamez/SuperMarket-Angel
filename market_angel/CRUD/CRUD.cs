using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace market_angel.CRUD
{
    public partial class CRUD : Form
    {
     
        public CRUD()
        {
            InitializeComponent();
     
        }

        public void dgvCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                frmInformation Info = new frmInformation("Salir");
                DialogResult Result = new DialogResult();
                Result = Info.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    Info.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
