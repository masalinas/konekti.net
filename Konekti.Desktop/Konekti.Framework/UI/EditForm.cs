using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Konekti.Framework.UI
{
    public partial class EditForm : Form
    {
        #region Constructor
        public EditForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Members
        public event EventHandler CancelClicked;
        public event EventHandler SaveClicked;
        #endregion

        #region Design Properties
        [Browsable(true), DefaultValue(true), Category("Behavior"), Description("Indicates whether the Left Button is visible.")]
        public bool ShowLeftButton
        {
            get { return _showLeftButton; }
            set
            {
                _showLeftButton = value;
                fcCancelButton.Visible = _showLeftButton;
            }
        }
        [Browsable(true), DefaultValue("&Cancelar"), Category("Behavior"), Description("Left Button Text.")]
        public string TextLeftButton
        {
            get { return fcCancelButton.Text; }
            set {fcCancelButton.Text = value; }
        }
        [Browsable(true), DefaultValue(true), Category("Behavior"), Description("Indicates whether the Right Button is visible.")]
        public bool ShowRightButtons
        {
            get { return _showRightButton; }
            set
            {
                _showRightButton = value;
                fcSaveButton.Visible = _showRightButton;
            }
        }
        [Browsable(true), DefaultValue("&Guardar"), Category("Behavior"), Description("Left Button Text.")]
        public string TextRightButton
        {
            get { return fcSaveButton.Text; }
            set { fcSaveButton.Text = value; }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Paints:
        ///				- Plugin Icon
        ///				- Plugin Tittle
        ///				- Plugin Line
        ///				
        /// </summary>
        private void PaintHeaderEditForm()
        {
            Graphics g = pnlCustomPaint.CreateGraphics();

            const int iconSize = 32;

            int x = 20;
            int y = 32;

            this.SuspendLayout();

            //line
            Pen pen = new Pen(SystemColors.ActiveCaption, 2);
            Point p1 = new Point(x, y);
            Point p2 = new Point(this.Width - x, y);
            g.DrawLine(pen, p1, p2);
            //line shadow
            pen.Color = SystemColors.Window;
            pen.Width = 0.5F;
            p1.Y++;
            p2.Y++;
            g.DrawLine(pen, p1, p2);
            //icon
            g.DrawIconUnstretched(this.Icon, new Rectangle(x, y - iconSize, iconSize, iconSize));
            //title
            x += iconSize + 3;
            y -= 22;
            Brush brush = new SolidBrush(SystemColors.Window);
            g.DrawString(this.Text, new Font("Arial", 16), brush, x, y);
            //title shadow
            brush = new SolidBrush(SystemColors.ActiveCaption);
            g.DrawString(this.Text, new Font("Arial", 16), brush, ++x, --y);

            this.ResumeLayout();
        }
        #endregion

        #region Private Form Events
        private void pnlCustomPaint_Paint(object sender, PaintEventArgs e)
        {
            PaintHeaderEditForm();
        }

        private void fcSaveButton_Click(object sender, EventArgs e)
        {
            if (SaveClicked != null)
                SaveClicked(sender, e);
        }
        private void fcCancelButton_Click(object sender, EventArgs e)
        {
            if (CancelClicked != null)
                CancelClicked(sender, e);
        }
        #endregion     
    }
}