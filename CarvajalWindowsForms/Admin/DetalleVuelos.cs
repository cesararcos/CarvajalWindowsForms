using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvajalWindowsForms.Admin
{
    public partial class DetalleVuelos : Form
    {
        Angv angv = new Angv();

        public DetalleVuelos()
        {
            InitializeComponent();
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            DataTable dtLocacion = angv.ListarLocacion();
            DataTable dtLocacion2 = angv.ListarLocacion();
            DataTable dtHorarios = angv.ListarHorarios();
            DataTable dtHorarios2 = angv.ListarHorarios();
            DataTable dtEstado = angv.ListarEstado();
            DataTable dtDetalleVuelo = angv.ListarDetalleVuelo();

            if (dtLocacion.Rows.Count > 0)
            {
                cboOrigen.DataSource = dtLocacion;
                cboOrigen.ValueMember = "Id";
                cboOrigen.DisplayMember = "Descripcion";
                cboOrigen.SelectedIndex = -1;

                cboDestino.DataSource = dtLocacion2;
                cboDestino.ValueMember = "Id";
                cboDestino.DisplayMember = "Descripcion";
                cboDestino.SelectedIndex = -1;
            }

            if (dtHorarios.Rows.Count > 0)
            {
                cboHoraSalida.DataSource = dtHorarios;
                cboHoraSalida.ValueMember = "Id";
                cboHoraSalida.DisplayMember = "Descripcion";
                cboHoraSalida.SelectedIndex = -1;

                cboHoraLlegada.DataSource = dtHorarios2;
                cboHoraLlegada.ValueMember = "Id";
                cboHoraLlegada.DisplayMember = "Descripcion";
                cboHoraLlegada.SelectedIndex = -1;
            }

            if (dtEstado.Rows.Count > 0)
            {
                cboEstado.DataSource = dtEstado;
                cboEstado.ValueMember = "Id";
                cboEstado.DisplayMember = "Descripcion";
                cboEstado.SelectedIndex = -1;
            }

            if (dtDetalleVuelo.Rows.Count > 0)
            {
                cboDetalleVuelo.DataSource = dtDetalleVuelo;
                cboDetalleVuelo.ValueMember = "Id";
                cboDetalleVuelo.DisplayMember = "Descripcion";
                cboDetalleVuelo.SelectedIndex = -1;
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (cboOrigen.SelectedIndex >= 0 && cboDestino.SelectedIndex >= 0 && cboHoraSalida.SelectedIndex >= 0 &&
                cboHoraLlegada.SelectedIndex >= 0 && cboDetalleVuelo.SelectedIndex >= 0 && cboEstado.SelectedIndex >= 0)
            {
                if (angv.GuardarDetalleVuelos(cboOrigen.SelectedValue.ToString(), cboDestino.SelectedValue.ToString(), DTPFecha.Value, cboHoraSalida.SelectedValue.ToString(),
                    cboHoraLlegada.SelectedValue.ToString(), cboDetalleVuelo.SelectedValue.ToString(), cboEstado.SelectedValue.ToString()))
                {
                    MessageBox.Show("Registros almacenados correctamente", "Carvajal tecnologia y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Verifique que todos los campos esten bien diligenciados", "Carvajal tecnologia y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void toolStripLimpiar_Click(object sender, EventArgs e)
        {
            cboOrigen.SelectedIndex = -1;
            cboDestino.SelectedIndex = -1;
            cboHoraSalida.SelectedIndex = -1;
            cboHoraLlegada.SelectedIndex = -1;
            cboDetalleVuelo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
        }
    }
}
