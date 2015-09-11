namespace Konekti.Workbench.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.msKonektiMenuBar = new System.Windows.Forms.MenuStrip();
            this.muFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muView = new System.Windows.Forms.ToolStripMenuItem();
            this.KonektiMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.muHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._tsContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.stKonektiBar = new System.Windows.Forms.StatusStrip();
            this._tssStateConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this._tssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this._tssProgress = new System.Windows.Forms.ToolStripProgressBar();
            this._tssTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspKonektiToolBar = new System.Windows.Forms.ToolStripPanel();
            this.tsStadardBarsVisible = new System.Windows.Forms.ToolStrip();
            this._tsbGroupsMenuPanel = new System.Windows.Forms.ToolStripButton();
            this._tsbWarningPanel = new System.Windows.Forms.ToolStripButton();
            this.dockPanel = new WeifenLuo.WinFormsUI.DockPanel();
            this.msKonektiMenuBar.SuspendLayout();
            this.stKonektiBar.SuspendLayout();
            this.tspKonektiToolBar.SuspendLayout();
            this.tsStadardBarsVisible.SuspendLayout();
            this.SuspendLayout();
            // 
            // msKonektiMenuBar
            // 
            this.msKonektiMenuBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msKonektiMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muFile,
            this.muView,
            this.muWindows,
            this.muHelp});
            this.msKonektiMenuBar.Location = new System.Drawing.Point(0, 0);
            this.msKonektiMenuBar.Name = "msKonektiMenuBar";
            this.msKonektiMenuBar.Size = new System.Drawing.Size(744, 24);
            this.msKonektiMenuBar.TabIndex = 2;
            this.msKonektiMenuBar.Text = "menuStrip1";
            // 
            // muFile
            // 
            this.muFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.muFile.Name = "muFile";
            this.muFile.Size = new System.Drawing.Size(60, 20);
            this.muFile.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // muView
            // 
            this.muView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KonektiMenuToolStripMenuItem,
            this.LogPanelToolStripMenuItem});
            this.muView.Name = "muView";
            this.muView.Size = new System.Drawing.Size(36, 20);
            this.muView.Text = "&Ver";
            // 
            // KonektiMenuToolStripMenuItem
            // 
            this.KonektiMenuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("KonektiMenuToolStripMenuItem.Image")));
            this.KonektiMenuToolStripMenuItem.Name = "KonektiMenuToolStripMenuItem";
            this.KonektiMenuToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.KonektiMenuToolStripMenuItem.Text = "Barra &Herramientas";
            // 
            // LogPanelToolStripMenuItem
            // 
            this.LogPanelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LogPanelToolStripMenuItem.Image")));
            this.LogPanelToolStripMenuItem.Name = "LogPanelToolStripMenuItem";
            this.LogPanelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.LogPanelToolStripMenuItem.Text = "Barra &Estado";
            // 
            // muWindows
            // 
            this.muWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1});
            this.muWindows.Name = "muWindows";
            this.muWindows.Size = new System.Drawing.Size(62, 20);
            this.muWindows.Text = "Ve&ntana";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeAllToolStripMenuItem.Image")));
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.closeAllToolStripMenuItem.Text = "&Cerrar todos las ventanas";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.closeToolStripMenuItem.Text = "Cerrar &ventana activa";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // muHelp
            // 
            this.muHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsContents,
            this.toolStripSeparator7,
            this._tsAbout});
            this.muHelp.Name = "muHelp";
            this.muHelp.Size = new System.Drawing.Size(53, 20);
            this.muHelp.Text = "Ay&uda";
            // 
            // _tsContents
            // 
            this._tsContents.Image = ((System.Drawing.Image)(resources.GetObject("_tsContents.Image")));
            this._tsContents.Name = "_tsContents";
            this._tsContents.Size = new System.Drawing.Size(178, 22);
            this._tsContents.Text = "&Como";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(175, 6);
            // 
            // _tsAbout
            // 
            this._tsAbout.Name = "_tsAbout";
            this._tsAbout.Size = new System.Drawing.Size(178, 22);
            this._tsAbout.Text = "Acerca &de Konekti...";
            this._tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // stKonektiBar
            // 
            this.stKonektiBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tssStateConnected,
            this._tssMessage,
            this._tssProgress,
            this._tssTimer});
            this.stKonektiBar.Location = new System.Drawing.Point(0, 240);
            this.stKonektiBar.Name = "stKonektiBar";
            this.stKonektiBar.Size = new System.Drawing.Size(744, 22);
            this.stKonektiBar.TabIndex = 17;
            this.stKonektiBar.Text = "Time";
            // 
            // _tssStateConnected
            // 
            this._tssStateConnected.AutoSize = false;
            this._tssStateConnected.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this._tssStateConnected.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this._tssStateConnected.Name = "_tssStateConnected";
            this._tssStateConnected.Size = new System.Drawing.Size(100, 17);
            // 
            // _tssMessage
            // 
            this._tssMessage.AutoSize = false;
            this._tssMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this._tssMessage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this._tssMessage.Name = "_tssMessage";
            this._tssMessage.Size = new System.Drawing.Size(448, 17);
            this._tssMessage.Spring = true;
            // 
            // _tssProgress
            // 
            this._tssProgress.Name = "_tssProgress";
            this._tssProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // _tssTimer
            // 
            this._tssTimer.AutoSize = false;
            this._tssTimer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this._tssTimer.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this._tssTimer.Name = "_tssTimer";
            this._tssTimer.Size = new System.Drawing.Size(79, 17);
            // 
            // tspKonektiToolBar
            // 
            this.tspKonektiToolBar.BackColor = System.Drawing.SystemColors.Control;
            this.tspKonektiToolBar.Controls.Add(this.tsStadardBarsVisible);
            this.tspKonektiToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tspKonektiToolBar.Location = new System.Drawing.Point(0, 24);
            this.tspKonektiToolBar.MinimumSize = new System.Drawing.Size(0, 26);
            this.tspKonektiToolBar.Name = "tspKonektiToolBar";
            this.tspKonektiToolBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tspKonektiToolBar.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tspKonektiToolBar.Size = new System.Drawing.Size(744, 26);
            // 
            // tsStadardBarsVisible
            // 
            this.tsStadardBarsVisible.Dock = System.Windows.Forms.DockStyle.None;
            this.tsStadardBarsVisible.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbGroupsMenuPanel,
            this._tsbWarningPanel});
            this.tsStadardBarsVisible.Location = new System.Drawing.Point(3, 0);
            this.tsStadardBarsVisible.Name = "tsStadardBarsVisible";
            this.tsStadardBarsVisible.Size = new System.Drawing.Size(89, 25);
            this.tsStadardBarsVisible.TabIndex = 1;
            // 
            // _tsbGroupsMenuPanel
            // 
            this._tsbGroupsMenuPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbGroupsMenuPanel.Image = ((System.Drawing.Image)(resources.GetObject("_tsbGroupsMenuPanel.Image")));
            this._tsbGroupsMenuPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbGroupsMenuPanel.Name = "_tsbGroupsMenuPanel";
            this._tsbGroupsMenuPanel.Size = new System.Drawing.Size(23, 22);
            this._tsbGroupsMenuPanel.Text = "Konekti Menu";
            // 
            // _tsbWarningPanel
            // 
            this._tsbWarningPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbWarningPanel.Image = ((System.Drawing.Image)(resources.GetObject("_tsbWarningPanel.Image")));
            this._tsbWarningPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbWarningPanel.Name = "_tsbWarningPanel";
            this._tsbWarningPanel.Size = new System.Drawing.Size(23, 22);
            this._tsbWarningPanel.Text = "Konekti Mensajes";
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.BackColor = System.Drawing.SystemColors.Control;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dockPanel.Location = new System.Drawing.Point(0, 50);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.ShowDocumentIcon = true;
            this.dockPanel.Size = new System.Drawing.Size(744, 190);
            this.dockPanel.TabIndex = 36;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 262);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.tspKonektiToolBar);
            this.Controls.Add(this.stKonektiBar);
            this.Controls.Add(this.msKonektiMenuBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msKonektiMenuBar;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konekti Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainView_MdiChildActivate);
            this.msKonektiMenuBar.ResumeLayout(false);
            this.msKonektiMenuBar.PerformLayout();
            this.stKonektiBar.ResumeLayout(false);
            this.stKonektiBar.PerformLayout();
            this.tspKonektiToolBar.ResumeLayout(false);
            this.tspKonektiToolBar.PerformLayout();
            this.tsStadardBarsVisible.ResumeLayout(false);
            this.tsStadardBarsVisible.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msKonektiMenuBar;
        private System.Windows.Forms.ToolStripMenuItem muFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muView;
        private System.Windows.Forms.ToolStripMenuItem KonektiMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muWindows;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem muHelp;
        private System.Windows.Forms.ToolStripMenuItem _tsContents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem _tsAbout;
        internal System.Windows.Forms.StatusStrip stKonektiBar;
        private System.Windows.Forms.ToolStripStatusLabel _tssStateConnected;
        private System.Windows.Forms.ToolStripStatusLabel _tssMessage;
        private System.Windows.Forms.ToolStripProgressBar _tssProgress;
        private System.Windows.Forms.ToolStripStatusLabel _tssTimer;
        private System.Windows.Forms.ToolStripPanel tspKonektiToolBar;
        private System.Windows.Forms.ToolStrip tsStadardBarsVisible;
        private System.Windows.Forms.ToolStripButton _tsbGroupsMenuPanel;
        private System.Windows.Forms.ToolStripButton _tsbWarningPanel;
        private WeifenLuo.WinFormsUI.DockPanel dockPanel;
    }
}

