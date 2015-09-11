namespace Konekti.Plugin.Msdos
{
    partial class MainPluginView
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
            this.commandPrompt = new CommandPrompt.CommandPrompt();
            this.SuspendLayout();
            // 
            // commandPrompt
            // 
            this.commandPrompt.BackColor = System.Drawing.SystemColors.WindowText;
            this.commandPrompt.Delimiters = new char[] {
        ' ',
        '\\'};
            this.commandPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPrompt.ForeColor = System.Drawing.SystemColors.Window;
            this.commandPrompt.Location = new System.Drawing.Point(0, 0);
            this.commandPrompt.MessageColor = System.Drawing.Color.Blue;
            this.commandPrompt.MinimumSize = new System.Drawing.Size(0, 20);
            this.commandPrompt.Name = "commandPrompt";
            this.commandPrompt.PromptColor = System.Drawing.SystemColors.Window;
            this.commandPrompt.Size = new System.Drawing.Size(512, 238);
            this.commandPrompt.TabIndex = 3;
            this.commandPrompt.Command += new CommandPrompt.CommandPrompt.CommandEventHandler(this.commandPrompt_Command);
            // 
            // MainPluginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 226);
            this.Controls.Add(this.commandPrompt);
            this.DockStatePlugin = WeifenLuo.WinFormsUI.DockState.DockBottom;
            this.Name = "MainPluginView";
            this.Text = "MsDOS Shell";
            this.ResumeLayout(false);

        }

        #endregion

        private CommandPrompt.CommandPrompt commandPrompt;
    }
}

