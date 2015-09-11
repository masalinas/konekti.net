namespace Konekti.Framework.UI
{
    partial class DataGrid
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._cmDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsOrderAscColumn = new System.Windows.Forms.ToolStripMenuItem();
            this._tsOrderDesColumn = new System.Windows.Forms.ToolStripMenuItem();
            this._tsClearSort = new System.Windows.Forms.ToolStripMenuItem();
            this._tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._tsDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this._tsInsertBeforeColumn = new System.Windows.Forms.ToolStripMenuItem();
            this._tsInsertAfterColumn = new System.Windows.Forms.ToolStripMenuItem();
            this._tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._tsFilterColumns = new System.Windows.Forms.ToolStripMenuItem();
            this._cmDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // _cmDataGrid
            // 
            this._cmDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsOrderAscColumn,
            this._tsOrderDesColumn,
            this._tsClearSort,
            this._tsSeparator1,
            this._tsDeleteColumn,
            this._tsInsertBeforeColumn,
            this._tsInsertAfterColumn,
            this._tsSeparator2,
            this._tsFilterColumns});
            this._cmDataGrid.Name = "_cmDataGrid";
            this._cmDataGrid.Size = new System.Drawing.Size(204, 170);
            // 
            // _tsOrderAscColumn
            // 
            this._tsOrderAscColumn.CheckOnClick = true;
            this._tsOrderAscColumn.Image = ((System.Drawing.Image)(resources.GetObject("_tsOrderAscColumn.Image")));
            this._tsOrderAscColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsOrderAscColumn.Name = "_tsOrderAscColumn";
            this._tsOrderAscColumn.Size = new System.Drawing.Size(203, 22);
            this._tsOrderAscColumn.Text = "Orden Ascendente";
            this._tsOrderAscColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tsOrderDesColumn
            // 
            this._tsOrderDesColumn.CheckOnClick = true;
            this._tsOrderDesColumn.Image = ((System.Drawing.Image)(resources.GetObject("_tsOrderDesColumn.Image")));
            this._tsOrderDesColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsOrderDesColumn.Name = "_tsOrderDesColumn";
            this._tsOrderDesColumn.Size = new System.Drawing.Size(203, 22);
            this._tsOrderDesColumn.Text = "Orden Descendente";
            this._tsOrderDesColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tsClearSort
            // 
            this._tsClearSort.Enabled = false;
            this._tsClearSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsClearSort.Name = "_tsClearSort";
            this._tsClearSort.Size = new System.Drawing.Size(203, 22);
            this._tsClearSort.Text = "Borrar Orden";
            this._tsClearSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tsSeparator1
            // 
            this._tsSeparator1.Name = "_tsSeparator1";
            this._tsSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // _tsDeleteColumn
            // 
            this._tsDeleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("_tsDeleteColumn.Image")));
            this._tsDeleteColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsDeleteColumn.Name = "_tsDeleteColumn";
            this._tsDeleteColumn.Size = new System.Drawing.Size(203, 22);
            this._tsDeleteColumn.Text = "Borrar Columna";
            this._tsDeleteColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tsInsertBeforeColumn
            // 
            this._tsInsertBeforeColumn.Image = ((System.Drawing.Image)(resources.GetObject("_tsInsertBeforeColumn.Image")));
            this._tsInsertBeforeColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsInsertBeforeColumn.Name = "_tsInsertBeforeColumn";
            this._tsInsertBeforeColumn.Size = new System.Drawing.Size(203, 22);
            this._tsInsertBeforeColumn.Text = "Insertar Columns Anterior";
            this._tsInsertBeforeColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tsInsertAfterColumn
            // 
            this._tsInsertAfterColumn.Image = ((System.Drawing.Image)(resources.GetObject("_tsInsertAfterColumn.Image")));
            this._tsInsertAfterColumn.Name = "_tsInsertAfterColumn";
            this._tsInsertAfterColumn.Size = new System.Drawing.Size(203, 22);
            this._tsInsertAfterColumn.Text = "Insertar Columna Posterior";
            // 
            // _tsSeparator2
            // 
            this._tsSeparator2.Name = "_tsSeparator2";
            this._tsSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // _tsFilterColumns
            // 
            this._tsFilterColumns.Image = ((System.Drawing.Image)(resources.GetObject("_tsFilterColumns.Image")));
            this._tsFilterColumns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsFilterColumns.Name = "_tsFilterColumns";
            this._tsFilterColumns.Size = new System.Drawing.Size(203, 22);
            this._tsFilterColumns.Text = "Filtrar Columnas";
            this._tsFilterColumns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataGrid
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DefaultCellStyle = dataGridViewCellStyle3;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersWidth = 25;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_ColumnHeaderMouseClick);
            this.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGrid_CellFormatting);            
            this._cmDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }        
        #endregion

        private System.Collections.ArrayList _ColumnsVisible = null;
        private System.Windows.Forms.ContextMenuStrip _cmDataGrid;
        private System.Windows.Forms.ToolStripMenuItem _tsOrderAscColumn;
        private System.Windows.Forms.ToolStripMenuItem _tsOrderDesColumn;
        private System.Windows.Forms.ToolStripMenuItem _tsClearSort;
        private System.Windows.Forms.ToolStripSeparator _tsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _tsDeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem _tsInsertAfterColumn;
        private System.Windows.Forms.DataGridViewColumn _ActiveColumn;
        private System.Windows.Forms.ToolStripMenuItem _tsInsertBeforeColumn;
        private System.Windows.Forms.ToolStripSeparator _tsSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _tsFilterColumns;
    }
}
