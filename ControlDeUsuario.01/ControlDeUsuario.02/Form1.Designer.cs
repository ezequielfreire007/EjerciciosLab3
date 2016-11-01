namespace ControlDeUsuario._02
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
            this.txtTipoDeNumero1 = new Entities.TxtTipoDeNumero();
            this.SuspendLayout();
            // 
            // txtTipoDeNumero1
            // 
            this.txtTipoDeNumero1.Location = new System.Drawing.Point(92, 58);
            this.txtTipoDeNumero1.Name = "txtTipoDeNumero1";
            this.txtTipoDeNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDeNumero1.TabIndex = 0;
            this.txtTipoDeNumero1.tipo = Entities.ETipoDato.Hexadecimal;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 143);
            this.Controls.Add(this.txtTipoDeNumero1);
            this.Name = "Form1";
            this.Text = "Tipo De Numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.TxtTipoDeNumero txtTipoDeNumero1;
    }
}

