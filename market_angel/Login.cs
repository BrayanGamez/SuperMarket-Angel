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
        SqlConnection cn;
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

        private bool VerificarDatos(string User, string Password)
        {
            if (User==string.Empty || Password==string.Empty)
            {
                MessageBox.Show("Usuario u Contraseña Vacios, llenelos");
            }
            string strSQL = "Select  COUNT (*) from Usuario where Nombre=@User and Contraseña =@Password";
            DB = new DataBase("localhost", "Supermercado_Angel","sa","123456");
            int flag = 0;
            bool status = false;
            cn=DB.SqlConection;
            using (SqlCommand command = new SqlCommand(strSQL,cn))
            {
                command.Parameters.AddWithValue("@User",User);
                command.Parameters.AddWithValue("@password",Password);
                flag = (int)command.ExecuteScalar();
            }
            if (flag==1)
            {
                status = true;   
            }
            return status;
        }

        private DataSet getUserInformation(string User,string Password)
        {
            DataTable UserTable = new DataTable("UserTable");
            SqlDataAdapter Adapter;
            DataSet DataSet = new DataSet();
            string strSQL = "Select * from Usuario Where Nombre=@User and Contraseña=@Password";
            cn = DB.SqlConection;
            using (SqlCommand command = new SqlCommand(strSQL,cn))
            {
                command.Parameters.AddWithValue("@User",User);
                command.Parameters.AddWithValue("@Password", Password);
                Adapter = new SqlDataAdapter(command);
                Adapter.Fill(UserTable);
                DataSet.Tables.Add(UserTable);
            }
            return DataSet;
        }

        private void ptxButton_Click(object sender, EventArgs e)
        {
            if (VerificarDatos(txtUser.Text,txtPassword.Text))
            {
                DataSet UserDataSet = getUserInformation(txtUser.Text, txtPassword.Text);
                ptxUserPhoto FormWrapper = new ptxUserPhoto(DB,UserDataSet);
                FormWrapper.Show();
                this.Close();
            }
        }

    }
}
