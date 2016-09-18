namespace Aplicacion._09
{
    partial class frmGestionAutomovil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAutomovil));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nuevoVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidAdmDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVehiculoToolStripMenuItem,
            this.borrarVehiculoToolStripMenuItem,
            this.modificarVehiculoToolStripMenuItem,
            this.salidAdmDeVehiculosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // nuevoVehiculoToolStripMenuItem
            // 
            this.nuevoVehiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem,
            this.motoToolStripMenuItem,
            this.camionToolStripMenuItem});
            this.nuevoVehiculoToolStripMenuItem.Name = "nuevoVehiculoToolStripMenuItem";
            resources.ApplyResources(this.nuevoVehiculoToolStripMenuItem, "nuevoVehiculoToolStripMenuItem");
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            resources.ApplyResources(this.autoToolStripMenuItem, "autoToolStripMenuItem");
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // motoToolStripMenuItem
            // 
            this.motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            resources.ApplyResources(this.motoToolStripMenuItem, "motoToolStripMenuItem");
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            resources.ApplyResources(this.camionToolStripMenuItem, "camionToolStripMenuItem");
            // 
            // borrarVehiculoToolStripMenuItem
            // 
            this.borrarVehiculoToolStripMenuItem.Name = "borrarVehiculoToolStripMenuItem";
            resources.ApplyResources(this.borrarVehiculoToolStripMenuItem, "borrarVehiculoToolStripMenuItem");
            // 
            // modificarVehiculoToolStripMenuItem
            // 
            this.modificarVehiculoToolStripMenuItem.Name = "modificarVehiculoToolStripMenuItem";
            resources.ApplyResources(this.modificarVehiculoToolStripMenuItem, "modificarVehiculoToolStripMenuItem");
            // 
            // salidAdmDeVehiculosToolStripMenuItem
            // 
            this.salidAdmDeVehiculosToolStripMenuItem.Name = "salidAdmDeVehiculosToolStripMenuItem";
            resources.ApplyResources(this.salidAdmDeVehiculosToolStripMenuItem, "salidAdmDeVehiculosToolStripMenuItem");
            this.salidAdmDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.salidAdmDeVehiculosToolStripMenuItem_Click);
            // 
            // lstVehiculos
            // 
            resources.ApplyResources(this.lstVehiculos, "lstVehiculos");
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.Name = "lstVehiculos";
            // 
            // frmGestionAutomovil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmGestionAutomovil";
            this.Load += new System.EventHandler(this.frmGestionAutomovil_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem nuevoVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidAdmDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ListBox lstVehiculos;









    }
}