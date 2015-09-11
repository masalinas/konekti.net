using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Konekti.Framework.UI
{
    public partial class DBNavigator : ToolStrip
    {
        #region Constructor
        public DBNavigator()
        {
            InitializeComponent();

            this.Items["_moveFirstButton"].Click += new EventHandler(FirstRegister);
            this.Items["_movePreviousButton"].Click += new EventHandler(PreviousRegister);
            this.Items["_newButton"].Click += new EventHandler(AddRegister);
            this.Items["_deleteButton"].Click += new EventHandler(DeleletRegister);
            this.Items["_editButton"].Click += new EventHandler(EditRegister);
            this.Items["_moveNextButton"].Click += new EventHandler(NextRegister);
            this.Items["_moveLastButton"].Click += new EventHandler(LastRegister);
            this.Items["_refreshButton"].Click += new EventHandler(RefreshRegister);
            this.Items["_moveFirstUpButton"].Click += new EventHandler(FirstUpLevel);
            this.Items["_moveUpButton"].Click += new EventHandler(UpLevel);
            this.Items["_moveDownButton"].Click += new EventHandler(DownLevel);
            this.Items["_moveLastDownButton"].Click += new EventHandler(LastDownLevel);            
        }
        #endregion

        #region Public Control Properties
        /// <summary>
        /// Indicates the BindingSource to control.
        /// </summary>
        [Description("Set the Binding Source to Navigate.")]
        public BindingSource BindingSource
        {
            get
            {
                return _bindingSource;
            }
            set
            {
                _bindingSource = value;              

                if (_bindingSource != null)
                {
                    CheckRow();
                    
                    _bindingSource.CurrentChanged += new EventHandler(_bindingSource_CurrentChanged);
                }
            }
        }

        /// <summary>
        /// Indicates the ToolStrip to control.
        /// </summary>
        [Description("Get ToolStrip.")]
        public ToolStrip ToolStrip
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Indicates whether the New button is visible.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the New button is visible.")]
        public bool ShowNewButton
        {
            get { return _showNewButton; }
            set
            {
                _showNewButton = value;
                this._newButton.Visible = _showNewButton;
            }
        }

        /// <summary>
        /// Indicates whether the Edit button is visible.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Edit button is visible.")]
        public bool ShowEditButton
        {
            get { return _showEditButton; }
            set
            {
                _showEditButton = value;
                this._editButton.Visible = _showEditButton;
            }
        }

        /// <summary>
        /// Indicates whether the Delete button is visible.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Delete button is visible.")]
        public bool ShowDeleteButton
        {
            get { return _showDeleteButtons; }
            set
            {
                _showDeleteButtons = value;
                this._deleteButton.Visible = _showDeleteButtons;
            }
        }

        /// <summary>
        /// Indicates whether the New button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the New button is enable.")]
        public bool EnableNewButton
        {
            get { return _enableNewButton; }
            set
            {
                _enableNewButton = value;
                this._newButton.Enabled = _enableNewButton;
            }
        }

        /// <summary>
        /// Indicates whether the Edit button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Edit button is enable.")]
        public bool EnableEditButton
        {
            get { return _enableEditButton; }
            set
            {
                _enableEditButton = value;
                this._editButton.Enabled = _enableEditButton;
            }
        }

        /// <summary>
        /// Indicates whether the Delete button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Delete button is enable.")]
        public bool EnableDeleteButton
        {
            get { return _enableDeleteButtons; }
            set
            {
                _enableDeleteButtons = value;
                this._deleteButton.Enabled = _enableDeleteButtons;
            }
        }

        /// <summary>
        /// Indicates whether the First Up Level Button is visible.
        /// </summary>
        [DefaultValue(false), Category("Behavior"),
        Description("Indicates whether the First Up Level Button is visible.")]
        public bool ShowFirstUpButton
        {
            get { return _showFirstUpButton; }
            set
            {
                _showFirstUpButton = value;
                this._moveFirstUpButton.Visible = _showFirstUpButton;

                this._lblSeparator3.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
                this._lblSeparator4.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
            }
        }

        /// <summary>
        /// Indicates whether the Up Level Button is visible.
        /// </summary>
        [DefaultValue(false), Category("Behavior"),
        Description("Indicates whether the Up Level Button is visible.")]
        public bool ShowUpButton
        {
            get { return _showUpButton; }
            set
            {
                _showUpButton = value;
                this._moveUpButton.Visible = _showUpButton;

                this._lblSeparator3.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
                this._lblSeparator4.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
            }
        }

        /// <summary>
        /// Indicates whether the Down Level Button is visible.
        /// </summary>
        [DefaultValue(false), Category("Behavior"),
        Description("Indicates whether the Down Level Button is visible.")]
        public bool ShowDownButton
        {
            get { return _showDownButton; }
            set
            {
                _showDownButton = value;
                this._moveDownButton.Visible = _showDownButton;

                this._lblSeparator3.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
                this._lblSeparator4.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
            }
        }

        /// <summary>
        /// Indicates whether the Last Level Button is visible.
        /// </summary>
        [DefaultValue(false), Category("Behavior"),
        Description("Indicates whether the Last Level Button is visible.")]
        public bool ShowLastDownButton
        {
            get { return _showLastDownButton; }
            set
            {
                _showLastDownButton = value;
                this._moveLastDownButton.Visible = _showLastDownButton;

                this._lblSeparator3.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
                this._lblSeparator4.Visible = _showFirstUpButton || _showUpButton || _showDownButton || _showLastDownButton;
            }
        }

        /// <summary>
        /// Indicates whether the First Up Level Button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the First Up Level Button is enable.")]
        public bool EnableFirstUpButton
        {
            get { return _enableFirstUpButton; }
            set
            {
                _enableFirstUpButton = value;
                this._moveFirstUpButton.Enabled = _enableFirstUpButton;
            }
        }

        /// <summary>
        /// Indicates whether the Up Level Button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Up Level Button is enable.")]
        public bool EnableUpButton
        {
            get { return _enableUpButton; }
            set
            {
                _enableUpButton = value;
                this._moveUpButton.Enabled = _enableUpButton;
            }
        }

        /// <summary>
        /// Indicates whether the Down Level Button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Down Level Button is enable.")]
        public bool EnableDownButton
        {
            get { return _enableDownButton; }
            set
            {
                _enableDownButton = value;
                this._moveDownButton.Enabled = _enableDownButton;
            }
        }

        /// <summary>
        /// Indicates whether the Last Level Button is enable.
        /// </summary>
        [DefaultValue(true), Category("Behavior"),
        Description("Indicates whether the Last Level Button is enable.")]
        public bool EnableLastDownButton
        {
            get { return _enableLastDownButton; }
            set
            {
                _enableLastDownButton = value;
                this._moveLastDownButton.Enabled = _enableLastDownButton;
            }
        }
        #endregion

        #region Private Control Events
        public delegate void ButtonEventHandler(object sender, System.EventArgs e);

        public event ButtonEventHandler AddClick;       
        public event ButtonEventHandler DeleteClick;    
        public event ButtonEventHandler EditClick;      
        public event ButtonEventHandler RefreshClick;
        public event ButtonEventHandler FirstUpLevelClick;
        public event ButtonEventHandler UpLevelClick;
        public event ButtonEventHandler DownLevelClick;
        public event ButtonEventHandler LastDownLevelClick;

        private void FirstRegister(object sender, EventArgs e)
        {
            _bindingSource.Position = 0;
        }
        private void PreviousRegister(object sender, EventArgs e)
        {
            _bindingSource.Position--;
        }
        private void NextRegister(object sender, EventArgs e)
        {
            _bindingSource.Position++;
        }
        private void LastRegister(object sender, EventArgs e)
        {
            _bindingSource.Position = _bindingSource.Count - 1;
        }
        public void AddRegister(object sender, EventArgs e)
        {
            if (AddClick != null)
                AddClick(sender, e);
        }
        public void DeleletRegister(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere borrar el registro?", "Borrar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DeleteClick != null)
                    DeleteClick(sender, e);
            }
        }
        public void EditRegister(object sender, EventArgs e)
        {
            if (EditClick != null)
                EditClick(sender, e);
        }
        public void RefreshRegister(object sender, EventArgs e)
        {
            if (RefreshClick != null)
                RefreshClick(sender, e);
        }
        public void FirstUpLevel(object sender, EventArgs e)
        {
            if (FirstUpLevelClick != null)
                FirstUpLevelClick(sender, e);
        }
        public void UpLevel(object sender, EventArgs e)
        {
            if (UpLevelClick != null)
                UpLevelClick(sender, e);
        }
        public void DownLevel(object sender, EventArgs e)
        {
            if (DownLevelClick != null)
                DownLevelClick(sender, e);
        }
        public void LastDownLevel(object sender, EventArgs e)
        {
            if (LastDownLevelClick != null)
                LastDownLevelClick(sender, e);
        }
        private void _bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CheckRow();
            CheckRowInfo();
        }
        #endregion

        #region Private Control Methods
        private void CheckRow()
        {
            if (_bindingSource == null|| _bindingSource.Count == 0)
            {
                this._moveFirstButton.Enabled = this._movePreviousButton.Enabled =
                this._moveLastButton.Enabled = this._moveNextButton.Enabled =
                this._deleteButton.Enabled = this._editButton.Enabled = false;
                this._edtPosition.Text = "";
                this._lblCounter.Text = "";
            }
            else
            {
                this._moveFirstButton.Enabled = this._movePreviousButton.Enabled = 0 < _bindingSource.Position;
                this._moveNextButton.Enabled = this._moveLastButton.Enabled = _bindingSource.Position < _bindingSource.Count - 1;
                this._deleteButton.Enabled = this._editButton.Enabled = true;
                this._edtPosition.Text = Convert.ToString(_bindingSource.Position + 1);
                this._lblCounter.Text = "de {" + Convert.ToString(_bindingSource.Count) + "}";
            }      
        }
        private void CheckRowInfo()
        {
            object _CurrentRow = _bindingSource.Current as object;

            if (_CurrentRow != null && _CurrentRow.GetType().GetProperty("Rowinfo") != null)
            {
                Byte _ByteRow = Convert.ToByte(_CurrentRow.GetType().GetProperty("Rowinfo").GetValue(_CurrentRow, null));

                //Check Bit 0 (Edit Button) RowInfo
                if (Convert.ToBoolean(_ByteRow & 1))
                    this._editButton.Enabled = false;
                else
                    this._editButton.Enabled = true;

                //Check Bit 1 (Delete Button) RowInfo
                if (Convert.ToBoolean(_ByteRow & 2))
                    this._deleteButton.Enabled = false;
                else
                    this._deleteButton.Enabled = true;

                //Check Bit 2 (New Button) RowInfo
                if (Convert.ToBoolean(_ByteRow & 4))
                    this._newButton.Enabled = false;
                else
                    this._newButton.Enabled = true;
            }
        }      
        #endregion
    }
}

