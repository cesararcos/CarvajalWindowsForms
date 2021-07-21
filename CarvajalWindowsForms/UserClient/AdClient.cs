using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.UserClient
{
    class AdClient : ClsConexionDB
    {
        public DataTable ListarInfoClientxId(string origen, string destino)
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ListarInfoClientxId";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@Origen", origen);
                daEnlace.SelectCommand.Parameters.AddWithValue("@Destino", destino);
                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "ListarInfoClientxId");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["ListarInfoClientxId"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }
        }

        public DataTable ListarInfoClient()
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ListarInfoClient";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "ListarInfoClient");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["ListarInfoClient"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }
        }
    }
}
