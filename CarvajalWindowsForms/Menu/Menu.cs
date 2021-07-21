using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvajalWindowsForms.Menu
{
    public partial class Menu : Form
    {
        clsANMenu clsANMen = new clsANMenu();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable dtMenuUsuario = clsANMen.ValidaPermisoUsuario(global::CarvajalWindowsForms.Properties.Settings.Default.Usuario);

            if (dtMenuUsuario.Rows.Count > 0)
            {
                ActivarMenu(dtMenuUsuario);
            }
            else
            {
                MessageBox.Show("No se le han creado Opciones de menu a este Usuario : " + global::CarvajalWindowsForms.Properties.Settings.Default.Usuario, "Carvajal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActivarMenu(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Boolean.Parse(dt.Rows[i]["Permiso"].ToString()))
                    {
                        switch (dt.Rows[i]["MenuRaiz"].ToString())
                        {
                            case "AdministradorVuelos":
                                administradorVuelosToolStripMenuItem.Visible = true;
                                break;
                            case "VerVuelos":
                                verVuelosToolStripMenuItem.Visible = true;
                                break;
                        }
                    }
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Boolean.Parse(dt.Rows[i]["Permiso"].ToString()))
                    {
                        string codMenu = dt.Rows[i]["CodMenu"].ToString();
                        RecorreTodosStrip(codMenu);
                    }

                }
            }
        }

        private void AbreFormHijo(Form frm, string Titulo)
        {
            Boolean abierto = false;
            int n = 0;
            Form[] frms = new Form[this.MdiChildren.Length];
            frms = this.MdiChildren;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (string.IsNullOrEmpty(Titulo))
                {
                    if (frms[i].Name == frm.Name)
                    {
                        abierto = true;
                        n = i;
                    }
                }
                else
                {
                    if (frms[i].Name == frm.Name && frms[i].Text.Trim() == Titulo)
                    {
                        abierto = true;
                        n = i;
                    }
                }
            }
            if (abierto)
            {
                frms[n].Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void RecorreTodosStrip(string CodMenu)
        {
            if (gestionarVuelosToolStripMenuItem.Tag.ToString() == CodMenu.Trim())
            {
                gestionarVuelosToolStripMenuItem.Visible = true;
            }
            if (consultarVuelosToolStripMenuItem.Tag.ToString() == CodMenu.Trim())
            {
                consultarVuelosToolStripMenuItem.Visible = true;
            }
            if (detallesVuelosToolStripMenuItem.Tag.ToString() == CodMenu.Trim())
            {
                detallesVuelosToolStripMenuItem.Visible = true;
            }
        }

        private void gestionarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.GestionarVuelos forma = new Admin.GestionarVuelos();
            AbreFormHijo(forma, "");
        }

        private void consultarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserClient.ConsultarVuelos forma = new UserClient.ConsultarVuelos();
            AbreFormHijo(forma, "");
        }

        

        private void detallesVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.DetalleVuelos forma = new Admin.DetalleVuelos();
            AbreFormHijo(forma, "");
        }
    }
}
