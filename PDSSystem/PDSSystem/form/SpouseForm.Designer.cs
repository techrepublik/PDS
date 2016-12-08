namespace PDSSystem.form
{
    partial class SpouseForm
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
            System.Windows.Forms.Label spouseSurNameLabel;
            System.Windows.Forms.Label spouseFirstNameLabel;
            System.Windows.Forms.Label spouseMiddleNameLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label employerLabel;
            System.Windows.Forms.Label employerAddressLabel;
            System.Windows.Forms.Label telephoneNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpouseForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.telephoneNoTextBox = new System.Windows.Forms.TextBox();
            this.employerAddressTextBox = new System.Windows.Forms.TextBox();
            this.employerTextBox = new System.Windows.Forms.TextBox();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.spouseMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.spouseFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.spouseSurNameTextBox = new System.Windows.Forms.TextBox();
            this.childrenDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.spousBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.spousBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.childrensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.spousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            spouseSurNameLabel = new System.Windows.Forms.Label();
            spouseFirstNameLabel = new System.Windows.Forms.Label();
            spouseMiddleNameLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            employerLabel = new System.Windows.Forms.Label();
            employerAddressLabel = new System.Windows.Forms.Label();
            telephoneNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spousBindingNavigator)).BeginInit();
            this.spousBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spouseSurNameLabel
            // 
            spouseSurNameLabel.AutoSize = true;
            spouseSurNameLabel.Location = new System.Drawing.Point(19, 51);
            spouseSurNameLabel.Name = "spouseSurNameLabel";
            spouseSurNameLabel.Size = new System.Drawing.Size(96, 13);
            spouseSurNameLabel.TabIndex = 0;
            spouseSurNameLabel.Text = "Spouse Sur Name:";
            // 
            // spouseFirstNameLabel
            // 
            spouseFirstNameLabel.AutoSize = true;
            spouseFirstNameLabel.Location = new System.Drawing.Point(20, 75);
            spouseFirstNameLabel.Name = "spouseFirstNameLabel";
            spouseFirstNameLabel.Size = new System.Drawing.Size(99, 13);
            spouseFirstNameLabel.TabIndex = 2;
            spouseFirstNameLabel.Text = "Spouse First Name:";
            // 
            // spouseMiddleNameLabel
            // 
            spouseMiddleNameLabel.AutoSize = true;
            spouseMiddleNameLabel.Location = new System.Drawing.Point(8, 101);
            spouseMiddleNameLabel.Name = "spouseMiddleNameLabel";
            spouseMiddleNameLabel.Size = new System.Drawing.Size(111, 13);
            spouseMiddleNameLabel.TabIndex = 4;
            spouseMiddleNameLabel.Text = "Spouse Middle Name:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new System.Drawing.Point(54, 125);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(65, 13);
            occupationLabel.TabIndex = 6;
            occupationLabel.Text = "Occupation:";
            // 
            // employerLabel
            // 
            employerLabel.AutoSize = true;
            employerLabel.Location = new System.Drawing.Point(19, 150);
            employerLabel.Name = "employerLabel";
            employerLabel.Size = new System.Drawing.Size(100, 13);
            employerLabel.TabIndex = 8;
            employerLabel.Text = "Employer/Business:";
            // 
            // employerAddressLabel
            // 
            employerAddressLabel.AutoSize = true;
            employerAddressLabel.Location = new System.Drawing.Point(19, 173);
            employerAddressLabel.Name = "employerAddressLabel";
            employerAddressLabel.Size = new System.Drawing.Size(93, 13);
            employerAddressLabel.TabIndex = 10;
            employerAddressLabel.Text = "Business Address:";
            // 
            // telephoneNoLabel
            // 
            telephoneNoLabel.AutoSize = true;
            telephoneNoLabel.Location = new System.Drawing.Point(41, 198);
            telephoneNoLabel.Name = "telephoneNoLabel";
            telephoneNoLabel.Size = new System.Drawing.Size(78, 13);
            telephoneNoLabel.TabIndex = 12;
            telephoneNoLabel.Text = "Telephone No:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.isActiveCheckBox);
            this.splitContainer1.Panel1.Controls.Add(telephoneNoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.telephoneNoTextBox);
            this.splitContainer1.Panel1.Controls.Add(employerAddressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.employerAddressTextBox);
            this.splitContainer1.Panel1.Controls.Add(employerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.employerTextBox);
            this.splitContainer1.Panel1.Controls.Add(occupationLabel);
            this.splitContainer1.Panel1.Controls.Add(this.occupationTextBox);
            this.splitContainer1.Panel1.Controls.Add(spouseMiddleNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.spouseMiddleNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(spouseFirstNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.spouseFirstNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(spouseSurNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.spouseSurNameTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.childrenDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(628, 489);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // telephoneNoTextBox
            // 
            this.telephoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "TelephoneNo", true));
            this.telephoneNoTextBox.Location = new System.Drawing.Point(125, 195);
            this.telephoneNoTextBox.Name = "telephoneNoTextBox";
            this.telephoneNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneNoTextBox.TabIndex = 6;
            // 
            // employerAddressTextBox
            // 
            this.employerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "EmployerAddress", true));
            this.employerAddressTextBox.Location = new System.Drawing.Point(125, 170);
            this.employerAddressTextBox.Name = "employerAddressTextBox";
            this.employerAddressTextBox.Size = new System.Drawing.Size(357, 20);
            this.employerAddressTextBox.TabIndex = 5;
            // 
            // employerTextBox
            // 
            this.employerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "Employer", true));
            this.employerTextBox.Location = new System.Drawing.Point(125, 146);
            this.employerTextBox.Name = "employerTextBox";
            this.employerTextBox.Size = new System.Drawing.Size(357, 20);
            this.employerTextBox.TabIndex = 4;
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "Occupation", true));
            this.occupationTextBox.Location = new System.Drawing.Point(125, 122);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(357, 20);
            this.occupationTextBox.TabIndex = 3;
            // 
            // spouseMiddleNameTextBox
            // 
            this.spouseMiddleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "SpouseMiddleName", true));
            this.spouseMiddleNameTextBox.Location = new System.Drawing.Point(125, 98);
            this.spouseMiddleNameTextBox.Name = "spouseMiddleNameTextBox";
            this.spouseMiddleNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.spouseMiddleNameTextBox.TabIndex = 2;
            // 
            // spouseFirstNameTextBox
            // 
            this.spouseFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "SpouseFirstName", true));
            this.spouseFirstNameTextBox.Location = new System.Drawing.Point(125, 72);
            this.spouseFirstNameTextBox.Name = "spouseFirstNameTextBox";
            this.spouseFirstNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.spouseFirstNameTextBox.TabIndex = 1;
            // 
            // spouseSurNameTextBox
            // 
            this.spouseSurNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spousBindingSource, "SpouseSurName", true));
            this.spouseSurNameTextBox.Location = new System.Drawing.Point(125, 48);
            this.spouseSurNameTextBox.Name = "spouseSurNameTextBox";
            this.spouseSurNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.spouseSurNameTextBox.TabIndex = 0;
            // 
            // childrenDataGridView
            // 
            this.childrenDataGridView.AutoGenerateColumns = false;
            this.childrenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.childrenDataGridView.DataSource = this.childrenBindingSource;
            this.childrenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenDataGridView.Location = new System.Drawing.Point(0, 23);
            this.childrenDataGridView.Name = "childrenDataGridView";
            this.childrenDataGridView.RowHeadersWidth = 30;
            this.childrenDataGridView.Size = new System.Drawing.Size(628, 206);
            this.childrenDataGridView.TabIndex = 0;
            this.childrenDataGridView.Enter += new System.EventHandler(this.childrenDataGridView_Enter);
            this.childrenDataGridView.Leave += new System.EventHandler(this.childrenDataGridView_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 23);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Children";
            // 
            // spousBindingNavigator
            // 
            this.spousBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.spousBindingNavigator.BindingSource = this.spousBindingSource;
            this.spousBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.spousBindingNavigator.DeleteItem = null;
            this.spousBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.spousBindingNavigatorSaveItem});
            this.spousBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.spousBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.spousBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.spousBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.spousBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.spousBindingNavigator.Name = "spousBindingNavigator";
            this.spousBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.spousBindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.spousBindingNavigator.TabIndex = 1;
            this.spousBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // spousBindingNavigatorSaveItem
            // 
            this.spousBindingNavigatorSaveItem.Enabled = false;
            this.spousBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("spousBindingNavigatorSaveItem.Image")));
            this.spousBindingNavigatorSaveItem.Name = "spousBindingNavigatorSaveItem";
            this.spousBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.spousBindingNavigatorSaveItem.Text = "Save Data";
            this.spousBindingNavigatorSaveItem.Click += new System.EventHandler(this.spousBindingNavigatorSaveItem_Click);
            // 
            // childrensBindingSource
            // 
            this.childrensBindingSource.DataMember = "Childrens";
            this.childrensBindingSource.DataSource = this.spousBindingSource;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.spousBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(125, 221);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isActiveCheckBox.TabIndex = 15;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // spousBindingSource
            // 
            this.spousBindingSource.DataSource = typeof(PDSSystem.dal.data.Spous);
            this.spousBindingSource.CurrentChanged += new System.EventHandler(this.spousBindingSource_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChildrenLastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChildrenFirstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChildrenMiddleName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChildrenBirthDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Birth Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // childrenBindingSource
            // 
            this.childrenBindingSource.DataSource = typeof(PDSSystem.dal.data.Children);
            // 
            // SpouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 489);
            this.Controls.Add(this.spousBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SpouseForm";
            this.Text = "Spouse Form";
            this.Load += new System.EventHandler(this.SpouseForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spousBindingNavigator)).EndInit();
            this.spousBindingNavigator.ResumeLayout(false);
            this.spousBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox telephoneNoTextBox;
        private System.Windows.Forms.BindingSource spousBindingSource;
        private System.Windows.Forms.TextBox employerAddressTextBox;
        private System.Windows.Forms.TextBox employerTextBox;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.TextBox spouseMiddleNameTextBox;
        private System.Windows.Forms.TextBox spouseFirstNameTextBox;
        private System.Windows.Forms.TextBox spouseSurNameTextBox;
        private System.Windows.Forms.BindingNavigator spousBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton spousBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource childrenBindingSource;
        private System.Windows.Forms.BindingSource childrensBindingSource;
        private System.Windows.Forms.DataGridView childrenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
    }
}