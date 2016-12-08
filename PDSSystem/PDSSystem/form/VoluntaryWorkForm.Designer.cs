namespace PDSSystem.form
{
    partial class VoluntaryWorkForm
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
            System.Windows.Forms.Label voluntaryOrganizationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoluntaryWorkForm));
            System.Windows.Forms.Label voluntaryDate1Label;
            System.Windows.Forms.Label voluntaryDate2Label;
            System.Windows.Forms.Label voluntaryNoHoursLabel;
            System.Windows.Forms.Label voluntaryPositionLabel;
            this.voluntaryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.voluntaryOrganizationTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.voluntaryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.voluntaryDate1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.voluntaryDate2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.voluntaryNoHoursTextBox = new System.Windows.Forms.TextBox();
            this.voluntaryPositionTextBox = new System.Windows.Forms.TextBox();
            this.voluntaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            voluntaryOrganizationLabel = new System.Windows.Forms.Label();
            voluntaryDate1Label = new System.Windows.Forms.Label();
            voluntaryDate2Label = new System.Windows.Forms.Label();
            voluntaryNoHoursLabel = new System.Windows.Forms.Label();
            voluntaryPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voluntaryBindingNavigator)).BeginInit();
            this.voluntaryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voluntaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // voluntaryBindingNavigator
            // 
            this.voluntaryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.voluntaryBindingNavigator.BindingSource = this.voluntaryBindingSource;
            this.voluntaryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.voluntaryBindingNavigator.DeleteItem = null;
            this.voluntaryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.voluntaryBindingNavigatorSaveItem});
            this.voluntaryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.voluntaryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.voluntaryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.voluntaryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.voluntaryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.voluntaryBindingNavigator.Name = "voluntaryBindingNavigator";
            this.voluntaryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.voluntaryBindingNavigator.Size = new System.Drawing.Size(585, 25);
            this.voluntaryBindingNavigator.TabIndex = 0;
            this.voluntaryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // voluntaryOrganizationLabel
            // 
            voluntaryOrganizationLabel.AutoSize = true;
            voluntaryOrganizationLabel.Location = new System.Drawing.Point(18, 49);
            voluntaryOrganizationLabel.Name = "voluntaryOrganizationLabel";
            voluntaryOrganizationLabel.Size = new System.Drawing.Size(116, 13);
            voluntaryOrganizationLabel.TabIndex = 1;
            voluntaryOrganizationLabel.Text = "Voluntary Organization:";
            // 
            // voluntaryOrganizationTextBox
            // 
            this.voluntaryOrganizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntaryBindingSource, "VoluntaryOrganization", true));
            this.voluntaryOrganizationTextBox.Location = new System.Drawing.Point(140, 46);
            this.voluntaryOrganizationTextBox.Multiline = true;
            this.voluntaryOrganizationTextBox.Name = "voluntaryOrganizationTextBox";
            this.voluntaryOrganizationTextBox.Size = new System.Drawing.Size(425, 43);
            this.voluntaryOrganizationTextBox.TabIndex = 2;
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // voluntaryBindingNavigatorSaveItem
            // 
            this.voluntaryBindingNavigatorSaveItem.Enabled = false;
            this.voluntaryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("voluntaryBindingNavigatorSaveItem.Image")));
            this.voluntaryBindingNavigatorSaveItem.Name = "voluntaryBindingNavigatorSaveItem";
            this.voluntaryBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.voluntaryBindingNavigatorSaveItem.Text = "Save Data";
            this.voluntaryBindingNavigatorSaveItem.Click += new System.EventHandler(this.voluntaryBindingNavigatorSaveItem_Click);
            // 
            // voluntaryDate1Label
            // 
            voluntaryDate1Label.AutoSize = true;
            voluntaryDate1Label.Location = new System.Drawing.Point(18, 98);
            voluntaryDate1Label.Name = "voluntaryDate1Label";
            voluntaryDate1Label.Size = new System.Drawing.Size(111, 13);
            voluntaryDate1Label.TabIndex = 3;
            voluntaryDate1Label.Text = "Voluntary Date (Start):";
            // 
            // voluntaryDate1DateTimePicker
            // 
            this.voluntaryDate1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voluntaryBindingSource, "VoluntaryDate1", true));
            this.voluntaryDate1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.voluntaryDate1DateTimePicker.Location = new System.Drawing.Point(140, 95);
            this.voluntaryDate1DateTimePicker.Name = "voluntaryDate1DateTimePicker";
            this.voluntaryDate1DateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.voluntaryDate1DateTimePicker.TabIndex = 4;
            // 
            // voluntaryDate2Label
            // 
            voluntaryDate2Label.AutoSize = true;
            voluntaryDate2Label.Location = new System.Drawing.Point(18, 123);
            voluntaryDate2Label.Name = "voluntaryDate2Label";
            voluntaryDate2Label.Size = new System.Drawing.Size(108, 13);
            voluntaryDate2Label.TabIndex = 5;
            voluntaryDate2Label.Text = "Voluntary Date (End):";
            // 
            // voluntaryDate2DateTimePicker
            // 
            this.voluntaryDate2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voluntaryBindingSource, "VoluntaryDate2", true));
            this.voluntaryDate2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.voluntaryDate2DateTimePicker.Location = new System.Drawing.Point(140, 121);
            this.voluntaryDate2DateTimePicker.Name = "voluntaryDate2DateTimePicker";
            this.voluntaryDate2DateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.voluntaryDate2DateTimePicker.TabIndex = 6;
            // 
            // voluntaryNoHoursLabel
            // 
            voluntaryNoHoursLabel.AutoSize = true;
            voluntaryNoHoursLabel.Location = new System.Drawing.Point(18, 150);
            voluntaryNoHoursLabel.Name = "voluntaryNoHoursLabel";
            voluntaryNoHoursLabel.Size = new System.Drawing.Size(67, 13);
            voluntaryNoHoursLabel.TabIndex = 7;
            voluntaryNoHoursLabel.Text = "No of Hours:";
            // 
            // voluntaryNoHoursTextBox
            // 
            this.voluntaryNoHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntaryBindingSource, "VoluntaryNoHours", true));
            this.voluntaryNoHoursTextBox.Location = new System.Drawing.Point(140, 146);
            this.voluntaryNoHoursTextBox.Name = "voluntaryNoHoursTextBox";
            this.voluntaryNoHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.voluntaryNoHoursTextBox.TabIndex = 8;
            // 
            // voluntaryPositionLabel
            // 
            voluntaryPositionLabel.AutoSize = true;
            voluntaryPositionLabel.Location = new System.Drawing.Point(18, 173);
            voluntaryPositionLabel.Name = "voluntaryPositionLabel";
            voluntaryPositionLabel.Size = new System.Drawing.Size(47, 13);
            voluntaryPositionLabel.TabIndex = 9;
            voluntaryPositionLabel.Text = "Position:";
            // 
            // voluntaryPositionTextBox
            // 
            this.voluntaryPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntaryBindingSource, "VoluntaryPosition", true));
            this.voluntaryPositionTextBox.Location = new System.Drawing.Point(140, 170);
            this.voluntaryPositionTextBox.Multiline = true;
            this.voluntaryPositionTextBox.Name = "voluntaryPositionTextBox";
            this.voluntaryPositionTextBox.Size = new System.Drawing.Size(425, 41);
            this.voluntaryPositionTextBox.TabIndex = 10;
            // 
            // voluntaryBindingSource
            // 
            this.voluntaryBindingSource.DataSource = typeof(PDSSystem.dal.data.Voluntary);
            this.voluntaryBindingSource.CurrentChanged += new System.EventHandler(this.voluntaryBindingSource_CurrentChanged);
            // 
            // VoluntaryWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 234);
            this.Controls.Add(voluntaryPositionLabel);
            this.Controls.Add(this.voluntaryPositionTextBox);
            this.Controls.Add(voluntaryNoHoursLabel);
            this.Controls.Add(this.voluntaryNoHoursTextBox);
            this.Controls.Add(voluntaryDate2Label);
            this.Controls.Add(this.voluntaryDate2DateTimePicker);
            this.Controls.Add(voluntaryDate1Label);
            this.Controls.Add(this.voluntaryDate1DateTimePicker);
            this.Controls.Add(voluntaryOrganizationLabel);
            this.Controls.Add(this.voluntaryOrganizationTextBox);
            this.Controls.Add(this.voluntaryBindingNavigator);
            this.Name = "VoluntaryWorkForm";
            this.Text = "Voluntary Work Form";
            this.Load += new System.EventHandler(this.VoluntaryWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voluntaryBindingNavigator)).EndInit();
            this.voluntaryBindingNavigator.ResumeLayout(false);
            this.voluntaryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voluntaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource voluntaryBindingSource;
        private System.Windows.Forms.BindingNavigator voluntaryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton voluntaryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox voluntaryOrganizationTextBox;
        private System.Windows.Forms.DateTimePicker voluntaryDate1DateTimePicker;
        private System.Windows.Forms.DateTimePicker voluntaryDate2DateTimePicker;
        private System.Windows.Forms.TextBox voluntaryNoHoursTextBox;
        private System.Windows.Forms.TextBox voluntaryPositionTextBox;
    }
}