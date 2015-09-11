using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Reflection;

namespace Konekti.Framework.UI
{
    public enum ColumnStyle
    {
        TextBoxColumn,
        CheckBoxColumn,
        ImageColumn,
        ButtonColumn,                
        ComboBoxColumn,
        LinkColumn
    }

    public partial class DataGrid : DataGridView
    {                
        #region Constructor
        public DataGrid()
        {
            InitializeComponent();

            //Not AutoCreate all the Columns. Create at runtime.
            this.AutoGenerateColumns = false;

            //Columnas Visible
            _ColumnsVisible = new ArrayList();

            this._cmDataGrid.Items["_tsOrderAscColumn"].Click += new EventHandler(_tsOrderAscColumn_Click);
            this._cmDataGrid.Items["_tsOrderDesColumn"].Click += new EventHandler(_tsOrderDesColumn_Click);
            this._cmDataGrid.Items["_tsClearSort"].Click += new EventHandler(_tsClearSort_Click);
            this._cmDataGrid.Items["_tsDeleteColumn"].Click += new EventHandler(_tsDeleteColumn_Click);
            this._cmDataGrid.Items["_tsInsertBeforeColumn"].Click += new EventHandler(_tsInsertBeforeColumn_Click);
            this._cmDataGrid.Items["_tsInsertAfterColumn"].Click += new EventHandler(_tsInsertAfterColumn_Click);
            this._cmDataGrid.Items["_tsFilterColumns"].Click += new EventHandler(_tsFilterColumns_Click);                                    
        }
        #endregion     

        #region Private Menu Grid Options
        private void _tsOrderAscColumn_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderDesColumn"]).Checked = false;
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsClearSort"]).Enabled = true;

            this.Sort(_ActiveColumn, ListSortDirection.Ascending);
        }
        private void _tsOrderDesColumn_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderAscColumn"]).Checked = false;
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsClearSort"]).Enabled = true;

            this.Sort(_ActiveColumn, ListSortDirection.Descending);
        }
        private void _tsClearSort_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderAscColumn"]).Checked = false;
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderDesColumn"]).Checked = false;
            ((ToolStripMenuItem)_cmDataGrid.Items["_tsClearSort"]).Enabled = false;

            //this.Sort(new RowComparer(SortOrder.None));
        }
        private void _tsDeleteColumn_Click(object sender, EventArgs e)
        {
            this.Columns.Remove(_ActiveColumn);
        }
        private void _tsInsertBeforeColumn_Click(object sender, EventArgs e)
        {
            ArrayList _Columns = new ArrayList();

            if (((BindingSource)this.DataSource).GetType().Equals(typeof(DataTable)))
            {
                DataColumnCollection _ColumnsCollection = ((DataTable)((BindingSource)this.DataSource).DataSource).Columns;

                foreach (DataColumn pi in _ColumnsCollection)
                {
                    if (!this.Columns.Contains(pi.ColumnName))
                        _Columns.Add(pi.ColumnName);
                }
            }
            else
            {
                PropertyInfo[] _ColumnsPropertyInfo = ((BindingSource)this.DataSource).DataSource.GetType().GetProperty("Item").PropertyType.GetProperties();

                foreach (PropertyInfo pi in _ColumnsPropertyInfo)
                {
                    if (!this.Columns.Contains(pi.Name))
                        _Columns.Add(pi.Name);
                }
            }

            ColumnFilterForm _ColumnFilterForm = new ColumnFilterForm();
            _ColumnFilterForm.Columns = _Columns;
            _ColumnFilterForm.ColumnPosition = _ActiveColumn.Index;
            _ColumnFilterForm.Grid = this;
            _ColumnFilterForm.Type = ColumnFilterForm.InsertionType.Before;

            _ColumnFilterForm.ShowDialog();
        }
        private void _tsInsertAfterColumn_Click(object sender, EventArgs e)
        {            
            ArrayList _Columns = new ArrayList();

            if (((BindingSource)this.DataSource).DataSource.GetType().Equals(typeof(DataTable)))
            {
                DataColumnCollection _ColumnsCollection = ((DataTable)((BindingSource)this.DataSource).DataSource).Columns;

                foreach (DataColumn pi in _ColumnsCollection)
                {
                    if (!this.Columns.Contains(pi.ColumnName))
                        _Columns.Add(pi.ColumnName);
                }
            }
            else
            {
                PropertyInfo[] _ColumnsPropertyInfo = ((BindingSource)this.DataSource).DataSource.GetType().GetProperty("Item").PropertyType.GetProperties();

                foreach (PropertyInfo pi in _ColumnsPropertyInfo)
                {
                    if (!this.Columns.Contains(pi.Name))
                        _Columns.Add(pi.Name);
                }
            }

            ColumnFilterForm _ColumnFilterForm = new ColumnFilterForm();
            _ColumnFilterForm.Columns = _Columns;
            _ColumnFilterForm.ColumnPosition = _ActiveColumn.Index;
            _ColumnFilterForm.Grid = this;
            _ColumnFilterForm.Type = ColumnFilterForm.InsertionType.After;

            _ColumnFilterForm.ShowDialog();            
        }
        private void _tsFilterColumns_Click(object sender, EventArgs e)
        {
            ArrayList _Columns = new ArrayList();

            if (((BindingSource)this.DataSource).GetType().Equals(typeof(DataTable)))
            {
                DataColumnCollection _ColumnsCollection = ((DataTable)((BindingSource)this.DataSource).DataSource).Columns;

                foreach (DataColumn pi in _ColumnsCollection)
                {                    
                   _Columns.Add(pi.ColumnName);
                }
            }
            else
            {
                PropertyInfo[] _ColumnsPropertyInfo = ((BindingSource)this.DataSource).DataSource.GetType().GetProperty("Item").PropertyType.GetProperties();

                foreach (PropertyInfo pi in _ColumnsPropertyInfo)
                {
                   _Columns.Add(pi.Name);
                }
            }

            DataFilterForm _DataFilterForm = new DataFilterForm();
            _DataFilterForm.Columns = _Columns;
            _DataFilterForm.Grid = this;

            _DataFilterForm.ShowDialog();
        }
        #endregion

        #region Private Methods
        /*Persist the Column Order in HardDisk*/
        private void CacheDisplayOrder()
        {
            IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly();
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("DisplayCache", FileMode.Create, isoFile))
            {
                int[] displayIndices = new int[this.ColumnCount];
                for (int i = 0; i < this.ColumnCount; i++)
                {
                    displayIndices[i] = this.Columns[i].DisplayIndex;
                }
                XmlSerializer ser = new XmlSerializer(typeof(int[]));
                ser.Serialize(isoStream, displayIndices);
            }
        }
        private void SetDisplayOrder()
        {
            IsolatedStorageFile isoFile = IsolatedStorageFile.GetUserStoreForAssembly();
            string[] fileNames = isoFile.GetFileNames("*");
            bool found = false;

            foreach (string fileName in fileNames)
            {
                if (fileName == "DisplayCache")
                    found = true;
            }

            if (!found)
                return;

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("DisplayCache", FileMode.Open, isoFile))
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(int[]));
                    int[] displayIndicies = (int[])ser.Deserialize(isoStream);
                    for (int i = 0; i < displayIndicies.Length; i++)
                    {
                        this.Columns[i].DisplayIndex = displayIndicies[i];
                    }
                }
                catch { }
            }
        }
        #endregion

        #region Public Properties
        public ArrayList ColumnsVisible
        {
            get { return _ColumnsVisible; }
        }
        #endregion

        #region Public Interface
        public void ClearColumns()
        {
            this.Columns.Clear();
        }

        public void SetColumnVisible(string ColumnName, int ColumnPosition)
        {
            DataGridViewColumn _column = new DataGridViewColumn();

            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = ColumnName;
            _column.DataPropertyName = ColumnName;
            _column.DisplayIndex = ColumnPosition;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        public void SetColumnVisible(string ColumnName, string DisplayName, int ColumnPosition)
        {
            DataGridViewColumn _column = new DataGridViewColumn();

            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = DisplayName;
            _column.DataPropertyName = ColumnName;
            _column.DisplayIndex = ColumnPosition;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        public void SetColumnVisible(string ColumnName, string DisplayName, int ColumnPosition, ColumnStyle Style)
        {
            DataGridViewColumn _column = new DataGridViewColumn();

            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = DisplayName;
            _column.DataPropertyName = ColumnName;
            _column.DisplayIndex = ColumnPosition;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;

            switch (Style)
            {
                case ColumnStyle.CheckBoxColumn:
                    _column.CellTemplate = new DataGridViewCheckBoxCell(true);
                    break;
                case ColumnStyle.ImageColumn:
                    _column.CellTemplate = new DataGridViewImageCell();
                    break;
                case ColumnStyle.ComboBoxColumn:
                    _column.CellTemplate = new DataGridViewComboBoxCell();
                    break;
                case ColumnStyle.LinkColumn:
                    _column.CellTemplate = new DataGridViewLinkCell();
                    break;
                case ColumnStyle.ButtonColumn:
                    _column.CellTemplate = new DataGridViewButtonCell();
                    break;
            }

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        public void SetColumnVisible(string ColumnName, string DisplayName, int Width, int ColumnPosition)
        {
            DataGridViewColumn _column = new DataGridViewColumn();
            
            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = DisplayName;
            _column.DataPropertyName = ColumnName;
            if (this.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.Fill)
            {
                _column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                _column.FillWeight = Width;
            }
            else
                _column.Width = Width;
            _column.DisplayIndex = ColumnPosition;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        public void SetColumnVisible(string ColumnName, string DisplayName, int Width, int ColumnPosition, ColumnStyle Style)
        {            
            DataGridViewColumn _column = new DataGridViewColumn();

            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = DisplayName;
            _column.DataPropertyName = ColumnName;
            if (this.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.Fill)
            {
                _column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                _column.FillWeight = Width;
            }
            else
                _column.Width = Width;
            _column.DisplayIndex = ColumnPosition;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;

            switch(Style)
            {
                case ColumnStyle.CheckBoxColumn:
                    _column.CellTemplate = new DataGridViewCheckBoxCell(true);
                    break;
                case ColumnStyle.ImageColumn:
                    _column.CellTemplate = new DataGridViewImageCell();
                    break;
                case ColumnStyle.ComboBoxColumn:
                    _column.CellTemplate = new DataGridViewComboBoxCell();
                    break;
                case ColumnStyle.LinkColumn:
                    _column.CellTemplate = new DataGridViewLinkCell();
                    break;
                case ColumnStyle.ButtonColumn:
                    _column.CellTemplate = new DataGridViewButtonCell();
                    break;
            }            

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        public void SetColumnVisible(string ColumnName, string DisplayName, int Width, int ColumnPosition, DataGridViewAutoSizeColumnMode AutoSizeColumnMode)
        {
            DataGridViewColumn _column = new DataGridViewColumn();

            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = DisplayName;
            _column.DataPropertyName = ColumnName;
            _column.Width = Width;
            _column.DisplayIndex = ColumnPosition;
            _column.AutoSizeMode = AutoSizeColumnMode;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        public void SetColumnVisible(string ColumnName, string DisplayName, int Width, int ColumnPosition, ColumnStyle Style, DataGridViewAutoSizeColumnMode AutoSizeColumnMode)
        {
            DataGridViewColumn _column = new DataGridViewColumn();

            _column.CellTemplate = new DataGridViewTextBoxCell();
            _column.Name = ColumnName;
            _column.HeaderText = DisplayName;
            _column.DataPropertyName = ColumnName;
            _column.Width = Width;
            _column.DisplayIndex = ColumnPosition;
            _column.AutoSizeMode = AutoSizeColumnMode;
            _column.SortMode = DataGridViewColumnSortMode.Automatic;
            
            switch (Style)
            {
                case ColumnStyle.CheckBoxColumn:
                    _column.CellTemplate = new DataGridViewCheckBoxCell(true);
                    break;
                case ColumnStyle.ImageColumn:
                    _column.CellTemplate = new DataGridViewImageCell();
                    break;
                case ColumnStyle.ComboBoxColumn:
                    _column.CellTemplate = new DataGridViewComboBoxCell();
                    break;
                case ColumnStyle.LinkColumn:
                    _column.CellTemplate = new DataGridViewLinkCell();
                    break;
                case ColumnStyle.ButtonColumn:
                    _column.CellTemplate = new DataGridViewButtonCell();
                    break;
            }

            this.Columns.Add(_column);
            this._ColumnsVisible.Add(ColumnName);
        }
        #endregion

        #region Private Control Events
        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {        
                _ActiveColumn = this.Columns[e.ColumnIndex];

                if (this.SortedColumn != null && this.SortedColumn.Name == _ActiveColumn.Name)
                {
                    switch (this.SortOrder)
                    {
                        case SortOrder.Descending:
                            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderDesColumn"]).Checked = true;
                            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderAscColumn"]).Checked = false;
                            break;
                        case SortOrder.Ascending:
                            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderDesColumn"]).Checked = false;
                            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderAscColumn"]).Checked = true;
                            break;
                        case SortOrder.None:
                            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderDesColumn"]).Checked = false;
                            ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderAscColumn"]).Checked = false;
                            break;
                    }
                }
                else
                {
                    ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderDesColumn"]).Checked = false;
                    ((ToolStripMenuItem)_cmDataGrid.Items["_tsOrderAscColumn"]).Checked = false;
                }
                
                _ActiveColumn.ContextMenuStrip = _cmDataGrid;

                _cmDataGrid.Show(this, e.Location.X, e.Location.Y);
            }
        }
        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow Row = this.Rows[e.RowIndex];

            object RowObject = Row.DataBoundItem;

            if (RowObject != null && RowObject.GetType().GetProperty("Rowinfo") != null)
            {
                Byte _ByteRow = Convert.ToByte(RowObject.GetType().GetProperty("Rowinfo").GetValue(RowObject, null));

                //Check Bit 0 (Edit Button) RowInfo or Check Bit 1 (Delete Button) RowInfo
                if (Convert.ToBoolean(_ByteRow & 1) || Convert.ToBoolean(_ByteRow & 2))
                    e.CellStyle.BackColor = Color.LightCoral;
            }
        }
        #endregion       
    }
}
