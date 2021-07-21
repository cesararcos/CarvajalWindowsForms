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
    public partial class GestionarVuelos : Form
    {
        public static Boolean guardadoCorrecto = false;
        public static Boolean llenadoVuelos = false;
        Angv angv = new Angv();

        public GestionarVuelos()
        {
            InitializeComponent();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarRequeridos())
                {
                    return;
                }

                ValidarDiligenciados();

                if (txtCiudadOrigen.Text.Trim().Length > 0)
                {
                    if (angv.GuardarLocacion(txtCiudadOrigen.Text))
                        guardadoCorrecto = true;
                }
                if (txtHora.Text.Trim().Length > 0)
                {
                    if (angv.GuardarHora(txtHora.Text))
                        guardadoCorrecto = true;
                }
                if (txtEstado.Text.Trim().Length > 0)
                {
                    if (angv.GuardarEstadoVuelo(txtEstado.Text))
                        guardadoCorrecto = true;
                }
                if (llenadoVuelos)
                {
                    if (angv.GuardarVuelos(txtNVuelo.Text, txtAerolinea.Text))
                        guardadoCorrecto = true;
                }

                if (guardadoCorrecto)
                {
                    MessageBox.Show("Se guardaron registros correctamente", "Carvajal tecnologia y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("No se guardo ningun registro", "Carvajal tecnologia y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error inesperado: " + ex, "Carvajal tecnologia y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private Boolean ValidarRequeridos()
        {
            if ((!string.IsNullOrEmpty(txtNVuelo.Text) && string.IsNullOrEmpty(txtAerolinea.Text)) ||
                (string.IsNullOrEmpty(txtNVuelo.Text) && !string.IsNullOrEmpty(txtAerolinea.Text)))
            {
                MessageBox.Show("Verifique el grupo Vuelos que todos los campos esten bien diligenciados", "Carvajal tecnologia y servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ValidarDiligenciados()
        {
            if ((!string.IsNullOrEmpty(txtNVuelo.Text) && !string.IsNullOrEmpty(txtAerolinea.Text) ))
            {
                llenadoVuelos = true;
            }
        }

        private void toolStripLimpiar_Click(object sender, EventArgs e)
        {
            txtCiudadOrigen.Clear();
            txtHora.Clear();
            txtEstado.Clear();
            txtNVuelo.Clear();
            txtAerolinea.Clear();
        }
    }
}
