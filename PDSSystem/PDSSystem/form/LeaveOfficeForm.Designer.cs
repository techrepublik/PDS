namespace PDSSystem.form
{
    partial class LeaveOfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveOfficeForm));
            System.Windows.Forms.Label personnelNoLabel;
            System.Windows.Forms.Label officeAgencyLabel;
            System.Windows.Forms.Label dateFiledLabel;
            System.Windows.Forms.Label basicSalaryLabel;
            System.Windows.Forms.Label positionLabel;
            this.leaveOfficeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.leaveOfficeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personnelNoComboBox = new System.Windows.Forms.ComboBox();
            this.officeAgencyTextBox = new System.Windows.Forms.TextBox();
            this.dateFiledDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.basicSalaryTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.leaveOfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            personnelNoLabel = new System.Windows.Forms.Label();
            officeAgencyLabel = new System.Windows.Forms.Label();
            dateFiledLabel = new System.Windows.Forms.Label();
            basicSalaryLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leaveOfficeBindingNavigator)).BeginInit();
            this.leaveOfficeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveOfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveOfficeBindingNavigator
            // 
            this.leaveOfficeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.leaveOfficeBindingNavigator.BindingSource = this.leaveOfficeBindingSource;
            this.leaveOfficeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.leaveOfficeBindingNavigator.DeleteItem = null;
            this.leaveOfficeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.leaveOfficeBindingNavigatorSaveItem});
            this.leaveOfficeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.leaveOfficeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.leaveOfficeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.leaveOfficeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.leaveOfficeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.leaveOfficeBindingNavigator.Name = "leaveOfficeBindingNavigator";
            this.leaveOfficeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.leaveOfficeBindingNavigator.Size = new System.Drawing.Size(612, 25);
            this.leaveOfficeBindingNavigator.TabIndex = 0;
            this.leaveOfficeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // leaveOfficeBindingNavigatorSaveItem
            // 
            this.leaveOfficeBindingNavigatorSaveItem.Enabled = false;
            this.leaveOfficeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("leaveOfficeBindingNavigatorSaveItem.Image")));
            this.leaveOfficeBindingNavigatorSaveItem.Name = "leaveOfficeBindingNavigatorSaveItem";
            this.leaveOfficeBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.leaveOfficeBindingNavigatorSaveItem.Text = "Save Data";
            this.leaveOfficeBindingNavigatorSaveItem.Click += new System.EventHandler(this.leaveOfficeBindingNavigatorSaveItem_Click);
            // 
            // personnelNoLabel
            // 
            personnelNoLabel.AutoSize = true;
            personnelNoLabel.Location = new System.Drawing.Point(20, 51);
            personnelNoLabel.Name = "personnelNoLabel";
            personnelNoLabel.Size = new System.Drawing.Size(57, 13);
            personnelNoLabel.TabIndex = 1;
            personnelNoLabel.Text = "Personnel:";
            // 
            // personnelNoComboBox
            // 
            this.personnelNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.personnelNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.personnelNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.leaveOfficeBindingSource, "PersonnelNo", true));
            this.personnelNoComboBox.DataSource = this.employeeObjBindingSource;
            this.personnelNoComboBox.DisplayMember = "FullName";
            this.personnelNoComboBox.FormattingEnabled = true;
            this.personnelNoComboBox.Location = new System.Drawing.Point(116, 48);
            this.personnelNoComboBox.Name = "personnelNoComboBox";
            this.personnelNoComboBox.Size = new System.Drawing.Size(413, 21);
            this.personnelNoComboBox.TabIndex = 2;
            this.personnelNoComboBox.ValueMember = "PersonnelNo";
            // 
            // officeAgencyLabel
            // 
            officeAgencyLabel.AutoSize = true;
            officeAgencyLabel.Location = new System.Drawing.Point(20, 77);
            officeAgencyLabel.Name = "officeAgencyLabel";
            officeAgencyLabel.Size = new System.Drawing.Size(77, 13);
            officeAgencyLabel.TabIndex = 3;
            officeAgencyLabel.Text = "Office Agency:";
            // 
            // officeAgencyTextBox
            // 
            this.officeAgencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveOfficeBindingSource, "OfficeAgency", true));
            this.officeAgencyTextBox.Location = new System.Drawing.Point(116, 74);
            this.officeAgencyTextBox.Name = "officeAgencyTextBox";
            this.officeAgencyTextBox.Size = new System.Drawing.Size(413, 20);
            this.officeAgencyTextBox.TabIndex = 4;
            // 
            // dateFiledLabel
            // 
            dateFiledLabel.AutoSize = true;
            dateFiledLabel.Location = new System.Drawing.Point(20, 106);
            dateFiledLabel.Name = "dateFiledLabel";
            dateFiledLabel.Size = new System.Drawing.Size(58, 13);
            dateFiledLabel.TabIndex = 5;
            dateFiledLabel.Text = "Date Filed:";
            // 
            // dateFiledDateTimePicker
            // 
            this.dateFiledDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveOfficeBindingSource, "DateFiled", true));
            this.dateFiledDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFiledDateTimePicker.Location = new System.Drawing.Point(116, 99);
            this.dateFiledDateTimePicker.Name = "dateFiledDateTimePicker";
            this.dateFiledDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.dateFiledDateTimePicker.TabIndex = 6;
            // 
            // basicSalaryLabel
            // 
            basicSalaryLabel.AutoSize = true;
            basicSalaryLabel.Location = new System.Drawing.Point(20, 128);
            basicSalaryLabel.Name = "basicSalaryLabel";
            basicSalaryLabel.Size = new System.Drawing.Size(68, 13);
            basicSalaryLabel.TabIndex = 7;
            basicSalaryLabel.Text = "Basic Salary:";
            // 
            // basicSalaryTextBox
            // 
            this.basicSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveOfficeBindingSource, "BasicSalary", true));
            this.basicSalaryTextBox.Location = new System.Drawing.Point(116, 125);
            this.basicSalaryTextBox.Name = "basicSalaryTextBox";
            this.basicSalaryTextBox.Size = new System.Drawing.Size(130, 20);
            this.basicSalaryTextBox.TabIndex = 8;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(20, 157);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 9;
            positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveOfficeBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(116, 151);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(290, 20);
            this.positionTextBox.TabIndex = 10;
            // 
            // leaveOfficeBindingSource
            // 
            this.leaveOfficeBindingSource.DataSource = typeof(PDSSystem.dal.data.LeaveOffice);
            this.leaveOfficeBindingSource.CurrentChanged += new System.EventHandler(this.leaveOfficeBindingSource_CurrentChanged);
            // 
            // employeeObjBindingSource
            // 
            this.employeeObjBindingSource.DataSource = typeof(PDSSystem.dal.classes.EmployeeObj);
            // 
            // LeaveOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 203);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(basicSalaryLabel);
            this.Controls.Add(this.basicSalaryTextBox);
            this.Controls.Add(dateFiledLabel);
            this.Controls.Add(this.dateFiledDateTimePicker);
            this.Controls.Add(officeAgencyLabel);
            this.Controls.Add(this.officeAgencyTextBox);
            this.Controls.Add(personnelNoLabel);
            this.Controls.Add(this.personnelNoComboBox);
            this.Controls.Add(this.leaveOfficeBindingNavigator);
            this.Name = "LeaveOfficeForm";
            this.Text = "Leave Office Form";
            this.Load += new System.EventHandler(this.LeaveOfficeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaveOfficeBindingNavigator)).EndInit();
            this.leaveOfficeBindingNavigator.ResumeLayout(false);
            this.leaveOfficeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveOfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeObjBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource leaveOfficeBindingSource;
        private System.Windows.Forms.BindingNavigator leaveOfficeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton leaveOfficeBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox personnelNoComboBox;
        private System.Windows.Forms.TextBox officeAgencyTextBox;
        private System.Windows.Forms.DateTimePicker dateFiledDateTimePicker;
        private System.Windows.Forms.TextBox basicSalaryTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.BindingSource employeeObjBindingSource;
    }
}