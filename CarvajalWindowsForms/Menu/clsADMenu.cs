using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.Menu
{
    class clsADMenu : ClsConexionDB
    {
        public DataTable ValidaPermisoUsuario(string login)
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "pa_ValidaPermisosUsuario";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@usu_login", login);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "UsuariosMenus");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["UsuariosMenus"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());

            }
        }
    }
}
