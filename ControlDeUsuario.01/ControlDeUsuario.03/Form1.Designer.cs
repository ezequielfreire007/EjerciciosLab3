namespace ControlDeUsuario._03
{
    partial class Form1
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
            this.txtLetraOculta1 = new Entities.TxtLetraOculta();
            this.SuspendLayout();
            // 
            // txtLetraOculta1
            // 
            this.txtLetraOculta1.letraOculta = 'E';
            this.txtLetraOculta1.Location = new System.Drawing.Point(86, 38);
            this.txtLetraOculta1.Name = "txtLetraOculta1";
            this.txtLetraOculta1.Size = new System.Drawing.Size(100, 20);
            this.txtLetraOculta1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 110);
            this.Controls.Add(this.txtLetraOculta1);
            this.Name = "Form1";
            this.Text = "Letra Oculta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.TxtLetraOculta txtLetraOculta1;
    }
}

