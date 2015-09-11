namespace Konekti.Plugin.MessageManager
{
    partial class frmCreateMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateMessage));
            this._lblMensaje = new System.Windows.Forms.Label();
            this._edtMensaje = new System.Windows.Forms.TextBox();
            this._lblStationTo = new System.Windows.Forms.Label();
            this._cmbStation = new System.Windows.Forms.ComboBox();
            this.STD_STATION = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.STD_STATION)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblMensaje
            // 
            this._lblMensaje.AutoSize = true;
            this._lblMensaje.Location = new System.Drawing.Point(16, 107);
            this._lblMensaje.Name = "_lblMensaje";
            this._lblMensaje.Size = new System.Drawing.Size(50, 13);
            this._lblMensaje.TabIndex = 13;
            this._lblMensaje.Text = "Mensaje:";
            // 
            // _edtMensaje
            // 
            this._edtMensaje.Location = new System.Drawing.Point(70, 104);
            this._edtMensaje.Multiline = true;
            this._edtMensaje.Name = "_edtMensaje";
            this._edtMensaje.Size = new System.Drawing.Size(419, 46);
            this._edtMensaje.TabIndex = 14;
            // 
            // _lblStationTo
            // 
            this._lblStationTo.AutoSize = true;
            this._lblStationTo.Location = new System.Drawing.Point(15, 66);
            this._lblStationTo.Name = "_lblStationTo";
            this._lblStationTo.Size = new System.Drawing.Size(51, 13);
            this._lblStationTo.TabIndex = 13;
            this._lblStationTo.Text = "Estación:";
            // 
            // _cmbStation
            // 
            this._cmbStation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.STD_STATION, "StationId", true));
            this._cmbStation.DataSource = this.STD_STATION;
            this._cmbStation.DisplayMember = "Code";
            this._cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbStation.FormattingEnabled = true;
            this._cmbStation.Location = new System.Drawing.Point(71, 63);
            this._cmbStation.Name = "_cmbStation";
            this._cmbStation.Size = new System.Drawing.Size(114, 21);
            this._cmbStation.TabIndex = 15;
            // 
            // STD_STATION
            // 
            this.STD_STATION.DataSource = typeof(Konekti.CoreModel.BussinesObjects.StdStationCollection);
            // 
            // frmCreateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 195);
            this.Controls.Add(this._cmbStation);
            this.Controls.Add(this._lblStationTo);
            this.Controls.Add(this._lblMensaje);
            this.Controls.Add(this._edtMensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateMessage";
            this.Text = "Mensaje";
            this.TextRightButton = "&Send";
            this.SaveClicked += new System.EventHandler(this.frmCreateMessage_SaveClicked);
            this.CancelClicked += new System.EventHandler(this.frmCreateMessage_CancelClicked);
            this.Load += new System.EventHandler(this.frmCreateMessage_Load);
            this.Controls.SetChildIndex(this._edtMensaje, 0);
            this.Controls.SetChildIndex(this._lblMensaje, 0);
            this.Controls.SetChildIndex(this._lblStationTo, 0);
            this.Controls.SetChildIndex(this._cmbStation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.STD_STATION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblMensaje;
        private System.Windows.Forms.TextBox _edtMensaje;
        private System.Windows.Forms.Label _lblStationTo;
        private System.Windows.Forms.ComboBox _cmbStation;
        private System.Windows.Forms.BindingSource STD_STATION;
        private Konekti.CoreModel.BussinesObjects.StdMessage _message;
        private int _StationIdFrom;
    }
}