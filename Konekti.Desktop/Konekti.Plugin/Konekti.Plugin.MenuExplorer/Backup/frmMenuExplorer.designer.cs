namespace Konekti.Plugin.MenuExplorer
{
    partial class frmMenuExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuExplorer));
            this.ContextMenuDock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FloatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ilKonektikImages = new System.Windows.Forms.ImageList(this.components);
            this._cmNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsConnect = new System.Windows.Forms.ToolStripTextBox();
            this._tsDisconnect = new System.Windows.Forms.ToolStripTextBox();
            this._tpKonekti = new XPExplorerBar.TaskPane();
            this.ContextMenuDock.SuspendLayout();
            this._cmNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tpKonekti)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuDock
            // 
            this.ContextMenuDock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FloatingToolStripMenuItem,
            this.DockableToolStripMenuItem,
            this.DocumentToolStripMenuItem,
            this.AutoHideToolStripMenuItem,
            this.HideToolStripMenuItem});
            this.ContextMenuDock.Name = "ContextMenuStrip1";
            this.ContextMenuDock.Size = new System.Drawing.Size(173, 114);
            this.ContextMenuDock.Text = "Window Position";
            // 
            // FloatingToolStripMenuItem
            // 
            this.FloatingToolStripMenuItem.CheckOnClick = true;
            this.FloatingToolStripMenuItem.Name = "FloatingToolStripMenuItem";
            this.FloatingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.FloatingToolStripMenuItem.Text = "Floating";
            // 
            // DockableToolStripMenuItem
            // 
            this.DockableToolStripMenuItem.Checked = true;
            this.DockableToolStripMenuItem.CheckOnClick = true;
            this.DockableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DockableToolStripMenuItem.Name = "DockableToolStripMenuItem";
            this.DockableToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.DockableToolStripMenuItem.Text = "Dockable";
            // 
            // DocumentToolStripMenuItem
            // 
            this.DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem";
            this.DocumentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.DocumentToolStripMenuItem.Text = "Tabbed Document";
            // 
            // AutoHideToolStripMenuItem
            // 
            this.AutoHideToolStripMenuItem.CheckOnClick = true;
            this.AutoHideToolStripMenuItem.Name = "AutoHideToolStripMenuItem";
            this.AutoHideToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.AutoHideToolStripMenuItem.Text = "Auto Hide";
            // 
            // HideToolStripMenuItem
            // 
            this.HideToolStripMenuItem.CheckOnClick = true;
            this.HideToolStripMenuItem.Name = "HideToolStripMenuItem";
            this.HideToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.HideToolStripMenuItem.Text = "Hide";
            // 
            // _ilKonektikImages
            // 
            this._ilKonektikImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilKonektikImages.ImageStream")));
            this._ilKonektikImages.TransparentColor = System.Drawing.Color.Transparent;
            this._ilKonektikImages.Images.SetKeyName(0, "data.ico");
            this._ilKonektikImages.Images.SetKeyName(1, "data_connection.ico");
            this._ilKonektikImages.Images.SetKeyName(2, "data_table.ico");
            this._ilKonektikImages.Images.SetKeyName(3, "column.ico");
            // 
            // _cmNode
            // 
            this._cmNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsConnect,
            this._tsDisconnect});
            this._cmNode.Name = "_cmNode";
            this._cmNode.Size = new System.Drawing.Size(161, 50);
            // 
            // _tsConnect
            // 
            this._tsConnect.Name = "_tsConnect";
            this._tsConnect.Size = new System.Drawing.Size(100, 21);
            this._tsConnect.Text = "Connect db4o";
            // 
            // _tsDisconnect
            // 
            this._tsDisconnect.Name = "_tsDisconnect";
            this._tsDisconnect.Size = new System.Drawing.Size(100, 21);
            this._tsDisconnect.Text = "Disconnect db4o";
            // 
            // _tpKonekti
            // 
            this._tpKonekti.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this._tpKonekti.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tpKonekti.Location = new System.Drawing.Point(0, 0);
            this._tpKonekti.Name = "_tpKonekti";
            this._tpKonekti.Size = new System.Drawing.Size(189, 269);
            this._tpKonekti.TabIndex = 2;
            this._tpKonekti.Text = "taskPane1";
            // 
            // frmMenuExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(189, 269);
            this.Controls.Add(this._tpKonekti);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuExplorer";
            this.ShowHint = WeifenLuo.WinFormsUI.DockState.DockLeft;
            this.TabPageContextMenuStrip = this.ContextMenuDock;
            this.TabText = "Konekti Menu";
            this.Text = "Konekti Menu";
            this.VisibleTitle = false;
            this.Load += new System.EventHandler(this.frmMenuExplorer_Load);
            this.Controls.SetChildIndex(this._tpKonekti, 0);
            this.ContextMenuDock.ResumeLayout(false);
            this._cmNode.ResumeLayout(false);
            this._cmNode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tpKonekti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Private Members
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        internal System.Windows.Forms.ContextMenuStrip ContextMenuDock;
        internal System.Windows.Forms.ToolStripMenuItem FloatingToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DockableToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoHideToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocumentToolStripMenuItem;
        private System.Windows.Forms.ImageList _ilKonektikImages;
        private System.Windows.Forms.ContextMenuStrip _cmNode;
        private System.Windows.Forms.ToolStripTextBox _tsConnect;
        private System.Windows.Forms.ToolStripTextBox _tsDisconnect;
        private XPExplorerBar.TaskPane _tpKonekti;
        #endregion
    }
}