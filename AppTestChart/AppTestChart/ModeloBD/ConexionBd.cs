using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestChart.ModeloBD
{
    class ConexionBd
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        DataTable td = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public ConexionBd(String TablaDB)
        {

            conexion.ConnectionString = "Server=EMX-KNBNM-06;Database=TestData;Trusted_connection=true;User ID=sa;Password=123456";
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
        }
        
        public void setCommand(String Comando){
            comando.CommandText = Comando;
            da.SelectCommand = comando;
        }
        public DataTable Cargar_Data()
        {
            da.Fill(td);
            comando.ExecuteNonQuery();
            conexion.Close();
            return td;
        }
    }
}
