namespace Konekti.Plugin.MessageManager
{
    partial class frmReadMessage
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReadMessage));
            this._lblMensaje = new System.Windows.Forms.Label();
            this._edtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblMensaje
            // 
            this._lblMensaje.AutoSize = true;
            this._lblMensaje.Location = new System.Drawing.Point(11, 66);
            this._lblMensaje.Name = "_lblMensaje";
            this._lblMensaje.Size = new System.Drawing.Size(50, 13);
            this._lblMensaje.TabIndex = 15;
            this._lblMensaje.Text = "Mensaje:";
            // 
            // _edtMensaje
            // 
            this._edtMensaje.Location = new System.Drawing.Point(65, 63);
            this._edtMensaje.Multiline = true;
            this._edtMensaje.Name = "_edtMensaje";
            this._edtMensaje.ReadOnly = true;
            this._edtMensaje.Size = new System.Drawing.Size(419, 46);
            this._edtMensaje.TabIndex = 16;
            // 
            // frmReadMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 156);
            this.Controls.Add(this._lblMensaje);
            this.Controls.Add(this._edtMensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReadMessage";
            this.Text = "Confirmar Mensaje";
            this.TextRightButton = "&Confirmar";
            this.SaveClicked += new System.EventHandler(this.frmReadMessage_SaveClicked);
            this.CancelClicked += new System.EventHandler(this.frmReadMessage_CancelClicked);
            this.Controls.SetChildIndex(this._edtMensaje, 0);
            this.Controls.SetChildIndex(this._lblMensaje, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblMensaje;
        private System.Windows.Forms.TextBox _edtMensaje;
    }
}