using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Konekti.Framework.Controls;

namespace Konekti.Plugin.MessageManager
{
    public class MessageManager
    {
        #region Private Members
        private ImageList _MessageTypesImages;
        private BindingSource _MessageGrid;
        #endregion

        #region Public Enum Class
        public enum MessageType
        {
            ERROR = 1,
            WARNING,
            INFORMATION
        }
        #endregion

        #region Constructor
        public MessageManager(BindingSource MessageGrid, ImageList MessageTypesImages)
        {
            this._MessageGrid = MessageGrid;
            this._MessageTypesImages = MessageTypesImages;
        }
        #endregion

        #region Public Methods
        public void AddMessageSin(string Message)
        {
            MessageBox.Show(Message);
        }
        public void AddMessage(string Message, MessageType Type)
        {
            DataGridViewRow _Row = _MessageGrid.AddNew() as DataGridViewRow;
                
            switch (Type)
            {
                case MessageType.ERROR :
                    _Row.Cells[0].Value = _MessageTypesImages.Images["ERROR"];
                    _Row.Cells[1].Value = Message;
                    _Row.Cells[2].Value = DateTime.Now;
                    break;
                case MessageType.WARNING :
                    _Row.Cells[0].Value = _MessageTypesImages.Images["WARNING"];
                    _Row.Cells[1].Value = Message;
                    _Row.Cells[2].Value = DateTime.Now;
                    break;
                case MessageType.INFORMATION :
                    _Row.Cells[0].Value = _MessageTypesImages.Images["INFORMATION"];
                    _Row.Cells[1].Value = Message;
                    _Row.Cells[2].Value = DateTime.Now;
                    break;
            }
        }
        #endregion
    }
}
