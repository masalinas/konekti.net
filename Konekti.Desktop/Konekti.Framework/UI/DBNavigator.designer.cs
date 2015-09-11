namespace Konekti.Framework.UI
{
    partial class DBNavigator
    {
        #region Destructor
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
        #endregion

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBNavigator));
            this._moveFirstButton = new System.Windows.Forms.ToolStripButton();
            this._movePreviousButton = new System.Windows.Forms.ToolStripButton();
            this._newButton = new System.Windows.Forms.ToolStripButton();
            this._deleteButton = new System.Windows.Forms.ToolStripButton();
            this._tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._edtPosition = new System.Windows.Forms.ToolStripTextBox();
            this._lblCounter = new System.Windows.Forms.ToolStripLabel();
            this._tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._editButton = new System.Windows.Forms.ToolStripButton();
            this._moveNextButton = new System.Windows.Forms.ToolStripButton();
            this._moveLastButton = new System.Windows.Forms.ToolStripButton();
            this._refreshButton = new System.Windows.Forms.ToolStripButton();
            this._moveFirstUpButton = new System.Windows.Forms.ToolStripButton();
            this._moveUpButton = new System.Windows.Forms.ToolStripButton();
            this._moveDownButton = new System.Windows.Forms.ToolStripButton();
            this._moveLastDownButton = new System.Windows.Forms.ToolStripButton();
            this._lblSeparator3 = new System.Windows.Forms.ToolStripLabel();
            this._lblSeparator4 = new System.Windows.Forms.ToolStripLabel();
            this.SuspendLayout();
            // 
            // _moveFirstButton
            // 
            this._moveFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveFirstButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveFirstButton.Image")));
            this._moveFirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveFirstButton.Name = "_moveFirstButton";
            this._moveFirstButton.Size = new System.Drawing.Size(23, 22);
            this._moveFirstButton.Text = "Primer Registro";
            // 
            // _movePreviousButton
            // 
            this._movePreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._movePreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("_movePreviousButton.Image")));
            this._movePreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._movePreviousButton.Name = "_movePreviousButton";
            this._movePreviousButton.Size = new System.Drawing.Size(23, 22);
            this._movePreviousButton.Text = "Registro Anterior";
            // 
            // _newButton
            // 
            this._newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._newButton.Image = ((System.Drawing.Image)(resources.GetObject("_newButton.Image")));
            this._newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(23, 22);
            this._newButton.Text = "Nuevo Registro";
            // 
            // _deleteButton
            // 
            this._deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("_deleteButton.Image")));
            this._deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(23, 20);
            this._deleteButton.Text = "Borrar Registro";
            // 
            // _tsSeparator1
            // 
            this._tsSeparator1.Name = "_tsSeparator1";
            this._tsSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // _edtPosition
            // 
            this._edtPosition.BackColor = System.Drawing.SystemColors.Window;
            this._edtPosition.Name = "_edtPosition";
            this._edtPosition.ReadOnly = true;
            this._edtPosition.Size = new System.Drawing.Size(50, 23);
            // 
            // _lblCounter
            // 
            this._lblCounter.Name = "_lblCounter";
            this._lblCounter.Size = new System.Drawing.Size(35, 15);
            this._lblCounter.Text = "of {0}";
            // 
            // _tsSeparator2
            // 
            this._tsSeparator2.Name = "_tsSeparator2";
            this._tsSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // _editButton
            // 
            this._editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._editButton.Image = ((System.Drawing.Image)(resources.GetObject("_editButton.Image")));
            this._editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(23, 20);
            this._editButton.Text = "Editar Registro";
            // 
            // _moveNextButton
            // 
            this._moveNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveNextButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveNextButton.Image")));
            this._moveNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveNextButton.Name = "_moveNextButton";
            this._moveNextButton.Size = new System.Drawing.Size(23, 20);
            this._moveNextButton.Text = "Siguiente Registro";
            // 
            // _moveLastButton
            // 
            this._moveLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveLastButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveLastButton.Image")));
            this._moveLastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveLastButton.Name = "_moveLastButton";
            this._moveLastButton.Size = new System.Drawing.Size(23, 20);
            this._moveLastButton.Text = "Ultimo Registro";
            // 
            // _refreshButton
            // 
            this._refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("_refreshButton.Image")));
            this._refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(23, 20);
            this._refreshButton.Text = "Refrescar Grid";
            // 
            // _moveFirstUpButton
            // 
            this._moveFirstUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveFirstUpButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveFirstUpButton.Image")));
            this._moveFirstUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveFirstUpButton.Name = "_moveFirstUpButton";
            this._moveFirstUpButton.Size = new System.Drawing.Size(23, 20);
            this._moveFirstUpButton.Text = "Primer Nivel Detalle";
            this._moveFirstUpButton.ToolTipText = "Primer Nivel Detalle";
            this._moveFirstUpButton.Visible = false;
            // 
            // _moveUpButton
            // 
            this._moveUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveUpButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveUpButton.Image")));
            this._moveUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveUpButton.Name = "_moveUpButton";
            this._moveUpButton.Size = new System.Drawing.Size(23, 20);
            this._moveUpButton.Text = "Bajar Nivel Detalle";
            this._moveUpButton.ToolTipText = "Bajar Nivel Detalle";
            this._moveUpButton.Visible = false;
            // 
            // _moveDownButton
            // 
            this._moveDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveDownButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveDownButton.Image")));
            this._moveDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveDownButton.Name = "_moveDownButton";
            this._moveDownButton.Size = new System.Drawing.Size(23, 20);
            this._moveDownButton.Text = "Subir Nivel Detalle";
            this._moveDownButton.ToolTipText = "Subir Nivel Detalle";
            this._moveDownButton.Visible = false;
            // 
            // _moveLastDownButton
            // 
            this._moveLastDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._moveLastDownButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveLastDownButton.Image")));
            this._moveLastDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveLastDownButton.Name = "_moveLastDownButton";
            this._moveLastDownButton.Size = new System.Drawing.Size(23, 20);
            this._moveLastDownButton.Text = "Último Nivel Detalle";
            this._moveLastDownButton.ToolTipText = "Último Nivel Detalle";
            this._moveLastDownButton.Visible = false;
            // 
            // _lblSeparator3
            // 
            this._lblSeparator3.Name = "_lblSeparator3";
            this._lblSeparator3.Size = new System.Drawing.Size(13, 15);
            this._lblSeparator3.Text = "  ";
            this._lblSeparator3.Visible = false;
            // 
            // _lblSeparator4
            // 
            this._lblSeparator4.Name = "_lblSeparator4";
            this._lblSeparator4.Size = new System.Drawing.Size(13, 15);
            this._lblSeparator4.Text = "  ";
            this._lblSeparator4.Visible = false;
            // 
            // DBNavigator
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._moveFirstButton,
            this._movePreviousButton,
            this._newButton,
            this._deleteButton,
            this._tsSeparator1,
            this._edtPosition,
            this._lblCounter,
            this._tsSeparator2,
            this._editButton,
            this._moveNextButton,
            this._moveLastButton,
            this._lblSeparator3,
            this._moveFirstUpButton,
            this._moveUpButton,
            this._moveDownButton,
            this._moveLastDownButton,
            this._lblSeparator4,
            this._refreshButton});
            this.ResumeLayout(false);

        }

        #endregion

        #region Private Members
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ToolStripButton _moveFirstButton;
        private System.Windows.Forms.ToolStripButton _movePreviousButton;
        private System.Windows.Forms.ToolStripButton _newButton;
        private System.Windows.Forms.ToolStripButton _deleteButton;
        private System.Windows.Forms.ToolStripSeparator _tsSeparator1;
        private System.Windows.Forms.ToolStripTextBox _edtPosition;
        private System.Windows.Forms.ToolStripLabel _lblCounter;
        private System.Windows.Forms.ToolStripSeparator _tsSeparator2;
        private System.Windows.Forms.ToolStripButton _editButton;
        private System.Windows.Forms.ToolStripButton _moveNextButton;
        private System.Windows.Forms.ToolStripButton _moveLastButton;
        private System.Windows.Forms.ToolStripButton _refreshButton;
        private System.Windows.Forms.BindingSource _bindingSource;
        private System.Windows.Forms.ToolStripButton _moveFirstUpButton;
        private System.Windows.Forms.ToolStripButton _moveUpButton;
        private System.Windows.Forms.ToolStripButton _moveDownButton;
        private System.Windows.Forms.ToolStripButton _moveLastDownButton;
        private System.Windows.Forms.ToolStripLabel _lblSeparator3;
        private System.Windows.Forms.ToolStripLabel _lblSeparator4;

        private bool _showNewButton = true;
        private bool _showEditButton = true;
        private bool _showDeleteButtons = true;

        private bool _enableNewButton = true;
        private bool _enableEditButton = true;
        private bool _enableDeleteButtons = true;

        private bool _showFirstUpButton = false;
        private bool _showUpButton = false;
        private bool _showDownButton = false;
        private bool _showLastDownButton = false;

        private bool _enableFirstUpButton = true;
        private bool _enableUpButton = true;
        private bool _enableDownButton = true;
        private bool _enableLastDownButton = true;
        #endregion
    }
}
