using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvajalWindowsForms.UserClient
{
    public partial class ConsultarVuelos : Form
    {
        AnClient anClient = new AnClient();

        public ConsultarVuelos()
        {
            InitializeComponent();
            Buscar();
        }

        private void Buscar()
        {
            DataTable dtBusqueda = new DataTable();

            if (txtCiudadOrigen.Text.Trim().Length > 0 && txtCiudadDestino.Text.Trim().Length > 0)
            {
                dtBusqueda = anClient.ListarInfoClientxId(txtCiudadOrigen.Text.Trim(), txtCiudadDestino.Text.Trim());
            }
            else
            {
                dtBusqueda = anClient.ListarInfoClient();
            }
            


            dataGridBuscar.DataSource = dtBusqueda;
            //dataGridBuscar.Columns[2].Visible = false;
            dataGridBuscar.Columns[5].Visible = false;
            dataGridBuscar.Columns[6].Visible = false;
            //dataGridBuscar.Columns[0].Width = 100;
            //dataGridBuscar.Columns[1].Width = 280;
            dataGridBuscar.Columns[0].ReadOnly = true;
            dataGridBuscar.Columns[1].ReadOnly = true;
            dataGridBuscar.Columns[2].ReadOnly = true;
            dataGridBuscar.Columns[3].ReadOnly = true;
            dataGridBuscar.Columns[4].ReadOnly = true;
        }

        private void Aceptar()
        {
            if (dataGridBuscar.Rows.Count > 0)
            {
                 txtDetalle.Text = "El numero de su vuelo es " + dataGridBuscar.CurrentRow.Cells[5].Value.ToString() + " y se encuentra en estado " + dataGridBuscar.CurrentRow.Cells[6].Value.ToString() + " Feliz viaje!";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item", "BGR Technology", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar();
        }

        // Boton gridwiew
        private void button2_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        // Boton filtro
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dataGridBuscar.DataSource = null;
            txtCiudadOrigen.Clear();
            txtCiudadDestino.Clear();
            txtDetalle.Clear();
        }
    }
}
