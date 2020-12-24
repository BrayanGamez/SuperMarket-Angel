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

namespace market_angel
{
    public partial class Login : Form
    {
      static  DataBase DB = new DataBase("localhost", "master", "sa", "123456");
       BunisessDataBase BunisessDB = new BunisessDataBase(DB);
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (DB.testConection("localhost", "master"))
            {
                BunisessDB.CreateDataBase();
            }
            else
            {
                MessageBox.Show("No hay conexion al servidor","Error del Servidor",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
