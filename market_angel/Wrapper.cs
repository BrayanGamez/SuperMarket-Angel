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
using System.IO;

namespace market_angel
{
    public partial class ptxUserPhoto : Form
    {
        private DataBase DB;
        private DataSet DataSet;
        public ptxUserPhoto(DataBase Conect,DataSet DataSet)
        {
            InitializeComponent();
            setDB(Conect);
            setDataSet(DataSet);
        }

        private void LoadUser()
        {
            DataSet DS = GetDataSet();
            DataRow Row = DS.Tables["UserTable"].Rows[0];
            txtUserName.Text = Row["Nombre"].ToString();
            ptxUserPhotoImg.Image = InversoImg((byte[])Row["Foto"]);
        }

        public Bitmap InversoImg(byte[] imagen)
        {
            MemoryStream mt = new MemoryStream();
            byte[] img = imagen;
            mt.Write(img, 0, Convert.ToInt32(img.Length));
            Bitmap bm = new Bitmap(mt, false);
            mt.Dispose();
            return bm;
        }

        public void setDB(DataBase DataB)
        {
            DB = DataB;
        }

        public DataBase getDB()
        {
            return DB;
        }

        public void setDataSet(DataSet DS)
        {
            DataSet = DS;
        }

        public DataSet GetDataSet()
        {
            return DataSet;
        }

        private void ptxUserPhoto_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}
