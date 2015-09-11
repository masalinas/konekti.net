namespace Konekti.Framework.UI
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.pnlCustomPaint = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.fcSaveButton = new System.Windows.Forms.Button();
            this.fcCancelButton = new System.Windows.Forms.Button();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomPaint
            // 
            this.pnlCustomPaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomPaint.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomPaint.Name = "pnlCustomPaint";
            this.pnlCustomPaint.Size = new System.Drawing.Size(594, 44);
            this.pnlCustomPaint.TabIndex = 2;
            this.pnlCustomPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomPaint_Paint);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFooter.Controls.Add(this.fcSaveButton);
            this.panelFooter.Controls.Add(this.fcCancelButton);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 376);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(594, 36);
            this.panelFooter.TabIndex = 12;
            // 
            // fcSaveButton
            // 
            this.fcSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fcSaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.fcSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("fcSaveButton.Image")));
            this.fcSaveButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.fcSaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fcSaveButton.Location = new System.Drawing.Point(508, 8);
            this.fcSaveButton.Name = "fcSaveButton";
            this.fcSaveButton.Size = new System.Drawing.Size(72, 24);
            this.fcSaveButton.TabIndex = 101;
            this.fcSaveButton.TabStop = false;
            this.fcSaveButton.Text = "&Guardar";
            this.fcSaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fcSaveButton.UseVisualStyleBackColor = false;
            this.fcSaveButton.Click += new System.EventHandler(this.fcSaveButton_Click);
            // 
            // fcCancelButton
            // 
            this.fcCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fcCancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.fcCancelButton.CausesValidation = false;
            this.fcCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fcCancelButton.Image = ((System.Drawing.Image)(resources.GetObject("fcCancelButton.Image")));
            this.fcCancelButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.fcCancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fcCancelButton.Location = new System.Drawing.Point(432, 8);
            this.fcCancelButton.Name = "fcCancelButton";
            this.fcCancelButton.Size = new System.Drawing.Size(72, 24);
            this.fcCancelButton.TabIndex = 100;
            this.fcCancelButton.TabStop = false;
            this.fcCancelButton.Text = "&Cancelar";
            this.fcCancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fcCancelButton.UseVisualStyleBackColor = false;
            this.fcCancelButton.Click += new System.EventHandler(this.fcCancelButton_Click);
            // 
            // EditForm
            // 
            this.AcceptButton = this.fcSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fcCancelButton;
            this.ClientSize = new System.Drawing.Size(594, 412);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.pnlCustomPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomPaint;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button fcSaveButton;
        private System.Windows.Forms.Button fcCancelButton;
        private bool _showLeftButton = true;
        private bool _showRightButton = true;
    }
}