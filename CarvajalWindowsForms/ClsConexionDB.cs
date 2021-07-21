using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace CarvajalWindowsForms
{
    class ClsConexionDB
    {
        private string strConexion;

        protected SqlConnection conexion;
        protected SqlTransaction transaccion;

        public void abrirConexion()
        {
            try
            {
                conexion = new SqlConnection();
                if (strConexion == null)
                {
                    strConexion = CarvajalWindowsForms.Properties.Settings.Default.ConnectionString;
                }

                conexion.ConnectionString = strConexion;
                if (conexion.State.Equals(ConnectionState.Closed))
                {
                    //RemplazarConnectionString();
                    conexion.Open();
                    conexion.CreateCommand().CommandTimeout = 2000;
                    transaccion = conexion.BeginTransaction();
                }


            }
            catch (Exception ex)
            {
                //transaccion.Rollback();
                MessageBox.Show("Ha ocurrido un error en el sistema:\n" + ex.Message + "\n\nError técnico:\n" + ex.InnerException, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public SqlTransaction getTransaccion()
        {
            return this.transaccion;
        }
        public void cerrarConexion()
        {
            if (conexion != null)
            {
                conexion.Dispose();
                conexion.Close();
            }
        }
        public void commit()
        {
            transaccion.Commit();
            transaccion = null;
        }

    }
}
