namespace Konekti.Workbench.View
{
    partial class AboutView
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
            this.pnTopAbout = new System.Windows.Forms.Panel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pnDescriptionAbout = new System.Windows.Forms.Panel();
            this.lbPluginList = new System.Windows.Forms.Label();
            this.lbPluginDetail = new System.Windows.Forms.Label();
            this.pnPluginDetail = new System.Windows.Forms.Panel();
            this.pnDetailPlugin = new System.Windows.Forms.Panel();
            this.lbAssemblyDescription = new System.Windows.Forms.Label();
            this.pnImagePlugin = new System.Windows.Forms.Panel();
            this.pcImagePlugin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPlugins = new System.Windows.Forms.ListBox();
            this.btSystemInfo = new System.Windows.Forms.Button();
            this.btCopyInfo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.leftKonektiDescription = new System.Windows.Forms.RichTextBox();
            this.rightKonektiDescription = new System.Windows.Forms.RichTextBox();
            this.pnTopAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.pnDescriptionAbout.SuspendLayout();
            this.pnPluginDetail.SuspendLayout();
            this.pnDetailPlugin.SuspendLayout();
            this.pnImagePlugin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagePlugin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopAbout
            // 
            this.pnTopAbout.BackColor = System.Drawing.Color.White;
            this.pnTopAbout.Controls.Add(this.pcLogo);
            this.pnTopAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopAbout.Location = new System.Drawing.Point(0, 0);
            this.pnTopAbout.Name = "pnTopAbout";
            this.pnTopAbout.Size = new System.Drawing.Size(568, 70);
            this.pnTopAbout.TabIndex = 1;
            // 
            // pcLogo
            // 
            this.pcLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(70, 70);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLogo.TabIndex = 1;
            this.pcLogo.TabStop = false;
            // 
            // pnDescriptionAbout
            // 
            this.pnDescriptionAbout.Controls.Add(this.rightKonektiDescription);
            this.pnDescriptionAbout.Controls.Add(this.leftKonektiDescription);
            this.pnDescriptionAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDescriptionAbout.Location = new System.Drawing.Point(0, 70);
            this.pnDescriptionAbout.Name = "pnDescriptionAbout";
            this.pnDescriptionAbout.Size = new System.Drawing.Size(568, 61);
            this.pnDescriptionAbout.TabIndex = 2;
            // 
            // lbPluginList
            // 
            this.lbPluginList.AutoSize = true;
            this.lbPluginList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPluginList.Location = new System.Drawing.Point(0, 131);
            this.lbPluginList.Name = "lbPluginList";
            this.lbPluginList.Size = new System.Drawing.Size(86, 13);
            this.lbPluginList.TabIndex = 3;
            this.lbPluginList.Text = "Plugins Installed:";
            // 
            // lbPluginDetail
            // 
            this.lbPluginDetail.AutoSize = true;
            this.lbPluginDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPluginDetail.Location = new System.Drawing.Point(0, 244);
            this.lbPluginDetail.Name = "lbPluginDetail";
            this.lbPluginDetail.Size = new System.Drawing.Size(69, 13);
            this.lbPluginDetail.TabIndex = 5;
            this.lbPluginDetail.Text = "Plugin Detail:";
            // 
            // pnPluginDetail
            // 
            this.pnPluginDetail.BackColor = System.Drawing.SystemColors.Control;
            this.pnPluginDetail.Controls.Add(this.pnDetailPlugin);
            this.pnPluginDetail.Controls.Add(this.pnImagePlugin);
            this.pnPluginDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPluginDetail.Location = new System.Drawing.Point(0, 257);
            this.pnPluginDetail.Name = "pnPluginDetail";
            this.pnPluginDetail.Size = new System.Drawing.Size(568, 44);
            this.pnPluginDetail.TabIndex = 6;
            // 
            // pnDetailPlugin
            // 
            this.pnDetailPlugin.BackColor = System.Drawing.Color.White;
            this.pnDetailPlugin.Controls.Add(this.lbAssemblyDescription);
            this.pnDetailPlugin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDetailPlugin.Location = new System.Drawing.Point(45, 0);
            this.pnDetailPlugin.Name = "pnDetailPlugin";
            this.pnDetailPlugin.Size = new System.Drawing.Size(420, 44);
            this.pnDetailPlugin.TabIndex = 1;
            // 
            // lbAssemblyDescription
            // 
            this.lbAssemblyDescription.AutoSize = true;
            this.lbAssemblyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAssemblyDescription.Location = new System.Drawing.Point(0, 0);
            this.lbAssemblyDescription.Name = "lbAssemblyDescription";
            this.lbAssemblyDescription.Size = new System.Drawing.Size(0, 13);
            this.lbAssemblyDescription.TabIndex = 0;
            // 
            // pnImagePlugin
            // 
            this.pnImagePlugin.BackColor = System.Drawing.SystemColors.Control;
            this.pnImagePlugin.Controls.Add(this.pcImagePlugin);
            this.pnImagePlugin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImagePlugin.Location = new System.Drawing.Point(0, 0);
            this.pnImagePlugin.Name = "pnImagePlugin";
            this.pnImagePlugin.Size = new System.Drawing.Size(45, 44);
            this.pnImagePlugin.TabIndex = 0;
            // 
            // pcImagePlugin
            // 
            this.pcImagePlugin.Location = new System.Drawing.Point(10, 8);
            this.pcImagePlugin.Name = "pcImagePlugin";
            this.pcImagePlugin.Size = new System.Drawing.Size(25, 25);
            this.pcImagePlugin.TabIndex = 0;
            this.pcImagePlugin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPlugins);
            this.panel2.Controls.Add(this.btSystemInfo);
            this.panel2.Controls.Add(this.btCopyInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 100);
            this.panel2.TabIndex = 7;
            // 
            // lbPlugins
            // 
            this.lbPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPlugins.FormattingEnabled = true;
            this.lbPlugins.Location = new System.Drawing.Point(0, 0);
            this.lbPlugins.Name = "lbPlugins";
            this.lbPlugins.Size = new System.Drawing.Size(465, 100);
            this.lbPlugins.TabIndex = 7;
            this.lbPlugins.SelectedIndexChanged += new System.EventHandler(this.lbPlugins_SelectedIndexChanged);
            // 
            // btSystemInfo
            // 
            this.btSystemInfo.Location = new System.Drawing.Point(481, 38);
            this.btSystemInfo.Name = "btSystemInfo";
            this.btSystemInfo.Size = new System.Drawing.Size(75, 23);
            this.btSystemInfo.TabIndex = 6;
            this.btSystemInfo.Text = "System Info";
            this.btSystemInfo.UseVisualStyleBackColor = true;
            // 
            // btCopyInfo
            // 
            this.btCopyInfo.Location = new System.Drawing.Point(481, 8);
            this.btCopyInfo.Name = "btCopyInfo";
            this.btCopyInfo.Size = new System.Drawing.Size(75, 23);
            this.btCopyInfo.TabIndex = 5;
            this.btCopyInfo.Text = "Copy Info";
            this.btCopyInfo.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(481, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // leftKonektiDescription
            // 
            this.leftKonektiDescription.BackColor = System.Drawing.SystemColors.Control;
            this.leftKonektiDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftKonektiDescription.Location = new System.Drawing.Point(0, 0);
            this.leftKonektiDescription.Name = "leftKonektiDescription";
            this.leftKonektiDescription.Size = new System.Drawing.Size(289, 61);
            this.leftKonektiDescription.TabIndex = 0;
            this.leftKonektiDescription.Text = "";
            // 
            // rightKonektiDescription
            // 
            this.rightKonektiDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rightKonektiDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightKonektiDescription.Location = new System.Drawing.Point(289, 0);
            this.rightKonektiDescription.Name = "rightKonektiDescription";
            this.rightKonektiDescription.Size = new System.Drawing.Size(279, 61);
            this.rightKonektiDescription.TabIndex = 1;
            this.rightKonektiDescription.Text = "";
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 322);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnPluginDetail);
            this.Controls.Add(this.lbPluginDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbPluginList);
            this.Controls.Add(this.pnDescriptionAbout);
            this.Controls.Add(this.pnTopAbout);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About View";
            this.pnTopAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.pnDescriptionAbout.ResumeLayout(false);
            this.pnPluginDetail.ResumeLayout(false);
            this.pnDetailPlugin.ResumeLayout(false);
            this.pnDetailPlugin.PerformLayout();
            this.pnImagePlugin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImagePlugin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTopAbout;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Panel pnDescriptionAbout;
        private System.Windows.Forms.Label lbPluginList;
        private System.Windows.Forms.Label lbPluginDetail;
        private System.Windows.Forms.Panel pnPluginDetail;
        private System.Windows.Forms.Panel pnImagePlugin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSystemInfo;
        private System.Windows.Forms.Button btCopyInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pcImagePlugin;
        private System.Windows.Forms.Panel pnDetailPlugin;
        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.Label lbAssemblyDescription;
        private System.Windows.Forms.RichTextBox leftKonektiDescription;
        private System.Windows.Forms.RichTextBox rightKonektiDescription;
    }
}