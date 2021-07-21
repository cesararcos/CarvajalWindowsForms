using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvajalWindowsForms.Login
{
    public partial class Login : Form
    {
        AnAccesoSistema clsAN = new AnAccesoSistema();


        public Login()
        {
            InitializeComponent();
            //DataTable dtPeriodos = clsANper.ListaPeriodos();
            //cboPeriodo.DataSource = dtPeriodos;
            //cboPeriodo.ValueMember = "Per_Codigo";
            //cboPeriodo.DisplayMember = "Per_Descripcion";
            //cboPeriodo.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                MessageBox.Show("Digite el nombre del usuario", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                MessageBox.Show("Digite la clave del usuario", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClave.Select();
                return;
            }

            DataTable dtUsuario = clsAN.ExisteUsuario(txtUsuario.Text);
            //valida que el nombre y la clave sean totalmente iguales a los que estan en la BD
            if (dtUsuario.Rows.Count > 0)
            {
                string user = dtUsuario.Rows[0]["usu_login"].ToString();
                string pws = dtUsuario.Rows[0]["usu_clave"].ToString();
                if (user.TrimEnd() == txtUsuario.Text & pws.TrimEnd() == txtClave.Text)
                {
                    global::CarvajalWindowsForms.Properties.Settings.Default.Usuario = txtUsuario.Text;
                    CarvajalWindowsForms.Menu.Menu frmmenu = new CarvajalWindowsForms.Menu.Menu();
                    frmmenu.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClave.Text = "";
                    txtClave.Select();
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClave.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            Application.Exit();
        }
    }
}
