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
        private Form privateForm = null;
       public int id_user;
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
            lbUserNameSesion.Text = Row["Nombre"].ToString();
            ptxUserPhotoSesion.Image = InversoImg((byte[])Row["Foto"]);
            id_user = (int)Row["id_usuario"];
            loadPanelWrapperForms(new DashBoard());
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

        private void followArow(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            Arrow.Top = sender.Top;
        }

        private void updateControlColor(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnCart.Textcolor = Color.White;
            btnDash.Textcolor = Color.White;
            btnProducts.Textcolor = Color.White;
            btnSales.Textcolor = Color.White;
            btnProvider.Textcolor = Color.White;
            btnClient.Textcolor = Color.White;
            btnPlus.Textcolor = Color.White;

            sender.selected = true;
            if (sender.selected)
            {
                sender.Textcolor = Color.Black;
            }
        }

        private void loadPanelWrapperForms(Form childForm)
        {
            if (privateForm != null)
                privateForm.Close();
            privateForm = childForm;
            privateForm.TopLevel = false;
            privateForm.Dock = DockStyle.Fill;
            PanelWrapper.Controls.Add(privateForm);
            PanelWrapper.Tag = privateForm;
            privateForm.BringToFront();
            privateForm.Show();
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
                    Application.Exit();
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

        private void btnDash_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            loadPanelWrapperForms(new DashBoard());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            loadPanelWrapperForms(new frmProducts(DB));
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            followArow((Bunifu.Framework.UI.BunifuFlatButton)sender);
            updateControlColor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void photoHover_Click(object sender, EventArgs e)
        {

        }

        private void photoHover_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void photoHover_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnPhotoNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog frmOpen = new OpenFileDialog();
            DialogResult result = new DialogResult();
            result = frmOpen.ShowDialog();
            if (result==DialogResult.OK)
            {
                ptxUserPhotoSesion.Image = Image.FromFile(frmOpen.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ptxUserPhotoSesion.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);

                try
                {
                    string strQuery = $"update Usuario set Foto=@photo where id_usuario=@id_u";
                    SqlConnection cn = DB.SqlConection;
                    SqlCommand comando = new SqlCommand(strQuery,cn);
                    comando.Parameters.AddWithValue("@photo",ms.GetBuffer());
                    comando.Parameters.AddWithValue("@id_u",id_user);
                    comando.ExecuteNonQuery();
                    frmRealizado Checked = new frmRealizado("Foto Actualizada");
                    DialogResult r = new DialogResult();
                    r = Checked.ShowDialog();
                    if (r==DialogResult.OK)
                    {
                        Checked.Close();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Nose pudo cargar la imagen","Error al cargar foto a la BD",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
