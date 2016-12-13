namespace PDSSystem.form
{
    partial class LeaveCreditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveCreditForm));
            System.Windows.Forms.Label creditFromLabel;
            System.Windows.Forms.Label creditToLabel;
            System.Windows.Forms.Label particularsLabel;
            System.Windows.Forms.Label vacationEarnedLabel;
            System.Windows.Forms.Label vacationDeduction1Label;
            System.Windows.Forms.Label vacationDeduction2Label;
            System.Windows.Forms.Label sickEarnedLabel;
            System.Windows.Forms.Label sickDeduction1Label;
            System.Windows.Forms.Label sickDeduction2Label;
            System.Windows.Forms.Label personnelNoLabel;
            this.leaveCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveCreditBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.leaveCreditBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.creditFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creditToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.particularsTextBox = new System.Windows.Forms.TextBox();
            this.vacationEarnedTextBox = new System.Windows.Forms.TextBox();
            this.vacationDeduction1TextBox = new System.Windows.Forms.TextBox();
            this.vacationDeduction2TextBox = new System.Windows.Forms.TextBox();
            this.sickEarnedTextBox = new System.Windows.Forms.TextBox();
            this.sickDeduction1TextBox = new System.Windows.Forms.TextBox();
            this.sickDeduction2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.personnelNoComboBox = new System.Windows.Forms.ComboBox();
            this.leaveObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveObjDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            creditFromLabel = new System.Windows.Forms.Label();
            creditToLabel = new System.Windows.Forms.Label();
            particularsLabel = new System.Windows.Forms.Label();
            vacationEarnedLabel = new System.Windows.Forms.Label();
            vacationDeduction1Label = new System.Windows.Forms.Label();
            vacationDeduction2Label = new System.Windows.Forms.Label();
            sickEarnedLabel = new System.Windows.Forms.Label();
            sickDeduction1Label = new System.Windows.Forms.Label();
            sickDeduction2Label = new System.Windows.Forms.Label();
            personnelNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCreditBindingNavigator)).BeginInit();
            this.leaveCreditBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveObjDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveCreditBindingSource
            // 
            this.leaveCreditBindingSource.DataSource = typeof(PDSSystem.dal.data.LeaveCredit);
            // 
            // leaveCreditBindingNavigator
            // 
            this.leaveCreditBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.leaveCreditBindingNavigator.BindingSource = this.leaveCreditBindingSource;
            this.leaveCreditBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.leaveCreditBindingNavigator.DeleteItem = null;
            this.leaveCreditBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.leaveCreditBindingNavigatorSaveItem});
            this.leaveCreditBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.leaveCreditBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.leaveCreditBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.leaveCreditBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.leaveCreditBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.leaveCreditBindingNavigator.Name = "leaveCreditBindingNavigator";
            this.leaveCreditBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.leaveCreditBindingNavigator.Size = new System.Drawing.Size(728, 25);
            this.leaveCreditBindingNavigator.TabIndex = 0;
            this.leaveCreditBindingNavigator.Text = "bindingNavigator1";
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
            // leaveCreditBindingNavigatorSaveItem
            // 
            this.leaveCreditBindingNavigatorSaveItem.Enabled = false;
            this.leaveCreditBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("leaveCreditBindingNavigatorSaveItem.Image")));
            this.leaveCreditBindingNavigatorSaveItem.Name = "leaveCreditBindingNavigatorSaveItem";
            this.leaveCreditBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.leaveCreditBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // creditFromLabel
            // 
            creditFromLabel.AutoSize = true;
            creditFromLabel.Location = new System.Drawing.Point(38, 83);
            creditFromLabel.Name = "creditFromLabel";
            creditFromLabel.Size = new System.Drawing.Size(63, 13);
            creditFromLabel.TabIndex = 1;
            creditFromLabel.Text = "Credit From:";
            // 
            // creditFromDateTimePicker
            // 
            this.creditFromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveCreditBindingSource, "CreditFrom", true));
            this.creditFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creditFromDateTimePicker.Location = new System.Drawing.Point(123, 77);
            this.creditFromDateTimePicker.Name = "creditFromDateTimePicker";
            this.creditFromDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.creditFromDateTimePicker.TabIndex = 2;
            // 
            // creditToLabel
            // 
            creditToLabel.AutoSize = true;
            creditToLabel.Location = new System.Drawing.Point(48, 106);
            creditToLabel.Name = "creditToLabel";
            creditToLabel.Size = new System.Drawing.Size(53, 13);
            creditToLabel.TabIndex = 3;
            creditToLabel.Text = "Credit To:";
            // 
            // creditToDateTimePicker
            // 
            this.creditToDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leaveCreditBindingSource, "CreditTo", true));
            this.creditToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creditToDateTimePicker.Location = new System.Drawing.Point(123, 102);
            this.creditToDateTimePicker.Name = "creditToDateTimePicker";
            this.creditToDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.creditToDateTimePicker.TabIndex = 4;
            // 
            // particularsLabel
            // 
            particularsLabel.AutoSize = true;
            particularsLabel.Location = new System.Drawing.Point(42, 130);
            particularsLabel.Name = "particularsLabel";
            particularsLabel.Size = new System.Drawing.Size(59, 13);
            particularsLabel.TabIndex = 5;
            particularsLabel.Text = "Particulars:";
            // 
            // particularsTextBox
            // 
            this.particularsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "Particulars", true));
            this.particularsTextBox.Location = new System.Drawing.Point(123, 127);
            this.particularsTextBox.Name = "particularsTextBox";
            this.particularsTextBox.Size = new System.Drawing.Size(337, 20);
            this.particularsTextBox.TabIndex = 6;
            // 
            // vacationEarnedLabel
            // 
            vacationEarnedLabel.AutoSize = true;
            vacationEarnedLabel.Location = new System.Drawing.Point(12, 156);
            vacationEarnedLabel.Name = "vacationEarnedLabel";
            vacationEarnedLabel.Size = new System.Drawing.Size(89, 13);
            vacationEarnedLabel.TabIndex = 7;
            vacationEarnedLabel.Text = "Vacation Earned:";
            // 
            // vacationEarnedTextBox
            // 
            this.vacationEarnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "VacationEarned", true));
            this.vacationEarnedTextBox.Location = new System.Drawing.Point(123, 152);
            this.vacationEarnedTextBox.Name = "vacationEarnedTextBox";
            this.vacationEarnedTextBox.Size = new System.Drawing.Size(115, 20);
            this.vacationEarnedTextBox.TabIndex = 8;
            // 
            // vacationDeduction1Label
            // 
            vacationDeduction1Label.AutoSize = true;
            vacationDeduction1Label.Location = new System.Drawing.Point(33, 180);
            vacationDeduction1Label.Name = "vacationDeduction1Label";
            vacationDeduction1Label.Size = new System.Drawing.Size(68, 13);
            vacationDeduction1Label.TabIndex = 9;
            vacationDeduction1Label.Text = "Deduction 1:";
            // 
            // vacationDeduction1TextBox
            // 
            this.vacationDeduction1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "VacationDeduction1", true));
            this.vacationDeduction1TextBox.Location = new System.Drawing.Point(123, 176);
            this.vacationDeduction1TextBox.Name = "vacationDeduction1TextBox";
            this.vacationDeduction1TextBox.Size = new System.Drawing.Size(115, 20);
            this.vacationDeduction1TextBox.TabIndex = 10;
            // 
            // vacationDeduction2Label
            // 
            vacationDeduction2Label.AutoSize = true;
            vacationDeduction2Label.Location = new System.Drawing.Point(271, 179);
            vacationDeduction2Label.Name = "vacationDeduction2Label";
            vacationDeduction2Label.Size = new System.Drawing.Size(68, 13);
            vacationDeduction2Label.TabIndex = 11;
            vacationDeduction2Label.Text = "Deduction 2:";
            // 
            // vacationDeduction2TextBox
            // 
            this.vacationDeduction2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "VacationDeduction2", true));
            this.vacationDeduction2TextBox.Location = new System.Drawing.Point(345, 176);
            this.vacationDeduction2TextBox.Name = "vacationDeduction2TextBox";
            this.vacationDeduction2TextBox.Size = new System.Drawing.Size(115, 20);
            this.vacationDeduction2TextBox.TabIndex = 12;
            // 
            // sickEarnedLabel
            // 
            sickEarnedLabel.AutoSize = true;
            sickEarnedLabel.Location = new System.Drawing.Point(33, 207);
            sickEarnedLabel.Name = "sickEarnedLabel";
            sickEarnedLabel.Size = new System.Drawing.Size(68, 13);
            sickEarnedLabel.TabIndex = 13;
            sickEarnedLabel.Text = "Sick Earned:";
            // 
            // sickEarnedTextBox
            // 
            this.sickEarnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "SickEarned", true));
            this.sickEarnedTextBox.Location = new System.Drawing.Point(123, 202);
            this.sickEarnedTextBox.Name = "sickEarnedTextBox";
            this.sickEarnedTextBox.Size = new System.Drawing.Size(115, 20);
            this.sickEarnedTextBox.TabIndex = 14;
            // 
            // sickDeduction1Label
            // 
            sickDeduction1Label.AutoSize = true;
            sickDeduction1Label.Location = new System.Drawing.Point(33, 232);
            sickDeduction1Label.Name = "sickDeduction1Label";
            sickDeduction1Label.Size = new System.Drawing.Size(68, 13);
            sickDeduction1Label.TabIndex = 15;
            sickDeduction1Label.Text = "Deduction 1:";
            // 
            // sickDeduction1TextBox
            // 
            this.sickDeduction1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "SickDeduction1", true));
            this.sickDeduction1TextBox.Location = new System.Drawing.Point(123, 228);
            this.sickDeduction1TextBox.Name = "sickDeduction1TextBox";
            this.sickDeduction1TextBox.Size = new System.Drawing.Size(115, 20);
            this.sickDeduction1TextBox.TabIndex = 16;
            // 
            // sickDeduction2Label
            // 
            sickDeduction2Label.AutoSize = true;
            sickDeduction2Label.Location = new System.Drawing.Point(273, 232);
            sickDeduction2Label.Name = "sickDeduction2Label";
            sickDeduction2Label.Size = new System.Drawing.Size(65, 13);
            sickDeduction2Label.TabIndex = 17;
            sickDeduction2Label.Text = "Deduction2:";
            // 
            // sickDeduction2TextBox
            // 
            this.sickDeduction2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "SickDeduction2", true));
            this.sickDeduction2TextBox.Location = new System.Drawing.Point(345, 228);
            this.sickDeduction2TextBox.Name = "sickDeduction2TextBox";
            this.sickDeduction2TextBox.Size = new System.Drawing.Size(115, 20);
            this.sickDeduction2TextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Leave Application(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Month+Year:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(244, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // personnelNoLabel
            // 
            personnelNoLabel.AutoSize = true;
            personnelNoLabel.Location = new System.Drawing.Point(44, 49);
            personnelNoLabel.Name = "personnelNoLabel";
            personnelNoLabel.Size = new System.Drawing.Size(57, 13);
            personnelNoLabel.TabIndex = 23;
            personnelNoLabel.Text = "Personnel:";
            // 
            // personnelNoComboBox
            // 
            this.personnelNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaveCreditBindingSource, "PersonnelNo", true));
            this.personnelNoComboBox.FormattingEnabled = true;
            this.personnelNoComboBox.Location = new System.Drawing.Point(123, 46);
            this.personnelNoComboBox.Name = "personnelNoComboBox";
            this.personnelNoComboBox.Size = new System.Drawing.Size(337, 21);
            this.personnelNoComboBox.TabIndex = 24;
            // 
            // leaveObjBindingSource
            // 
            this.leaveObjBindingSource.DataSource = typeof(PDSSystem.dal.classes.LeaveObj);
            // 
            // leaveObjDataGridView
            // 
            this.leaveObjDataGridView.AutoGenerateColumns = false;
            this.leaveObjDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveObjDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.leaveObjDataGridView.DataSource = this.leaveObjBindingSource;
            this.leaveObjDataGridView.Location = new System.Drawing.Point(12, 331);
            this.leaveObjDataGridView.Name = "leaveObjDataGridView";
            this.leaveObjDataGridView.RowHeadersWidth = 30;
            this.leaveObjDataGridView.Size = new System.Drawing.Size(699, 278);
            this.leaveObjDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PersonnelName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Personnel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LeaveName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Leave";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LeaveType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateApplied";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date Applied";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "LeaveStart";
            this.dataGridViewTextBoxColumn15.HeaderText = "Leave Start";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "LeaveEnd";
            this.dataGridViewTextBoxColumn16.HeaderText = "Leave End";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Recommendation";
            this.dataGridViewTextBoxColumn18.HeaderText = "Recommendation";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "RecommendationDetail";
            this.dataGridViewTextBoxColumn19.HeaderText = "Detail";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // LeaveCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 621);
            this.Controls.Add(this.leaveObjDataGridView);
            this.Controls.Add(personnelNoLabel);
            this.Controls.Add(this.personnelNoComboBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(sickDeduction2Label);
            this.Controls.Add(this.sickDeduction2TextBox);
            this.Controls.Add(sickDeduction1Label);
            this.Controls.Add(this.sickDeduction1TextBox);
            this.Controls.Add(sickEarnedLabel);
            this.Controls.Add(this.sickEarnedTextBox);
            this.Controls.Add(vacationDeduction2Label);
            this.Controls.Add(this.vacationDeduction2TextBox);
            this.Controls.Add(vacationDeduction1Label);
            this.Controls.Add(this.vacationDeduction1TextBox);
            this.Controls.Add(vacationEarnedLabel);
            this.Controls.Add(this.vacationEarnedTextBox);
            this.Controls.Add(particularsLabel);
            this.Controls.Add(this.particularsTextBox);
            this.Controls.Add(creditToLabel);
            this.Controls.Add(this.creditToDateTimePicker);
            this.Controls.Add(creditFromLabel);
            this.Controls.Add(this.creditFromDateTimePicker);
            this.Controls.Add(this.leaveCreditBindingNavigator);
            this.Name = "LeaveCreditForm";
            this.Text = "Leave Credit Form";
            this.Load += new System.EventHandler(this.LeaveCreditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaveCreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCreditBindingNavigator)).EndInit();
            this.leaveCreditBindingNavigator.ResumeLayout(false);
            this.leaveCreditBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveObjDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource leaveCreditBindingSource;
        private System.Windows.Forms.BindingNavigator leaveCreditBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton leaveCreditBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker creditFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker creditToDateTimePicker;
        private System.Windows.Forms.TextBox particularsTextBox;
        private System.Windows.Forms.TextBox vacationEarnedTextBox;
        private System.Windows.Forms.TextBox vacationDeduction1TextBox;
        private System.Windows.Forms.TextBox vacationDeduction2TextBox;
        private System.Windows.Forms.TextBox sickEarnedTextBox;
        private System.Windows.Forms.TextBox sickDeduction1TextBox;
        private System.Windows.Forms.TextBox sickDeduction2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox personnelNoComboBox;
        private System.Windows.Forms.BindingSource leaveObjBindingSource;
        private System.Windows.Forms.DataGridView leaveObjDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}