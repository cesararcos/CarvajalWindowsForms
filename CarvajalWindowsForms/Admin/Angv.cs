using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.Admin
{
    class Angv
    {
        Adgv adgv = new Adgv();

        public Boolean GuardarLocacion(string origen)
        {
            return adgv.GuardarLocacion(origen);
        }

        public Boolean GuardarHora(string hora)
        {
            return adgv.GuardarHora(hora);
        }

        public Boolean GuardarEstadoVuelo(string estado)
        {
            return adgv.GuardarEstadoVuelo(estado);
        }

        public Boolean GuardarVuelos(string nVuelo, string aerolinea)
        {
            return adgv.GuardarVuelos(nVuelo, aerolinea);
        }

        public DataTable ListarLocacion()
        {
            return adgv.ListarLocacion();
        }

        public DataTable ListarHorarios()
        {
            return adgv.ListarHorarios();
        }

        public DataTable ListarEstado()
        {
            return adgv.ListarEstado();
        }

        public DataTable ListarDetalleVuelo()
        {
            return adgv.ListarDetalleVuelo();
        }

        public Boolean GuardarDetalleVuelos(string origen, string destino, DateTime fecha, string horaSalida, string horaLlegada, string detalleVuelo, string estado)
        {
            return adgv.GuardarDetalleVuelos(origen, destino, fecha, horaSalida, horaLlegada, detalleVuelo, estado);
        }

    }
}
