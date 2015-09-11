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

namespace Konekti.Plugin.MessageManager
{
    public partial class frmReadMessage : EditForm
    {
        #region Constructor
        public frmReadMessage()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Properties
        public StdMessage Message
        {
            set 
            { 
                _message = value;

                _edtMensaje.Text = _message.MessageText;
            }
        }
        #endregion

        #region Private Form Events
        private void frmReadMessage_SaveClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private void frmReadMessage_CancelClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
        #endregion
    }
}