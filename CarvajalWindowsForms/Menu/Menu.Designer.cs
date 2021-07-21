
namespace CarvajalWindowsForms.Menu
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorVuelosToolStripMenuItem,
            this.verVuelosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorVuelosToolStripMenuItem
            // 
            this.administradorVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarVuelosToolStripMenuItem,
            this.detallesVuelosToolStripMenuItem});
            this.administradorVuelosToolStripMenuItem.Name = "administradorVuelosToolStripMenuItem";
            this.administradorVuelosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.administradorVuelosToolStripMenuItem.Text = "Administrador vuelos";
            this.administradorVuelosToolStripMenuItem.Visible = false;
            // 
            // gestionarVuelosToolStripMenuItem
            // 
            this.gestionarVuelosToolStripMenuItem.Name = "gestionarVuelosToolStripMenuItem";
            this.gestionarVuelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarVuelosToolStripMenuItem.Tag = "M001";
            this.gestionarVuelosToolStripMenuItem.Text = "Gestionar vuelos";
            this.gestionarVuelosToolStripMenuItem.Visible = false;
            this.gestionarVuelosToolStripMenuItem.Click += new System.EventHandler(this.gestionarVuelosToolStripMenuItem_Click);
            // 
            // detallesVuelosToolStripMenuItem
            // 
            this.detallesVuelosToolStripMenuItem.Name = "detallesVuelosToolStripMenuItem";
            this.detallesVuelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detallesVuelosToolStripMenuItem.Tag = "M010";
            this.detallesVuelosToolStripMenuItem.Text = "Detalles vuelos";
            this.detallesVuelosToolStripMenuItem.Visible = false;
            this.detallesVuelosToolStripMenuItem.Click += new System.EventHandler(this.detallesVuelosToolStripMenuItem_Click);
            // 
            // verVuelosToolStripMenuItem
            // 
            this.verVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarVuelosToolStripMenuItem});
            this.verVuelosToolStripMenuItem.Name = "verVuelosToolStripMenuItem";
            this.verVuelosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.verVuelosToolStripMenuItem.Text = "Ver vuelos";
            this.verVuelosToolStripMenuItem.Visible = false;
            // 
            // consultarVuelosToolStripMenuItem
            // 
            this.consultarVuelosToolStripMenuItem.Name = "consultarVuelosToolStripMenuItem";
            this.consultarVuelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarVuelosToolStripMenuItem.Tag = "M002";
            this.consultarVuelosToolStripMenuItem.Text = "Consultar vuelos";
            this.consultarVuelosToolStripMenuItem.Visible = false;
            this.consultarVuelosToolStripMenuItem.Click += new System.EventHandler(this.consultarVuelosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CarvajalWindowsForms.Properties.Resources.carvajal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 649);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tu Aerolinea";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesVuelosToolStripMenuItem;
    }
}