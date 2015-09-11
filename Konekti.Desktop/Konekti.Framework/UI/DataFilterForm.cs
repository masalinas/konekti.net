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
    public partial class DataFilterForm : Form
    {
        #region Constructor
        public DataFilterForm()
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
            set { _Columns = value;}
        }
        #endregion

        #region Private Form Methods
        private void CreateData()
        {
            _FilterColumns = new DataTable("FILTERS");

            _FilterColumns.Columns.Add("Column");
            _FilterColumns.Columns.Add("Operation");
            _FilterColumns.Columns.Add("Value");
        }
        #endregion

        #region Private Form Events
        private void DataFilterForm_Load(object sender, EventArgs e)
        {
            CreateData();            

            //Add all DataGrids Columns
            foreach (string cl in _Columns)
            {               
                DataRow _newRow = _FilterColumns.NewRow();

                _newRow["Column"] = cl;

                _FilterColumns.Rows.Add(_newRow);
            }            

            _dgDataFilter.DataSource = null;
            FILERCOLUMNS.DataSource = _FilterColumns;
            _dgDataFilter.DataSource = FILERCOLUMNS;            
        }
        #endregion

        #region Private Form Events
        private void _btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}