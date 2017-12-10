namespace proyecto
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label id_citaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label id_tatuajeLabel;
            System.Windows.Forms.Label id_usuarioLabel;
            this.bd = new proyecto.bd();
            this.citaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citaTableAdapter = new proyecto.bdTableAdapters.citaTableAdapter();
            this.tableAdapterManager = new proyecto.bdTableAdapters.TableAdapterManager();
            this.citaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.citaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_citaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.id_tatuajeTextBox = new System.Windows.Forms.TextBox();
            this.id_usuarioComboBox = new System.Windows.Forms.ComboBox();
            this.bdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new proyecto.bdTableAdapters.usuarioTableAdapter();
            this.citaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.citaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            id_citaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            id_tatuajeLabel = new System.Windows.Forms.Label();
            id_usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingNavigator)).BeginInit();
            this.citaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citaBindingSource
            // 
            this.citaBindingSource.DataMember = "cita";
            this.citaBindingSource.DataSource = this.bd;
            // 
            // citaTableAdapter
            // 
            this.citaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.almacenTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.citaTableAdapter = this.citaTableAdapter;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.tatuajeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyecto.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // citaBindingNavigator
            // 
            this.citaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.citaBindingNavigator.BindingSource = this.citaBindingSource;
            this.citaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.citaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.citaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.citaBindingNavigatorSaveItem});
            this.citaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.citaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.citaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.citaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.citaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.citaBindingNavigator.Name = "citaBindingNavigator";
            this.citaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.citaBindingNavigator.Size = new System.Drawing.Size(556, 25);
            this.citaBindingNavigator.TabIndex = 0;
            this.citaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // citaBindingNavigatorSaveItem
            // 
            this.citaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.citaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citaBindingNavigatorSaveItem.Image")));
            this.citaBindingNavigatorSaveItem.Name = "citaBindingNavigatorSaveItem";
            this.citaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.citaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.citaBindingNavigatorSaveItem.Click += new System.EventHandler(this.citaBindingNavigatorSaveItem_Click);
            // 
            // id_citaLabel
            // 
            id_citaLabel.AutoSize = true;
            id_citaLabel.Location = new System.Drawing.Point(29, 54);
            id_citaLabel.Name = "id_citaLabel";
            id_citaLabel.Size = new System.Drawing.Size(38, 13);
            id_citaLabel.TabIndex = 1;
            id_citaLabel.Text = "id cita:";
            // 
            // id_citaTextBox
            // 
            this.id_citaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citaBindingSource, "id_cita", true));
            this.id_citaTextBox.Location = new System.Drawing.Point(90, 51);
            this.id_citaTextBox.Name = "id_citaTextBox";
            this.id_citaTextBox.Size = new System.Drawing.Size(57, 20);
            this.id_citaTextBox.TabIndex = 2;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(29, 133);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.citaBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(90, 129);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(29, 158);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(31, 13);
            horaLabel.TabIndex = 9;
            horaLabel.Text = "hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citaBindingSource, "hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(90, 155);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(67, 20);
            this.horaTextBox.TabIndex = 10;
            // 
            // id_tatuajeLabel
            // 
            id_tatuajeLabel.AutoSize = true;
            id_tatuajeLabel.Location = new System.Drawing.Point(29, 184);
            id_tatuajeLabel.Name = "id_tatuajeLabel";
            id_tatuajeLabel.Size = new System.Drawing.Size(53, 13);
            id_tatuajeLabel.TabIndex = 11;
            id_tatuajeLabel.Text = "id tatuaje:";
            // 
            // id_tatuajeTextBox
            // 
            this.id_tatuajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citaBindingSource, "id_tatuaje", true));
            this.id_tatuajeTextBox.Location = new System.Drawing.Point(90, 181);
            this.id_tatuajeTextBox.Name = "id_tatuajeTextBox";
            this.id_tatuajeTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_tatuajeTextBox.TabIndex = 12;
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Location = new System.Drawing.Point(29, 81);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(55, 13);
            id_usuarioLabel.TabIndex = 12;
            id_usuarioLabel.Text = "id usuario:";
            // 
            // id_usuarioComboBox
            // 
            this.id_usuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citaBindingSource, "id_usuario", true));
            this.id_usuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.citaBindingSource1, "id_usuario", true));
            this.id_usuarioComboBox.DataSource = this.citaBindingSource2;
            this.id_usuarioComboBox.FormattingEnabled = true;
            this.id_usuarioComboBox.Location = new System.Drawing.Point(90, 78);
            this.id_usuarioComboBox.Name = "id_usuarioComboBox";
            this.id_usuarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_usuarioComboBox.TabIndex = 13;
            this.id_usuarioComboBox.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            this.id_usuarioComboBox.ValueMember = "id_usuario";
            this.id_usuarioComboBox.SelectedIndexChanged += new System.EventHandler(this.id_usuarioComboBox_SelectedIndexChanged);
            // 
            // bdBindingSource
            // 
            this.bdBindingSource.DataSource = this.bd;
            this.bdBindingSource.Position = 0;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.bd;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // citaBindingSource1
            // 
            this.citaBindingSource1.DataMember = "cita";
            this.citaBindingSource1.DataSource = this.bd;
            // 
            // citaBindingSource2
            // 
            this.citaBindingSource2.DataMember = "cita";
            this.citaBindingSource2.DataSource = this.bdBindingSource;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 388);
            this.Controls.Add(id_usuarioLabel);
            this.Controls.Add(this.id_usuarioComboBox);
            this.Controls.Add(id_citaLabel);
            this.Controls.Add(this.id_citaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(id_tatuajeLabel);
            this.Controls.Add(this.id_tatuajeTextBox);
            this.Controls.Add(this.citaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingNavigator)).EndInit();
            this.citaBindingNavigator.ResumeLayout(false);
            this.citaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource citaBindingSource;
        private bdTableAdapters.citaTableAdapter citaTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator citaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton citaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_citaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox id_tatuajeTextBox;
        private bdTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox id_usuarioComboBox;
        private System.Windows.Forms.BindingSource bdBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource citaBindingSource1;
        private System.Windows.Forms.BindingSource citaBindingSource2;
    }
}