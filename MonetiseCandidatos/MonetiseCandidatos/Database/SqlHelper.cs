using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetiseCandidatos.Database
{
    public class SqlHelper
    {
        public void abrirConexao(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void fecharConexao(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader retornaDataReader(string comando, SqlConnection con)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand(comando, con);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable retornaDataTable(string comando, SqlConnection con)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(comando, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet retornaDataSet(string comando, SqlConnection con)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(comando, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void executarComando(string comando, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int executarComandoRetorno(string comando, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
