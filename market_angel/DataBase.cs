using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace market_angel
{
    public class DataBase
    {
        private string strServerName;
        private string strInitialCatalog;
        private string strUserId;
        private string strPassword;
        private SqlConnection sqlConection;
        private SqlCommand sqlCommand=null;

        public DataBase(){}

        public DataBase(string u_strServerName,string u_strInitialCatalog,string u_strUserId,string u_strPassword)
        {
            strServerName = u_strServerName;
            strInitialCatalog = u_strInitialCatalog;
            strUserId = u_strUserId;
            strPassword = u_strPassword;
            createConnection();
        }

        public bool testConection(string u_strServerName, string u_strInitialCatalog)
        {
            bool bReturn = true;
            try
            {
                string strConnection = "Server=" + strServerName + ";Database=" + strInitialCatalog + ";Trusted_Connection=True;";

                SqlConnection conection = new SqlConnection(strConnection);

                conection.Open();
                conection.Close();
            }
            catch 
            {
                bReturn = false;
            }
            return bReturn;
        }

        public void createConnection() //Aca se crea la cadena de coneccion y la coneccion
        {
            String strConnection = null;
            strConnection = "Server=" + strServerName + ";Database=" + strInitialCatalog + ";Trusted_Connection=True;";
            SqlConnection CConnection = new SqlConnection(strConnection);
            CConnection.Open();
            sqlConection = CConnection;
        }

        public void ExecuteQuery(string strQuery)
        {
            SqlConnection Conect = SqlConection;
            SqlCommand Query;

            try
            {
                sqlCommand = new SqlCommand(strQuery, Conect);
                Query = sqlCommand;
                Query.ExecuteNonQuery();

                Query.Dispose();
                sqlCommand = Query;
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Mensaje: " + ex.Errors[i].Message + "\n" +
                        "Numero de Linea: " + ex.Errors[i].LineNumber + "\n" +
                        "Fuente: " + ex.Errors[i].Source + "\n" +
                        "Procedimiento: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString(), "Error del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void closeConection()
        {
            SqlConnection Conect = sqlConection;
            Conect.Close();
            sqlConection = Conect;
        }

        //Setters y Getters
        public string StrServerName
        {
            get
            {
                return strServerName;
            }

            set
            {
                strServerName = value;
            }
        }

        public string StrInitialCatalog
        {
            get
            {
                return strInitialCatalog;
            }

            set
            {
                strInitialCatalog = value;
            }
        }

        public string StrUserId
        {
            get
            {
                return strUserId;
            }

            set
            {
                strUserId = value;
            }
        }

        public string StrPassword
        {
            get
            {
                return strPassword;
            }

            set
            {
                strPassword = value;
            }
        }

        public SqlConnection SqlConection
        {
            get
            {
                return sqlConection;
            }

            set
            {
                sqlConection = value;
            }
        }

        public SqlCommand SqlCommand
        {
            get
            {
                return sqlCommand;
            }

            set
            {
                sqlCommand = value;
            }
        }
    }
}
