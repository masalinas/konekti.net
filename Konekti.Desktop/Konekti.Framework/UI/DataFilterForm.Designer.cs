namespace Konekti.Framework.UI
{
    partial class DataFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataFilterForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this._btnSelect = new System.Windows.Forms.Button();
            this._gbMostrarColumnas = new System.Windows.Forms.GroupBox();
            this._dgDataFilter = new System.Windows.Forms.DataGridView();
            this._btnCancel = new System.Windows.Forms.Button();
            this.FILERCOLUMNS = new System.Windows.Forms.BindingSource(this.components);
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._gbMostrarColumnas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgDataFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FILERCOLUMNS)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnSelect
            // 
            this._btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this._btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("_btnSelect.Image")));
            this._btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSelect.Location = new System.Drawing.Point(196, 291);
            this._btnSelect.Name = "_btnSelect";
            this._btnSelect.Size = new System.Drawing.Size(86, 23);
            this._btnSelect.TabIndex = 3;
            this._btnSelect.Text = "Seleccionar";
            this._btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnSelect.UseVisualStyleBackColor = false;
            this._btnSelect.Click += new System.EventHandler(this._btnSelect_Click);
            // 
            // _gbMostrarColumnas
            // 
            this._gbMostrarColumnas.BackColor = System.Drawing.SystemColors.Control;
            this._gbMostrarColumnas.Controls.Add(this._dgDataFilter);
            this._gbMostrarColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gbMostrarColumnas.ForeColor = System.Drawing.SystemColors.ControlText;
            this._gbMostrarColumnas.Location = new System.Drawing.Point(12, 15);
            this._gbMostrarColumnas.Name = "_gbMostrarColumnas";
            this._gbMostrarColumnas.Size = new System.Drawing.Size(270, 261);
            this._gbMostrarColumnas.TabIndex = 4;
            this._gbMostrarColumnas.TabStop = false;
            this._gbMostrarColumnas.Text = "Columnas";
            // 
            // _dgDataFilter
            // 
            this._dgDataFilter.AllowUserToAddRows = false;
            this._dgDataFilter.AllowUserToDeleteRows = false;
            this._dgDataFilter.AllowUserToResizeRows = false;
            this._dgDataFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgDataFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Operation,
            this.Value});
            this._dgDataFilter.Location = new System.Drawing.Point(10, 32);
            this._dgDataFilter.MultiSelect = false;
            this._dgDataFilter.Name = "_dgDataFilter";
            this._dgDataFilter.RowHeadersVisible = false;
            this._dgDataFilter.Size = new System.Drawing.Size(250, 212);
            this._dgDataFilter.TabIndex = 0;
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
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancelar";
            this._btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // Column
            // 
            this.Column.DataPropertyName = "Column";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column.HeaderText = "Columna";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 80;
            // 
            // Operation
            // 
            this.Operation.DataPropertyName = "Operation";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation.DefaultCellStyle = dataGridViewCellStyle6;
            this.Operation.HeaderText = "";
            this.Operation.Items.AddRange(new object[] {
            "<",
            "<=",
            ">",
            ">=",
            "=",
            "<>",
            "Como"});
            this.Operation.Name = "Operation";
            this.Operation.Width = 60;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.DataPropertyName = "Value";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.DefaultCellStyle = dataGridViewCellStyle7;
            this.Value.HeaderText = "Valor";
            this.Value.Name = "Value";
            // 
            // DataFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSelect);
            this.Controls.Add(this._gbMostrarColumnas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro Datos";
            this.Load += new System.EventHandler(this.DataFilterForm_Load);
            this._gbMostrarColumnas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgDataFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FILERCOLUMNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnSelect;
        private System.Windows.Forms.GroupBox _gbMostrarColumnas;
        private System.Windows.Forms.DataGridView _dgDataFilter;
        private System.Collections.ArrayList _Columns = null;
        private DataGrid _Grid = null;
        private System.Data.DataTable _FilterColumns = null;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.BindingSource FILERCOLUMNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}