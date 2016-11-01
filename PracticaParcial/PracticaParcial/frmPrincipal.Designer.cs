namespace PracticaParcial
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCboOrdenar = new System.Windows.Forms.ToolStripComboBox();
            this.lstMacotas = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlta,
            this.menuBaja,
            this.menuModificar,
            this.menuSalir,
            this.menuCboOrdenar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAlta
            // 
            this.menuAlta.Name = "menuAlta";
            this.menuAlta.Size = new System.Drawing.Size(40, 23);
            this.menuAlta.Text = "Alta";
            this.menuAlta.Click += new System.EventHandler(this.menuAlta_Click);
            // 
            // menuBaja
            // 
            this.menuBaja.Name = "menuBaja";
            this.menuBaja.Size = new System.Drawing.Size(41, 23);
            this.menuBaja.Text = "Baja";
            // 
            // menuModificar
            // 
            this.menuModificar.Name = "menuModificar";
            this.menuModificar.Size = new System.Drawing.Size(70, 23);
            this.menuModificar.Text = "Modificar";
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(41, 23);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuCboOrdenar
            // 
            this.menuCboOrdenar.Name = "menuCboOrdenar";
            this.menuCboOrdenar.Size = new System.Drawing.Size(121, 23);
            this.menuCboOrdenar.SelectedIndexChanged += new System.EventHandler(this.menuCboOrdenar_SelectedIndexChanged);
            // 
            // lstMacotas
            // 
            this.lstMacotas.FormattingEnabled = true;
            this.lstMacotas.Location = new System.Drawing.Point(12, 30);
            this.lstMacotas.Name = "lstMacotas";
            this.lstMacotas.Size = new System.Drawing.Size(538, 342);
            this.lstMacotas.TabIndex = 1;
            this.lstMacotas.SelectedIndexChanged += new System.EventHandler(this.lstMacotas_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 379);
            this.Controls.Add(this.lstMacotas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "AMB Mascota";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAlta;
        private System.Windows.Forms.ToolStripMenuItem menuBaja;
        private System.Windows.Forms.ToolStripMenuItem menuModificar;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripComboBox menuCboOrdenar;
        private System.Windows.Forms.ListBox lstMacotas;
    }
}

