namespace Konekti.Framework.UI
{
    partial class ColumnFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnFilterForm));
            this._gbMostrarColumnas = new System.Windows.Forms.GroupBox();
            this._clbShowColumn = new System.Windows.Forms.CheckedListBox();
            this._btnSelect = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._gbMostrarColumnas.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gbMostrarColumnas
            // 
            this._gbMostrarColumnas.BackColor = System.Drawing.SystemColors.Control;
            this._gbMostrarColumnas.Controls.Add(this._clbShowColumn);
            this._gbMostrarColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gbMostrarColumnas.ForeColor = System.Drawing.SystemColors.ControlText;
            this._gbMostrarColumnas.Location = new System.Drawing.Point(12, 15);
            this._gbMostrarColumnas.Name = "_gbMostrarColumnas";
            this._gbMostrarColumnas.Size = new System.Drawing.Size(184, 261);
            this._gbMostrarColumnas.TabIndex = 2;
            this._gbMostrarColumnas.TabStop = false;
            this._gbMostrarColumnas.Text = "Columnas";
            // 
            // _clbShowColumn
            // 
            this._clbShowColumn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._clbShowColumn.Location = new System.Drawing.Point(10, 32);
            this._clbShowColumn.Name = "_clbShowColumn";
            this._clbShowColumn.Size = new System.Drawing.Size(163, 212);
            this._clbShowColumn.TabIndex = 0;
            // 
            // _btnSelect
            // 
            this._btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this._btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("_btnSelect.Image")));
            this._btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSelect.Location = new System.Drawing.Point(110, 291);
            this._btnSelect.Name = "_btnSelect";
            this._btnSelect.Size = new System.Drawing.Size(86, 23);
            this._btnSelect.TabIndex = 0;
            this._btnSelect.Text = "Seleccionar";
            this._btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnSelect.UseVisualStyleBackColor = false;
            this._btnSelect.Click += new System.EventHandler(this._btnSelect_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("_btnCancel.Image")));
            this._btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnCancel.Location = new System.Drawing.Point(12, 291);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(86, 23);
            this._btnCancel.TabIndex = 0;
            this._btnCancel.Text = "Cancelar";
            this._btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // ColumnFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(205, 321);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSelect);
            this.Controls.Add(this._gbMostrarColumnas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro Columnas";
            this._gbMostrarColumnas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbMostrarColumnas;
        private System.Windows.Forms.CheckedListBox _clbShowColumn;
        private System.Windows.Forms.Button _btnSelect;
        private System.Collections.ArrayList _Columns = null;
        private DataGrid _Grid = null;
        private System.Windows.Forms.Button _btnCancel;
        private int _ColumnPosition;
        private InsertionType _InsertionType;
    }
}