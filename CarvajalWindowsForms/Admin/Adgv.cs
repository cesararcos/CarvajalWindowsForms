using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.Admin
{
    class Adgv : ClsConexionDB
    {
        public Boolean GuardarLocacion(string origen)
        {
            DataTable dtDatos;
            try
            {
                this.abrirConexion();
                dtDatos = new DataTable();
                String sqlConsulta = "pa_GuardarLocacion";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@Ciudad", origen);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos);
                this.commit();
                this.cerrarConexion();
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }

            return true;
        }

        public Boolean GuardarHora(string hora)
        {
            DataTable dtDatos;
            try
            {
                this.abrirConexion();
                dtDatos = new DataTable();
                String sqlConsulta = "pa_GuardarHora";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@Hora", hora);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos);
                this.commit();
                this.cerrarConexion();
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }

            return true;
        }

        public Boolean GuardarEstadoVuelo(string estado)
        {
            DataTable dtDatos;
            try
            {
                this.abrirConexion();
                dtDatos = new DataTable();
                String sqlConsulta = "pa_GuardarEstadoVuelo";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@Estado", estado);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos);
                this.commit();
                this.cerrarConexion();
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }

            return true;
        }

        public Boolean GuardarVuelos(string nVuelo, string aerolinea)
        {
            DataTable dtDatos;
            try
            {
                this.abrirConexion();
                dtDatos = new DataTable();
                String sqlConsulta = "pa_GuardarVuelos";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@NVuelo", nVuelo);
                daEnlace.SelectCommand.Parameters.AddWithValue("@Aerolinea", aerolinea);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos);
                this.commit();
                this.cerrarConexion();
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }

            return true;
        }

        public DataTable ListarLocacion()
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ListarLocacion";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "ListarLocacion");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["ListarLocacion"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }
        }

        public DataTable ListarHorarios()
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ListarHorarios";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "ListarHorarios");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["ListarHorarios"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }
        }

        public DataTable ListarEstado()
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ListarEstado";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "ListarEstado");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["ListarEstado"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }
        }

        public DataTable ListarDetalleVuelo()
        {
            try
            {
                this.abrirConexion();
                DataSet dtDatos = new DataSet();
                String sqlConsulta = "Pa_ListarDetalleVuelo";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos, "ListarDetalleVuelo");
                this.commit();
                this.cerrarConexion();
                return dtDatos.Tables["ListarDetalleVuelo"];
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }
        }

        public Boolean GuardarDetalleVuelos(string origen, string destino, DateTime fecha, string horaSalida, string horaLlegada, string detalleVuelo, string estado)
        {
            DataTable dtDatos;
            try
            {
                this.abrirConexion();
                dtDatos = new DataTable();
                String sqlConsulta = "pa_GuardarDetalleVuelos";
                SqlDataAdapter daEnlace = new SqlDataAdapter(sqlConsulta, this.conexion);
                daEnlace.SelectCommand.CommandType = CommandType.StoredProcedure;
                daEnlace.SelectCommand.Parameters.AddWithValue("@IdOrigen", origen);
                daEnlace.SelectCommand.Parameters.AddWithValue("@IdDestino", destino);
                daEnlace.SelectCommand.Parameters.AddWithValue("@Fecha", fecha);
                daEnlace.SelectCommand.Parameters.AddWithValue("@IdhSalida", horaSalida);
                daEnlace.SelectCommand.Parameters.AddWithValue("@IdhLlegada", horaLlegada);
                daEnlace.SelectCommand.Parameters.AddWithValue("@IdDetalleVuelo", detalleVuelo);
                daEnlace.SelectCommand.Parameters.AddWithValue("@IdEstadoVuelo", estado);

                daEnlace.SelectCommand.Transaction = this.getTransaccion();
                daEnlace.SelectCommand.CommandTimeout = 0;
                daEnlace.Fill(dtDatos);
                this.commit();
                this.cerrarConexion();
            }
            catch (SystemException ex)
            {
                throw new SystemException("Error: " + ex.Message.ToString());
            }

            return true;
        }

    }
}
