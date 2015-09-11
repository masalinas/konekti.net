using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Konekti.Framework.Plugins;
using Konekti.CoreModel.BussinesObjects;
using Konekti.Framework.Database;
using Konekti.Framework.Configuration;

namespace Konekti.Plugin.MessageManager
{
    public partial class frmCreateMessage : EditForm
    {
        #region Constructor
        public frmCreateMessage()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Properties
        public StdMessage Message
        {
            get { return _message; }
        }
        #endregion

        #region Private Form Events
        private void frmCreateMessage_Load(object sender, EventArgs e)
        {
            //Get the Station Id
            try
            {
                _StationIdFrom = StdStation.GetByStationCode(ContextManager.Context.GetConfig().MessageConfig.StationCode);
            }
            catch (Exception)
            {
            }

            STD_STATION.DataSource = StdStation.QueryAllMessageDestinity(ContextManager.Context.GetConfig().MessageConfig.StationCode);
        }

        private void frmCreateMessage_SaveClicked(object sender, EventArgs e)
        {
            _message = new StdMessage();

            _message.MessageText = _edtMensaje.Text;
            _message.StationIdTo = Convert.ToInt32(_cmbStation.SelectedValue);
            _message.StationIdFrom = _StationIdFrom;
            _message.MessageTypeId = 1;
            _message.CreationDate = DateTime.Now;
            _message.CreationBy = 1;

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private void frmCreateMessage_CancelClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
        #endregion
    }
}