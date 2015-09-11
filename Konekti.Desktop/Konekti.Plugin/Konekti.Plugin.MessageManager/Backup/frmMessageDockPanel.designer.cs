namespace Konekti.Plugin.MessageManager
{
    partial class frmMessageDockPanel
    {
        #region Destructor
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
        #endregion

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageDockPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._ilStatusImages = new System.Windows.Forms.ImageList(this.components);
            this._tsMenssagesType = new System.Windows.Forms.ToolStrip();
            this._tsErrorMenssage = new System.Windows.Forms.ToolStripButton();
            this._tsWarningMenssage = new System.Windows.Forms.ToolStripButton();
            this._tsInformationMenssage = new System.Windows.Forms.ToolStripButton();
            this._dgKonektiMessages = new Konekti.Framework.Controls.DataGrid();
            this._clMessageType = new System.Windows.Forms.DataGridViewImageColumn();
            this._clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._clStationFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MESSAGES = new System.Windows.Forms.BindingSource(this.components);
            this._ilMessagesType = new System.Windows.Forms.ImageList(this.components);
            this._cmMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tssEditMessage = new System.Windows.Forms.ToolStripMenuItem();
            this._tssSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this._tsMenssagesType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgKonektiMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESSAGES)).BeginInit();
            this._cmMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ilStatusImages
            // 
            this._ilStatusImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilStatusImages.ImageStream")));
            this._ilStatusImages.TransparentColor = System.Drawing.Color.Transparent;
            this._ilStatusImages.Images.SetKeyName(0, "information.ico");
            this._ilStatusImages.Images.SetKeyName(1, "warning.ico");
            this._ilStatusImages.Images.SetKeyName(2, "error.ico");
            // 
            // _tsMenssagesType
            // 
            this._tsMenssagesType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsErrorMenssage,
            this._tsWarningMenssage,
            this._tsInformationMenssage});
            this._tsMenssagesType.Location = new System.Drawing.Point(0, 0);
            this._tsMenssagesType.Name = "_tsMenssagesType";
            this._tsMenssagesType.Size = new System.Drawing.Size(613, 25);
            this._tsMenssagesType.TabIndex = 2;
            this._tsMenssagesType.Text = "toolStrip1";
            // 
            // _tsErrorMenssage
            // 
            this._tsErrorMenssage.CheckOnClick = true;
            this._tsErrorMenssage.Image = ((System.Drawing.Image)(resources.GetObject("_tsErrorMenssage.Image")));
            this._tsErrorMenssage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsErrorMenssage.Name = "_tsErrorMenssage";
            this._tsErrorMenssage.Size = new System.Drawing.Size(62, 22);
            this._tsErrorMenssage.Text = "Errores";
            this._tsErrorMenssage.Click += new System.EventHandler(this._tsMenssage_Click);
            // 
            // _tsWarningMenssage
            // 
            this._tsWarningMenssage.CheckOnClick = true;
            this._tsWarningMenssage.Image = ((System.Drawing.Image)(resources.GetObject("_tsWarningMenssage.Image")));
            this._tsWarningMenssage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsWarningMenssage.Name = "_tsWarningMenssage";
            this._tsWarningMenssage.Size = new System.Drawing.Size(90, 22);
            this._tsWarningMenssage.Text = "Advertencias";
            this._tsWarningMenssage.Click += new System.EventHandler(this._tsMenssage_Click);
            // 
            // _tsInformationMenssage
            // 
            this._tsInformationMenssage.CheckOnClick = true;
            this._tsInformationMenssage.Image = ((System.Drawing.Image)(resources.GetObject("_tsInformationMenssage.Image")));
            this._tsInformationMenssage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsInformationMenssage.Name = "_tsInformationMenssage";
            this._tsInformationMenssage.Size = new System.Drawing.Size(72, 22);
            this._tsInformationMenssage.Text = "Mensajes";
            this._tsInformationMenssage.Click += new System.EventHandler(this._tsMenssage_Click);
            // 
            // _dgKonektiMessages
            // 
            this._dgKonektiMessages.AllowUserToAddRows = false;
            this._dgKonektiMessages.AllowUserToDeleteRows = false;
            this._dgKonektiMessages.AllowUserToOrderColumns = true;
            this._dgKonektiMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this._dgKonektiMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgKonektiMessages.AutoGenerateColumns = false;
            this._dgKonektiMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgKonektiMessages.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgKonektiMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgKonektiMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgKonektiMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._clMessageType,
            this._clDescription,
            this._clStationFrom,
            this._clDate});
            this._dgKonektiMessages.DataSource = this.MESSAGES;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgKonektiMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this._dgKonektiMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgKonektiMessages.Location = new System.Drawing.Point(0, 25);
            this._dgKonektiMessages.MultiSelect = false;
            this._dgKonektiMessages.Name = "_dgKonektiMessages";
            this._dgKonektiMessages.ReadOnly = true;
            this._dgKonektiMessages.RowHeadersWidth = 25;
            this._dgKonektiMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgKonektiMessages.Size = new System.Drawing.Size(613, 78);
            this._dgKonektiMessages.TabIndex = 4;
            this._dgKonektiMessages.DoubleClick += new System.EventHandler(this._dgKonektiMessages_DoubleClick);
            // 
            // _clMessageType
            // 
            this._clMessageType.HeaderText = "";
            this._clMessageType.Name = "_clMessageType";
            this._clMessageType.ReadOnly = true;
            // 
            // _clDescription
            // 
            this._clDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._clDescription.HeaderText = "Descripción";
            this._clDescription.Name = "_clDescription";
            this._clDescription.ReadOnly = true;
            // 
            // _clStationFrom
            // 
            this._clStationFrom.HeaderText = "Estación";
            this._clStationFrom.Name = "_clStationFrom";
            this._clStationFrom.ReadOnly = true;
            // 
            // _clDate
            // 
            this._clDate.HeaderText = "Fecha";
            this._clDate.Name = "_clDate";
            this._clDate.ReadOnly = true;
            // 
            // _ilMessagesType
            // 
            this._ilMessagesType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilMessagesType.ImageStream")));
            this._ilMessagesType.TransparentColor = System.Drawing.Color.Transparent;
            this._ilMessagesType.Images.SetKeyName(0, "ERROR");
            this._ilMessagesType.Images.SetKeyName(1, "WARNING");
            this._ilMessagesType.Images.SetKeyName(2, "INFORMATION");
            // 
            // _cmMessages
            // 
            this._cmMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tssEditMessage,
            this._tssSendMessage});
            this._cmMessages.Name = "_cmMessages";
            this._cmMessages.Size = new System.Drawing.Size(148, 48);
            // 
            // _tssEditMessage
            // 
            this._tssEditMessage.Name = "_tssEditMessage";
            this._tssEditMessage.Size = new System.Drawing.Size(147, 22);
            this._tssEditMessage.Text = "Editar Mensaje";
            this._tssEditMessage.Click += new System.EventHandler(this._tssEditMessage_Click);
            // 
            // _tssSendMessage
            // 
            this._tssSendMessage.Name = "_tssSendMessage";
            this._tssSendMessage.Size = new System.Drawing.Size(147, 22);
            this._tssSendMessage.Text = "Enviar Mensaje";
            this._tssSendMessage.Click += new System.EventHandler(this._tssSendMessage_Click);
            // 
            // frmMessageDockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 103);
            this.Controls.Add(this._dgKonektiMessages);
            this.Controls.Add(this._tsMenssagesType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmMessageDockPanel";
            this.TabText = "Konekti Mensajes";
            this.Text = "Konekti Mensajes";
            this.VisibleTitle = false;
            this.Controls.SetChildIndex(this._tsMenssagesType, 0);
            this.Controls.SetChildIndex(this._dgKonektiMessages, 0);
            this._tsMenssagesType.ResumeLayout(false);
            this._tsMenssagesType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgKonektiMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESSAGES)).EndInit();
            this._cmMessages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        #region Private Members
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ImageList _ilStatusImages;
        private System.Windows.Forms.ToolStrip _tsMenssagesType;
        private System.Windows.Forms.ToolStripButton _tsErrorMenssage;
        private System.Windows.Forms.ToolStripButton _tsWarningMenssage;
        private System.Windows.Forms.ToolStripButton _tsInformationMenssage;
        private Konekti.Framework.Controls.DataGrid _dgKonektiMessages;        
        private System.Windows.Forms.ImageList _ilMessagesType;
        private System.Windows.Forms.BindingSource MESSAGES;
        #endregion
        private System.Windows.Forms.DataGridViewImageColumn _clMessageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _clDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn _clStationFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _clDate;
        private System.Windows.Forms.ContextMenuStrip _cmMessages;
        private System.Windows.Forms.ToolStripMenuItem _tssEditMessage;
        private System.Windows.Forms.ToolStripMenuItem _tssSendMessage;

    }
}