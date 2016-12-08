namespace PDSSystem.form
{
    partial class WorkExperienceForm
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
            System.Windows.Forms.Label experienceDate1Label;
            System.Windows.Forms.Label experienceDate2Label;
            System.Windows.Forms.Label experiencePositionLabel;
            System.Windows.Forms.Label experienceOfficeLabel;
            System.Windows.Forms.Label experienceSalaryLabel;
            System.Windows.Forms.Label experienceSalaryGradeLabel;
            System.Windows.Forms.Label experienceStatusLabel;
            System.Windows.Forms.Label experienceIsGovernmentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkExperienceForm));
            this.experiencyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.experienceDate1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.experienceDate2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.experiencePositionComboBox = new System.Windows.Forms.ComboBox();
            this.experienceOfficeTextBox = new System.Windows.Forms.TextBox();
            this.experienceSalaryTextBox = new System.Windows.Forms.TextBox();
            this.experienceSalaryGradeTextBox = new System.Windows.Forms.TextBox();
            this.experienceStatusTextBox = new System.Windows.Forms.TextBox();
            this.experienceIsGovernmentCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.experiencyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.experiencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            experienceDate1Label = new System.Windows.Forms.Label();
            experienceDate2Label = new System.Windows.Forms.Label();
            experiencePositionLabel = new System.Windows.Forms.Label();
            experienceOfficeLabel = new System.Windows.Forms.Label();
            experienceSalaryLabel = new System.Windows.Forms.Label();
            experienceSalaryGradeLabel = new System.Windows.Forms.Label();
            experienceStatusLabel = new System.Windows.Forms.Label();
            experienceIsGovernmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.experiencyBindingNavigator)).BeginInit();
            this.experiencyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experiencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // experiencyBindingNavigator
            // 
            this.experiencyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.experiencyBindingNavigator.BindingSource = this.experiencyBindingSource;
            this.experiencyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.experiencyBindingNavigator.DeleteItem = null;
            this.experiencyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.experiencyBindingNavigatorSaveItem});
            this.experiencyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.experiencyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.experiencyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.experiencyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.experiencyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.experiencyBindingNavigator.Name = "experiencyBindingNavigator";
            this.experiencyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.experiencyBindingNavigator.Size = new System.Drawing.Size(561, 25);
            this.experiencyBindingNavigator.TabIndex = 0;
            this.experiencyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // experienceDate1Label
            // 
            experienceDate1Label.AutoSize = true;
            experienceDate1Label.Location = new System.Drawing.Point(29, 50);
            experienceDate1Label.Name = "experienceDate1Label";
            experienceDate1Label.Size = new System.Drawing.Size(120, 13);
            experienceDate1Label.TabIndex = 1;
            experienceDate1Label.Text = "Experience Date (Start):";
            // 
            // experienceDate1DateTimePicker
            // 
            this.experienceDate1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.experiencyBindingSource, "ExperienceDate1", true));
            this.experienceDate1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.experienceDate1DateTimePicker.Location = new System.Drawing.Point(157, 46);
            this.experienceDate1DateTimePicker.Name = "experienceDate1DateTimePicker";
            this.experienceDate1DateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.experienceDate1DateTimePicker.TabIndex = 0;
            // 
            // experienceDate2Label
            // 
            experienceDate2Label.AutoSize = true;
            experienceDate2Label.Location = new System.Drawing.Point(29, 75);
            experienceDate2Label.Name = "experienceDate2Label";
            experienceDate2Label.Size = new System.Drawing.Size(117, 13);
            experienceDate2Label.TabIndex = 3;
            experienceDate2Label.Text = "Experience Date (End):";
            // 
            // experienceDate2DateTimePicker
            // 
            this.experienceDate2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.experiencyBindingSource, "ExperienceDate2", true));
            this.experienceDate2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.experienceDate2DateTimePicker.Location = new System.Drawing.Point(157, 71);
            this.experienceDate2DateTimePicker.Name = "experienceDate2DateTimePicker";
            this.experienceDate2DateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.experienceDate2DateTimePicker.TabIndex = 1;
            // 
            // experiencePositionLabel
            // 
            experiencePositionLabel.AutoSize = true;
            experiencePositionLabel.Location = new System.Drawing.Point(29, 101);
            experiencePositionLabel.Name = "experiencePositionLabel";
            experiencePositionLabel.Size = new System.Drawing.Size(70, 13);
            experiencePositionLabel.TabIndex = 5;
            experiencePositionLabel.Text = "Position Title:";
            // 
            // experiencePositionComboBox
            // 
            this.experiencePositionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experiencyBindingSource, "ExperiencePosition", true));
            this.experiencePositionComboBox.FormattingEnabled = true;
            this.experiencePositionComboBox.Location = new System.Drawing.Point(157, 96);
            this.experiencePositionComboBox.Name = "experiencePositionComboBox";
            this.experiencePositionComboBox.Size = new System.Drawing.Size(384, 21);
            this.experiencePositionComboBox.TabIndex = 2;
            // 
            // experienceOfficeLabel
            // 
            experienceOfficeLabel.AutoSize = true;
            experienceOfficeLabel.Location = new System.Drawing.Point(29, 125);
            experienceOfficeLabel.Name = "experienceOfficeLabel";
            experienceOfficeLabel.Size = new System.Drawing.Size(98, 13);
            experienceOfficeLabel.TabIndex = 7;
            experienceOfficeLabel.Text = "Department/Office:";
            // 
            // experienceOfficeTextBox
            // 
            this.experienceOfficeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experiencyBindingSource, "ExperienceOffice", true));
            this.experienceOfficeTextBox.Location = new System.Drawing.Point(157, 123);
            this.experienceOfficeTextBox.Name = "experienceOfficeTextBox";
            this.experienceOfficeTextBox.Size = new System.Drawing.Size(384, 20);
            this.experienceOfficeTextBox.TabIndex = 3;
            // 
            // experienceSalaryLabel
            // 
            experienceSalaryLabel.AutoSize = true;
            experienceSalaryLabel.Location = new System.Drawing.Point(29, 153);
            experienceSalaryLabel.Name = "experienceSalaryLabel";
            experienceSalaryLabel.Size = new System.Drawing.Size(39, 13);
            experienceSalaryLabel.TabIndex = 9;
            experienceSalaryLabel.Text = "Salary:";
            // 
            // experienceSalaryTextBox
            // 
            this.experienceSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experiencyBindingSource, "ExperienceSalary", true));
            this.experienceSalaryTextBox.Location = new System.Drawing.Point(157, 148);
            this.experienceSalaryTextBox.Name = "experienceSalaryTextBox";
            this.experienceSalaryTextBox.Size = new System.Drawing.Size(132, 20);
            this.experienceSalaryTextBox.TabIndex = 4;
            // 
            // experienceSalaryGradeLabel
            // 
            experienceSalaryGradeLabel.AutoSize = true;
            experienceSalaryGradeLabel.Location = new System.Drawing.Point(28, 178);
            experienceSalaryGradeLabel.Name = "experienceSalaryGradeLabel";
            experienceSalaryGradeLabel.Size = new System.Drawing.Size(71, 13);
            experienceSalaryGradeLabel.TabIndex = 11;
            experienceSalaryGradeLabel.Text = "Salary Grade:";
            // 
            // experienceSalaryGradeTextBox
            // 
            this.experienceSalaryGradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experiencyBindingSource, "ExperienceSalaryGrade", true));
            this.experienceSalaryGradeTextBox.Location = new System.Drawing.Point(157, 174);
            this.experienceSalaryGradeTextBox.Name = "experienceSalaryGradeTextBox";
            this.experienceSalaryGradeTextBox.Size = new System.Drawing.Size(132, 20);
            this.experienceSalaryGradeTextBox.TabIndex = 5;
            // 
            // experienceStatusLabel
            // 
            experienceStatusLabel.AutoSize = true;
            experienceStatusLabel.Location = new System.Drawing.Point(29, 204);
            experienceStatusLabel.Name = "experienceStatusLabel";
            experienceStatusLabel.Size = new System.Drawing.Size(40, 13);
            experienceStatusLabel.TabIndex = 13;
            experienceStatusLabel.Text = "Status:";
            // 
            // experienceStatusTextBox
            // 
            this.experienceStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.experiencyBindingSource, "ExperienceStatus", true));
            this.experienceStatusTextBox.Location = new System.Drawing.Point(157, 199);
            this.experienceStatusTextBox.Name = "experienceStatusTextBox";
            this.experienceStatusTextBox.Size = new System.Drawing.Size(132, 20);
            this.experienceStatusTextBox.TabIndex = 6;
            // 
            // experienceIsGovernmentLabel
            // 
            experienceIsGovernmentLabel.AutoSize = true;
            experienceIsGovernmentLabel.Location = new System.Drawing.Point(31, 232);
            experienceIsGovernmentLabel.Name = "experienceIsGovernmentLabel";
            experienceIsGovernmentLabel.Size = new System.Drawing.Size(68, 13);
            experienceIsGovernmentLabel.TabIndex = 15;
            experienceIsGovernmentLabel.Text = "Government:";
            // 
            // experienceIsGovernmentCheckBox
            // 
            this.experienceIsGovernmentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.experiencyBindingSource, "ExperienceIsGovernment", true));
            this.experienceIsGovernmentCheckBox.Location = new System.Drawing.Point(157, 225);
            this.experienceIsGovernmentCheckBox.Name = "experienceIsGovernmentCheckBox";
            this.experienceIsGovernmentCheckBox.Size = new System.Drawing.Size(104, 24);
            this.experienceIsGovernmentCheckBox.TabIndex = 7;
            this.experienceIsGovernmentCheckBox.Text = "&Yes";
            this.experienceIsGovernmentCheckBox.UseVisualStyleBackColor = true;
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // experiencyBindingNavigatorSaveItem
            // 
            this.experiencyBindingNavigatorSaveItem.Enabled = false;
            this.experiencyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("experiencyBindingNavigatorSaveItem.Image")));
            this.experiencyBindingNavigatorSaveItem.Name = "experiencyBindingNavigatorSaveItem";
            this.experiencyBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.experiencyBindingNavigatorSaveItem.Text = "Save Data";
            this.experiencyBindingNavigatorSaveItem.Click += new System.EventHandler(this.experiencyBindingNavigatorSaveItem_Click);
            // 
            // experiencyBindingSource
            // 
            this.experiencyBindingSource.DataSource = typeof(PDSSystem.dal.data.Experiency);
            this.experiencyBindingSource.CurrentChanged += new System.EventHandler(this.experiencyBindingSource_CurrentChanged);
            // 
            // WorkExperienceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 274);
            this.Controls.Add(experienceIsGovernmentLabel);
            this.Controls.Add(this.experienceIsGovernmentCheckBox);
            this.Controls.Add(experienceStatusLabel);
            this.Controls.Add(this.experienceStatusTextBox);
            this.Controls.Add(experienceSalaryGradeLabel);
            this.Controls.Add(this.experienceSalaryGradeTextBox);
            this.Controls.Add(experienceSalaryLabel);
            this.Controls.Add(this.experienceSalaryTextBox);
            this.Controls.Add(experienceOfficeLabel);
            this.Controls.Add(this.experienceOfficeTextBox);
            this.Controls.Add(experiencePositionLabel);
            this.Controls.Add(this.experiencePositionComboBox);
            this.Controls.Add(experienceDate2Label);
            this.Controls.Add(this.experienceDate2DateTimePicker);
            this.Controls.Add(experienceDate1Label);
            this.Controls.Add(this.experienceDate1DateTimePicker);
            this.Controls.Add(this.experiencyBindingNavigator);
            this.Name = "WorkExperienceForm";
            this.Text = "WorkExperienceForm";
            this.Load += new System.EventHandler(this.WorkExperienceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.experiencyBindingNavigator)).EndInit();
            this.experiencyBindingNavigator.ResumeLayout(false);
            this.experiencyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experiencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource experiencyBindingSource;
        private System.Windows.Forms.BindingNavigator experiencyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton experiencyBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker experienceDate1DateTimePicker;
        private System.Windows.Forms.DateTimePicker experienceDate2DateTimePicker;
        private System.Windows.Forms.ComboBox experiencePositionComboBox;
        private System.Windows.Forms.TextBox experienceOfficeTextBox;
        private System.Windows.Forms.TextBox experienceSalaryTextBox;
        private System.Windows.Forms.TextBox experienceSalaryGradeTextBox;
        private System.Windows.Forms.TextBox experienceStatusTextBox;
        private System.Windows.Forms.CheckBox experienceIsGovernmentCheckBox;
    }
}