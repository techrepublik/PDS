namespace PDSSystem.form
{
    partial class LeaveApplicationForm
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
            System.Windows.Forms.Label personnelNoLabel;
            System.Windows.Forms.Label dateAppliedLabel;
            System.Windows.Forms.Label leaveTypeLabel;
            System.Windows.Forms.Label leaveNameLabel;
            System.Windows.Forms.Label leaveSpentDetailLabel;
            System.Windows.Forms.Label leaveStartLabel;
            System.Windows.Forms.Label leaveEndLabel;
            System.Windows.Forms.Label leaveDaysLabel;
            System.Windows.Forms.Label commutationLabel;
            System.Windows.Forms.Label recommendationLabel;
            System.Windows.Forms.Label recommendationDetailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveApplicationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonPersonnel = new System.Windows.Forms.Button();
            this.leaveApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveApplicationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.leaveApplicationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateAppliedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveTypeNoComboBox = new System.Windows.Forms.ComboBox();
            this.leaveTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveNoComboBox = new System.Windows.Forms.ComboBox();
            this.leafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commutationComboBox = new System.Windows.Forms.ComboBox();
            this.leaveStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveDaysTextBox = new System.Windows.Forms.TextBox();
            this.leaveSpentDetailTextBox = new System.Windows.Forms.TextBox();
            this.recommendationComboBox = new System.Windows.Forms.ComboBox();
            this.recommendationDetailTextBox = new System.Windows.Forms.TextBox();
            this.personnelNoComboBox = new System.Windows.Forms.ComboBox();
            personnelNoLabel = new System.Windows.Forms.Label();
            dateAppliedLabel = new System.Windows.Forms.Label();
            leaveTypeLabel = new System.Windows.Forms.Label();
            leaveNameLabel = new System.Windows.Forms.Label();
            leaveSpentDetailLabel = new System.Windows.Forms.Label();
            leaveStartLabel = new System.Windows.Forms.Label();
            leaveEndLabel = new System.Windows.Forms.Label();
            leaveDaysLabel = new System.Windows.Forms.Label();
            commutationLabel = new System.Windows.Forms.Label();
            recommendationLabel = new System.Windows.Forms.Label();
            recommendationDetailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingNavigator)).BeginInit();
            this.leaveApplicationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personnelNoLabel
            // 
            personnelNoLabel.AutoSize = true;
            personnelNoLabel.Location = new System.Drawing.Point(22, 42);
            personnelNoLabel.Name = "personnelNoLabel";
            personnelNoLabel.Size = new System.Drawing.Size(57, 13);
            personnelNoLabel.TabIndex = 1;
            personnelNoLabel.Text = "Personnel:";
            // 
            // dateAppliedLabel
            // 
            dateAppliedLabel.AutoSize = true;
            dateAppliedLabel.Location = new System.Drawing.Point(22, 76);
            dateAppliedLabel.Name = "dateAppliedLabel";
            dateAppliedLabel.Size = new System.Drawing.Size(71, 13);
            dateAppliedLabel.TabIndex = 3;
            dateAppliedLabel.Text = "Date Applied:";
            // 
            // leaveTypeLabel
            // 
            leaveTypeLabel.AutoSize = true;
            leaveTypeLabel.Location = new System.Drawing.Point(22, 100);
            leaveTypeLabel.Name = "leaveTypeLabel";
            leaveTypeLabel.Size = new System.Drawing.Size(67, 13);
            leaveTypeLabel.TabIndex = 5;
            leaveTypeLabel.Text = "Leave Type:";
            // 
            // leaveNameLabel
            // 
            leaveNameLabel.AutoSize = true;
            leaveNameLabel.Location = new System.Drawing.Point(23, 126);
            leaveNameLabel.Name = "leaveNameLabel";
            leaveNameLabel.Size = new System.Drawing.Size(71, 13);
            leaveNameLabel.TabIndex = 7;
            leaveNameLabel.Text = "Leave Name:";
            // 
            // leaveSpentDetailLabel
            // 
            leaveSpentDetailLabel.AutoSize = true;
            leaveSpentDetailLabel.Location = new System.Drawing.Point(73, 284);
            leaveSpentDetailLabel.Name = "leaveSpentDetailLabel";
            leaveSpentDetailLabel.Size = new System.Drawing.Size(101, 13);
            leaveSpentDetailLabel.TabIndex = 13;
            leaveSpentDetailLabel.Text = "Leave Spent Detail:";
            // 
            // leaveStartLabel
            // 
            leaveStartLabel.AutoSize = true;
            leaveStartLabel.Location = new System.Drawing.Point(353, 99);
            leaveStartLabel.Name = "leaveStartLabel";
            leaveStartLabel.Size = new System.Drawing.Size(65, 13);
            leaveStartLabel.TabIndex = 18;
            leaveStartLabel.Text = "Leave Start:";
            // 
            // leaveEndLabel
            // 
            leaveEndLabel.AutoSize = true;
            leaveEndLabel.Location = new System.Drawing.Point(356, 126);
            leaveEndLabel.Name = "leaveEndLabel";
            leaveEndLabel.Size = new System.Drawing.Size(62, 13);
            leaveEndLabel.TabIndex = 20;
            leaveEndLabel.Text = "Leave End:";
            // 
            // leaveDaysLabel
            // 
            leaveDaysLabel.AutoSize = true;
            leaveDaysLabel.Location = new System.Drawing.Point(356, 150);
            leaveDaysLabel.Name = "leaveDaysLabel";
            leaveDaysLabel.Size = new System.Drawing.Size(63, 13);
            leaveDaysLabel.TabIndex = 22;
            leaveDaysLabel.Text = "No of Days:";
            // 
            // commutationLabel
            // 
            commutationLabel.AutoSize = true;
            commutationLabel.Location = new System.Drawing.Point(23, 154);
            commutationLabel.Name = "commutationLabel";
            commutationLabel.Size = new System.Drawing.Size(71, 13);
            commutationLabel.TabIndex = 24;
            commutationLabel.Text = "Commutation:";
            // 
            // recommendationLabel
            // 
            recommendationLabel.AutoSize = true;
            recommendationLabel.Location = new System.Drawing.Point(22, 352);
            recommendationLabel.Name = "recommendationLabel";
            recommendationLabel.Size = new System.Drawing.Size(93, 13);
            recommendationLabel.TabIndex = 26;
            recommendationLabel.Text = "Recommendation:";
            // 
            // recommendationDetailLabel
            // 
            recommendationDetailLabel.AutoSize = true;
            recommendationDetailLabel.Location = new System.Drawing.Point(78, 379);
            recommendationDetailLabel.Name = "recommendationDetailLabel";
            recommendationDetailLabel.Size = new System.Drawing.Size(37, 13);
            recommendationDetailLabel.TabIndex = 28;
            recommendationDetailLabel.Text = "Detail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Where will be spent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "In case of vacation leave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "In case of sick leave:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In the Philippines (specify):";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(123, 257);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Abroad (specify):";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(403, 251);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Outpatient (specify):";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(403, 228);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(118, 17);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "In hospital (specify):";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // buttonPersonnel
            // 
            this.buttonPersonnel.Location = new System.Drawing.Point(522, 40);
            this.buttonPersonnel.Name = "buttonPersonnel";
            this.buttonPersonnel.Size = new System.Drawing.Size(54, 23);
            this.buttonPersonnel.TabIndex = 1;
            this.buttonPersonnel.Text = "...";
            this.buttonPersonnel.UseVisualStyleBackColor = true;
            // 
            // leaveApplicationBindingSource
            // 
            this.leaveApplicationBindingSource.DataSource = typeof(PDSSystem.dal.data.LeaveApplication);
            this.leaveApplicationBindingSource.CurrentChanged += new System.EventHandler(this.leaveApplicationBindingSource_CurrentChanged);
            // 
            // leaveApplicationBindingNavigator
            // 
            this.leaveApplicationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.leaveApplicationBindingNavigator.BindingSource = this.leaveApplicationBindingSource;
            this.leaveApplicationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.leaveApplicationBindingNavigator.DeleteItem = null;
            this.leaveApplicationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.leaveApplicationBindingNavigatorSaveItem});
            this.leaveApplicationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.leaveApplicationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.leaveApplicationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.leaveApplicationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.leaveApplicationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.leaveApplicationBindingNavigator.Name = "leaveApplicationBindingNavigator";
            this.leaveApplicationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.leaveApplicationBindingNavigator.Size = new System.Drawing.Size(596, 25);
            this.leaveApplicationBindingNavigator.TabIndex = 29;
            this.leaveApplicationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // leaveApplicationBindingNavigatorSaveItem
            // 
            this.leaveApplicationBindingNavigatorSaveItem.Enabled = false;
            this.leaveApplicationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("leaveApplicationBindingNavigatorSaveItem.Image")));
            this.leaveApplicationBindingNavigatorSaveItem.Name = "leaveApplicationBindingNavigatorSaveItem";
            this.leaveApplicationBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.leaveApplicationBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // employeeObjBindingSource
            // 
            this.employeeObjBindingSource.DataSource = typeof(PDSSystem.dal.classes.EmployeeObj);
            // 
            // dateAppliedDateTimePicker
            // 
            this.dateAppliedDateTimePicker.CustomFormat = " ";
            this.dateAppliedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveApplicationBindingSource, "DateApplied", true));
            this.dateAppliedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAppliedDateTimePicker.Location = new System.Drawing.Point(123, 72);
            this.dateAppliedDateTimePicker.Name = "dateAppliedDateTimePicker";
            this.dateAppliedDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.dateAppliedDateTimePicker.TabIndex = 2;
            this.dateAppliedDateTimePicker.ValueChanged += new System.EventHandler(this.dateAppliedDateTimePicker_ValueChanged);
            // 
            // leaveTypeNoComboBox
            // 
            this.leaveTypeNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.leaveTypeNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.leaveTypeNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.leaveApplicationBindingSource, "LeaveTypeNo", true));
            this.leaveTypeNoComboBox.DataSource = this.leaveTypeBindingSource;
            this.leaveTypeNoComboBox.DisplayMember = "LeaveType1";
            this.leaveTypeNoComboBox.FormattingEnabled = true;
            this.leaveTypeNoComboBox.Location = new System.Drawing.Point(123, 97);
            this.leaveTypeNoComboBox.Name = "leaveTypeNoComboBox";
            this.leaveTypeNoComboBox.Size = new System.Drawing.Size(191, 21);
            this.leaveTypeNoComboBox.TabIndex = 3;
            this.leaveTypeNoComboBox.ValueMember = "LeaveTypeNo";
            // 
            // leaveTypeBindingSource
            // 
            this.leaveTypeBindingSource.DataSource = typeof(PDSSystem.dal.data.LeaveType);
            // 
            // leaveNoComboBox
            // 
            this.leaveNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.leaveNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.leaveNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.leaveApplicationBindingSource, "LeaveNo", true));
            this.leaveNoComboBox.DataSource = this.leafBindingSource;
            this.leaveNoComboBox.DisplayMember = "LeaveName";
            this.leaveNoComboBox.FormattingEnabled = true;
            this.leaveNoComboBox.Location = new System.Drawing.Point(123, 123);
            this.leaveNoComboBox.Name = "leaveNoComboBox";
            this.leaveNoComboBox.Size = new System.Drawing.Size(191, 21);
            this.leaveNoComboBox.TabIndex = 4;
            this.leaveNoComboBox.ValueMember = "LeaveNo";
            // 
            // leafBindingSource
            // 
            this.leafBindingSource.DataSource = typeof(PDSSystem.dal.data.Leaf);
            // 
            // commutationComboBox
            // 
            this.commutationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveApplicationBindingSource, "Commutation", true));
            this.commutationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commutationComboBox.FormattingEnabled = true;
            this.commutationComboBox.Items.AddRange(new object[] {
            "Requested",
            "Not Requested"});
            this.commutationComboBox.Location = new System.Drawing.Point(123, 150);
            this.commutationComboBox.Name = "commutationComboBox";
            this.commutationComboBox.Size = new System.Drawing.Size(191, 21);
            this.commutationComboBox.TabIndex = 5;
            // 
            // leaveStartDateTimePicker
            // 
            this.leaveStartDateTimePicker.CustomFormat = " ";
            this.leaveStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveApplicationBindingSource, "LeaveStart", true));
            this.leaveStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.leaveStartDateTimePicker.Location = new System.Drawing.Point(424, 98);
            this.leaveStartDateTimePicker.Name = "leaveStartDateTimePicker";
            this.leaveStartDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.leaveStartDateTimePicker.TabIndex = 6;
            this.leaveStartDateTimePicker.ValueChanged += new System.EventHandler(this.leaveStartDateTimePicker_ValueChanged);
            // 
            // leaveEndDateTimePicker
            // 
            this.leaveEndDateTimePicker.CustomFormat = " ";
            this.leaveEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveApplicationBindingSource, "LeaveEnd", true));
            this.leaveEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.leaveEndDateTimePicker.Location = new System.Drawing.Point(424, 123);
            this.leaveEndDateTimePicker.Name = "leaveEndDateTimePicker";
            this.leaveEndDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.leaveEndDateTimePicker.TabIndex = 7;
            this.leaveEndDateTimePicker.ValueChanged += new System.EventHandler(this.leaveEndDateTimePicker_ValueChanged);
            // 
            // leaveDaysTextBox
            // 
            this.leaveDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveApplicationBindingSource, "LeaveDays", true));
            this.leaveDaysTextBox.Location = new System.Drawing.Point(425, 149);
            this.leaveDaysTextBox.Name = "leaveDaysTextBox";
            this.leaveDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.leaveDaysTextBox.TabIndex = 8;
            // 
            // leaveSpentDetailTextBox
            // 
            this.leaveSpentDetailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveApplicationBindingSource, "LeaveSpentDetail", true));
            this.leaveSpentDetailTextBox.Location = new System.Drawing.Point(123, 300);
            this.leaveSpentDetailTextBox.Multiline = true;
            this.leaveSpentDetailTextBox.Name = "leaveSpentDetailTextBox";
            this.leaveSpentDetailTextBox.Size = new System.Drawing.Size(453, 40);
            this.leaveSpentDetailTextBox.TabIndex = 13;
            // 
            // recommendationComboBox
            // 
            this.recommendationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveApplicationBindingSource, "Recommendation", true));
            this.recommendationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recommendationComboBox.FormattingEnabled = true;
            this.recommendationComboBox.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Disapproved"});
            this.recommendationComboBox.Location = new System.Drawing.Point(123, 348);
            this.recommendationComboBox.Name = "recommendationComboBox";
            this.recommendationComboBox.Size = new System.Drawing.Size(191, 21);
            this.recommendationComboBox.TabIndex = 14;
            // 
            // recommendationDetailTextBox
            // 
            this.recommendationDetailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveApplicationBindingSource, "RecommendationDetail", true));
            this.recommendationDetailTextBox.Location = new System.Drawing.Point(123, 374);
            this.recommendationDetailTextBox.Multiline = true;
            this.recommendationDetailTextBox.Name = "recommendationDetailTextBox";
            this.recommendationDetailTextBox.Size = new System.Drawing.Size(453, 41);
            this.recommendationDetailTextBox.TabIndex = 15;
            // 
            // personnelNoComboBox
            // 
            this.personnelNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveApplicationBindingSource, "PersonnelNo", true));
            this.personnelNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.leaveApplicationBindingSource, "PersonnelNo", true));
            this.personnelNoComboBox.DataSource = this.employeeObjBindingSource;
            this.personnelNoComboBox.DisplayMember = "FullName";
            this.personnelNoComboBox.FormattingEnabled = true;
            this.personnelNoComboBox.Location = new System.Drawing.Point(123, 42);
            this.personnelNoComboBox.Name = "personnelNoComboBox";
            this.personnelNoComboBox.Size = new System.Drawing.Size(393, 21);
            this.personnelNoComboBox.TabIndex = 31;
            this.personnelNoComboBox.ValueMember = "PersonnelNo";
            // 
            // LeaveApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 439);
            this.Controls.Add(this.personnelNoComboBox);
            this.Controls.Add(this.recommendationDetailTextBox);
            this.Controls.Add(this.recommendationComboBox);
            this.Controls.Add(this.leaveSpentDetailTextBox);
            this.Controls.Add(this.leaveDaysTextBox);
            this.Controls.Add(this.leaveEndDateTimePicker);
            this.Controls.Add(this.leaveStartDateTimePicker);
            this.Controls.Add(this.commutationComboBox);
            this.Controls.Add(this.leaveNoComboBox);
            this.Controls.Add(this.leaveTypeNoComboBox);
            this.Controls.Add(this.dateAppliedDateTimePicker);
            this.Controls.Add(this.leaveApplicationBindingNavigator);
            this.Controls.Add(this.buttonPersonnel);
            this.Controls.Add(recommendationDetailLabel);
            this.Controls.Add(recommendationLabel);
            this.Controls.Add(commutationLabel);
            this.Controls.Add(leaveDaysLabel);
            this.Controls.Add(leaveEndLabel);
            this.Controls.Add(leaveStartLabel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(leaveSpentDetailLabel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(leaveNameLabel);
            this.Controls.Add(leaveTypeLabel);
            this.Controls.Add(dateAppliedLabel);
            this.Controls.Add(personnelNoLabel);
            this.Name = "LeaveApplicationForm";
            this.Text = "Leave Application Form";
            this.Load += new System.EventHandler(this.LeaveApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingNavigator)).EndInit();
            this.leaveApplicationBindingNavigator.ResumeLayout(false);
            this.leaveApplicationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonPersonnel;
        private System.Windows.Forms.BindingSource leaveApplicationBindingSource;
        private System.Windows.Forms.BindingNavigator leaveApplicationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton leaveApplicationBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateAppliedDateTimePicker;
        private System.Windows.Forms.ComboBox leaveTypeNoComboBox;
        private System.Windows.Forms.ComboBox leaveNoComboBox;
        private System.Windows.Forms.ComboBox commutationComboBox;
        private System.Windows.Forms.DateTimePicker leaveStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker leaveEndDateTimePicker;
        private System.Windows.Forms.TextBox leaveDaysTextBox;
        private System.Windows.Forms.TextBox leaveSpentDetailTextBox;
        private System.Windows.Forms.ComboBox recommendationComboBox;
        private System.Windows.Forms.TextBox recommendationDetailTextBox;
        private System.Windows.Forms.BindingSource employeeObjBindingSource;
        private System.Windows.Forms.BindingSource leaveTypeBindingSource;
        private System.Windows.Forms.BindingSource leafBindingSource;
        private System.Windows.Forms.ComboBox personnelNoComboBox;
    }
}