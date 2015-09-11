using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Konekti.Framework.UI
{
    public partial class ColumnFilterForm : Form
    {
        public enum InsertionType
        {
            Before,
            After
        }

        #region Constructor
        public ColumnFilterForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Properties
        public DataGrid Grid
        {
            get { return _Grid; }
            set { _Grid = value; }
        }        
        public ArrayList Columns
        {
            set 
            {
                _Columns = value;

                //Add all DataGrids Columns
                foreach (string cl in _Columns)                                                                                
                    _clbShowColumn.Items.Add(cl, false);                               
            }
        }
        public int ColumnPosition
        {
            set { _ColumnPosition = value; }
        }
        public InsertionType Type
        {
            set { _InsertionType = value; }
        }
        #endregion

        #region Private Form Events
        private void _btnSelect_Click(object sender, EventArgs e)
        {
            foreach (string cl in _clbShowColumn.CheckedItems)
            {
                 DataGridViewColumn _column = new DataGridViewColumn();

                _column.CellTemplate = new DataGridViewTextBoxCell();
                _column.Name = cl;
                _column.HeaderText = cl;
                _column.DataPropertyName = cl;
                _column.SortMode = DataGridViewColumnSortMode.Automatic;

                switch(_InsertionType)
                {
                    case InsertionType.Before :
                        _Grid.Columns.Insert(_ColumnPosition, _column);
                        break;
                    case InsertionType.After :
                        _Grid.Columns.Insert(_ColumnPosition + 1, _column);
                        break;
                }                
            }               

            this.Close();
        }
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}