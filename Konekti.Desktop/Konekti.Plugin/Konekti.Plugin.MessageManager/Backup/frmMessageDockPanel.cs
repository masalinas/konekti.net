using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI;

using Konekti.Framework.Plugins;
using Konekti.CoreModel.BussinesObjects;
using Konekti.Framework.DAL;

namespace Konekti.Plugin.MessageManager
{
    public partial class frmMessageDockPanel : PluginForm
    {
        #region Constructor
        public frmMessageDockPanel()
        {
            InitializeComponent();

            DataTable _Messages = new DataTable("MESSAGES");
            
            _Messages.Columns.Add(new DataColumn("MessageType", typeof(Image))); 
            _Messages.Columns.Add(new DataColumn("MessageText", typeof(string)));
            _Messages.Columns.Add(new DataColumn("StationFrom", typeof(string)));
            _Messages.Columns.Add(new DataColumn("MessageDate", typeof(DateTime)));

            _dgKonektiMessages.Columns["_clMessageType"].DataPropertyName = "MessageType";
            _dgKonektiMessages.Columns["_clDescription"].DataPropertyName = "MessageText";
            _dgKonektiMessages.Columns["_clStationFrom"].DataPropertyName = "StationFrom";
            _dgKonektiMessages.Columns["_clDate"].DataPropertyName = "MessageDate";

            MESSAGES.DataSource = _Messages;
        }
        #endregion

        #region Public Properties
        public BindingSource MessageSource
        {
            get { return MESSAGES; }
        }
        public ImageList MessageTypes
        {
            get { return _ilMessagesType; }
        }
        #endregion

        #region Private Form Events
        private void _tsMenssage_Click(object sender, EventArgs e)
        {
            string _Filter = String.Empty;

            if (_tsErrorMenssage.CheckState == CheckState.Checked)
                _Filter = "MessageType = 1";
            else if (_tsWarningMenssage.CheckState == CheckState.Checked)
                _Filter = " AND MessageType = 2";
            else if (_tsInformationMenssage.CheckState == CheckState.Checked)
                _Filter = " AND MessageType = 3";

            MESSAGES.Filter = _Filter;            

            _dgKonektiMessages.DataSource = MESSAGES;
        }
        private void _dgKonektiMessages_DoubleClick(object sender, EventArgs e)
        {
            _tssSendMessage_Click(sender, e);
        }
        #endregion

        #region Private Menu Events
        private void _tssSendMessage_Click(object sender, EventArgs e)
        {
            StdMessage _StdMessage = MESSAGES.Current as StdMessage;

            if (_StdMessage != null)
            {
                frmCreateMessage _frmCreateMessage = new frmCreateMessage();

                if (_frmCreateMessage.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    PersistenceManager.StartTransaction(IsolationLevel.Serializable);
                    _frmCreateMessage.Message.Persist();
                    PersistenceManager.CommitTransaction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Gestor Entidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    _frmCreateMessage.Dispose();
                }
            }
        }
        private void _tssEditMessage_Click(object sender, EventArgs e)
        {
            StdMessage _StdMessage = MESSAGES.Current as StdMessage;

            if (_StdMessage != null)
            {
                frmReadMessage _frmReadMessage = new frmReadMessage();

                if (_frmReadMessage.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    PersistenceManager.StartTransaction(IsolationLevel.Serializable);
                    _StdMessage.Delete();
                    PersistenceManager.CommitTransaction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Gestor Entidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    _frmReadMessage.Dispose();
                }
            }
        }
        #endregion
    }
}