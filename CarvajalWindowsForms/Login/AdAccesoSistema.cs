using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.Login
{
    class AdAccesoSistema : ClsConexionDB
    {
        public DataTable ExisteUsuario(string login)
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ExisteUsuario";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@usu_login", login);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "Usuarios");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["Usuarios"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());

            }
        }
    }
}
