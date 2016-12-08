namespace PDSSystem.form
{
    partial class EligibilityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EligibilityForm));
            System.Windows.Forms.Label eligibilityNameLabel;
            System.Windows.Forms.Label eligibilityRatingLabel;
            System.Windows.Forms.Label eligibilityExamDateLabel;
            System.Windows.Forms.Label eligibilityExamPlaceLabel;
            System.Windows.Forms.Label eligibilityLicenseNoLabel;
            System.Windows.Forms.Label eligibilityLicenseDateLabel;
            System.Windows.Forms.Label modifieddateLabel;
            this.eligibilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eligibilityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eligibilityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eligibilityNameTextBox = new System.Windows.Forms.TextBox();
            this.eligibilityRatingTextBox = new System.Windows.Forms.TextBox();
            this.eligibilityExamDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eligibilityExamPlaceTextBox = new System.Windows.Forms.TextBox();
            this.eligibilityLicenseNoTextBox = new System.Windows.Forms.TextBox();
            this.eligibilityLicenseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifieddateLabel2 = new System.Windows.Forms.Label();
            eligibilityNameLabel = new System.Windows.Forms.Label();
            eligibilityRatingLabel = new System.Windows.Forms.Label();
            eligibilityExamDateLabel = new System.Windows.Forms.Label();
            eligibilityExamPlaceLabel = new System.Windows.Forms.Label();
            eligibilityLicenseNoLabel = new System.Windows.Forms.Label();
            eligibilityLicenseDateLabel = new System.Windows.Forms.Label();
            modifieddateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingNavigator)).BeginInit();
            this.eligibilityBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // eligibilityBindingSource
            // 
            this.eligibilityBindingSource.DataSource = typeof(PDSSystem.dal.data.Eligibility);
            this.eligibilityBindingSource.CurrentChanged += new System.EventHandler(this.eligibilityBindingSource_CurrentChanged);
            // 
            // eligibilityBindingNavigator
            // 
            this.eligibilityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eligibilityBindingNavigator.BindingSource = this.eligibilityBindingSource;
            this.eligibilityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eligibilityBindingNavigator.DeleteItem = null;
            this.eligibilityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eligibilityBindingNavigatorSaveItem});
            this.eligibilityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eligibilityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eligibilityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eligibilityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eligibilityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eligibilityBindingNavigator.Name = "eligibilityBindingNavigator";
            this.eligibilityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eligibilityBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.eligibilityBindingNavigator.TabIndex = 0;
            this.eligibilityBindingNavigator.Text = "bindingNavigator1";
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
            // eligibilityBindingNavigatorSaveItem
            // 
            this.eligibilityBindingNavigatorSaveItem.Enabled = false;
            this.eligibilityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eligibilityBindingNavigatorSaveItem.Image")));
            this.eligibilityBindingNavigatorSaveItem.Name = "eligibilityBindingNavigatorSaveItem";
            this.eligibilityBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.eligibilityBindingNavigatorSaveItem.Text = "Save Data";
            this.eligibilityBindingNavigatorSaveItem.Click += new System.EventHandler(this.eligibilityBindingNavigatorSaveItem_Click);
            // 
            // eligibilityNameLabel
            // 
            eligibilityNameLabel.AutoSize = true;
            eligibilityNameLabel.Location = new System.Drawing.Point(24, 49);
            eligibilityNameLabel.Name = "eligibilityNameLabel";
            eligibilityNameLabel.Size = new System.Drawing.Size(80, 13);
            eligibilityNameLabel.TabIndex = 1;
            eligibilityNameLabel.Text = "Eligibility Name:";
            // 
            // eligibilityNameTextBox
            // 
            this.eligibilityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eligibilityBindingSource, "EligibilityName", true));
            this.eligibilityNameTextBox.Location = new System.Drawing.Point(130, 46);
            this.eligibilityNameTextBox.Multiline = true;
            this.eligibilityNameTextBox.Name = "eligibilityNameTextBox";
            this.eligibilityNameTextBox.Size = new System.Drawing.Size(440, 47);
            this.eligibilityNameTextBox.TabIndex = 2;
            // 
            // eligibilityRatingLabel
            // 
            eligibilityRatingLabel.AutoSize = true;
            eligibilityRatingLabel.Location = new System.Drawing.Point(24, 106);
            eligibilityRatingLabel.Name = "eligibilityRatingLabel";
            eligibilityRatingLabel.Size = new System.Drawing.Size(41, 13);
            eligibilityRatingLabel.TabIndex = 3;
            eligibilityRatingLabel.Text = "Rating:";
            // 
            // eligibilityRatingTextBox
            // 
            this.eligibilityRatingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eligibilityBindingSource, "EligibilityRating", true));
            this.eligibilityRatingTextBox.Location = new System.Drawing.Point(130, 99);
            this.eligibilityRatingTextBox.Name = "eligibilityRatingTextBox";
            this.eligibilityRatingTextBox.Size = new System.Drawing.Size(122, 20);
            this.eligibilityRatingTextBox.TabIndex = 4;
            // 
            // eligibilityExamDateLabel
            // 
            eligibilityExamDateLabel.AutoSize = true;
            eligibilityExamDateLabel.Location = new System.Drawing.Point(24, 130);
            eligibilityExamDateLabel.Name = "eligibilityExamDateLabel";
            eligibilityExamDateLabel.Size = new System.Drawing.Size(62, 13);
            eligibilityExamDateLabel.TabIndex = 5;
            eligibilityExamDateLabel.Text = "Exam Date:";
            // 
            // eligibilityExamDateDateTimePicker
            // 
            this.eligibilityExamDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eligibilityBindingSource, "EligibilityExamDate", true));
            this.eligibilityExamDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eligibilityExamDateDateTimePicker.Location = new System.Drawing.Point(130, 125);
            this.eligibilityExamDateDateTimePicker.Name = "eligibilityExamDateDateTimePicker";
            this.eligibilityExamDateDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.eligibilityExamDateDateTimePicker.TabIndex = 6;
            // 
            // eligibilityExamPlaceLabel
            // 
            eligibilityExamPlaceLabel.AutoSize = true;
            eligibilityExamPlaceLabel.Location = new System.Drawing.Point(24, 157);
            eligibilityExamPlaceLabel.Name = "eligibilityExamPlaceLabel";
            eligibilityExamPlaceLabel.Size = new System.Drawing.Size(66, 13);
            eligibilityExamPlaceLabel.TabIndex = 7;
            eligibilityExamPlaceLabel.Text = "Exam Place:";
            // 
            // eligibilityExamPlaceTextBox
            // 
            this.eligibilityExamPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eligibilityBindingSource, "EligibilityExamPlace", true));
            this.eligibilityExamPlaceTextBox.Location = new System.Drawing.Point(130, 151);
            this.eligibilityExamPlaceTextBox.Multiline = true;
            this.eligibilityExamPlaceTextBox.Name = "eligibilityExamPlaceTextBox";
            this.eligibilityExamPlaceTextBox.Size = new System.Drawing.Size(440, 44);
            this.eligibilityExamPlaceTextBox.TabIndex = 8;
            // 
            // eligibilityLicenseNoLabel
            // 
            eligibilityLicenseNoLabel.AutoSize = true;
            eligibilityLicenseNoLabel.Location = new System.Drawing.Point(24, 205);
            eligibilityLicenseNoLabel.Name = "eligibilityLicenseNoLabel";
            eligibilityLicenseNoLabel.Size = new System.Drawing.Size(64, 13);
            eligibilityLicenseNoLabel.TabIndex = 9;
            eligibilityLicenseNoLabel.Text = "License No:";
            // 
            // eligibilityLicenseNoTextBox
            // 
            this.eligibilityLicenseNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eligibilityBindingSource, "EligibilityLicenseNo", true));
            this.eligibilityLicenseNoTextBox.Location = new System.Drawing.Point(130, 201);
            this.eligibilityLicenseNoTextBox.Name = "eligibilityLicenseNoTextBox";
            this.eligibilityLicenseNoTextBox.Size = new System.Drawing.Size(205, 20);
            this.eligibilityLicenseNoTextBox.TabIndex = 10;
            // 
            // eligibilityLicenseDateLabel
            // 
            eligibilityLicenseDateLabel.AutoSize = true;
            eligibilityLicenseDateLabel.Location = new System.Drawing.Point(24, 230);
            eligibilityLicenseDateLabel.Name = "eligibilityLicenseDateLabel";
            eligibilityLicenseDateLabel.Size = new System.Drawing.Size(73, 13);
            eligibilityLicenseDateLabel.TabIndex = 11;
            eligibilityLicenseDateLabel.Text = "License Date:";
            // 
            // eligibilityLicenseDateDateTimePicker
            // 
            this.eligibilityLicenseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eligibilityBindingSource, "EligibilityLicenseDate", true));
            this.eligibilityLicenseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eligibilityLicenseDateDateTimePicker.Location = new System.Drawing.Point(130, 226);
            this.eligibilityLicenseDateDateTimePicker.Name = "eligibilityLicenseDateDateTimePicker";
            this.eligibilityLicenseDateDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.eligibilityLicenseDateDateTimePicker.TabIndex = 12;
            // 
            // modifieddateLabel
            // 
            modifieddateLabel.AutoSize = true;
            modifieddateLabel.Location = new System.Drawing.Point(24, 265);
            modifieddateLabel.Name = "modifieddateLabel";
            modifieddateLabel.Size = new System.Drawing.Size(76, 13);
            modifieddateLabel.TabIndex = 13;
            modifieddateLabel.Text = "Modified Date:";
            // 
            // modifieddateLabel2
            // 
            this.modifieddateLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eligibilityBindingSource, "modifieddate", true));
            this.modifieddateLabel2.Location = new System.Drawing.Point(127, 265);
            this.modifieddateLabel2.Name = "modifieddateLabel2";
            this.modifieddateLabel2.Size = new System.Drawing.Size(100, 23);
            this.modifieddateLabel2.TabIndex = 15;
            this.modifieddateLabel2.Text = "...";
            // 
            // EligibilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 304);
            this.Controls.Add(this.modifieddateLabel2);
            this.Controls.Add(modifieddateLabel);
            this.Controls.Add(eligibilityLicenseDateLabel);
            this.Controls.Add(this.eligibilityLicenseDateDateTimePicker);
            this.Controls.Add(eligibilityLicenseNoLabel);
            this.Controls.Add(this.eligibilityLicenseNoTextBox);
            this.Controls.Add(eligibilityExamPlaceLabel);
            this.Controls.Add(this.eligibilityExamPlaceTextBox);
            this.Controls.Add(eligibilityExamDateLabel);
            this.Controls.Add(this.eligibilityExamDateDateTimePicker);
            this.Controls.Add(eligibilityRatingLabel);
            this.Controls.Add(this.eligibilityRatingTextBox);
            this.Controls.Add(eligibilityNameLabel);
            this.Controls.Add(this.eligibilityNameTextBox);
            this.Controls.Add(this.eligibilityBindingNavigator);
            this.Name = "EligibilityForm";
            this.Text = "Eligibility Form";
            this.Load += new System.EventHandler(this.EligibilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingNavigator)).EndInit();
            this.eligibilityBindingNavigator.ResumeLayout(false);
            this.eligibilityBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eligibilityBindingSource;
        private System.Windows.Forms.BindingNavigator eligibilityBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eligibilityBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eligibilityNameTextBox;
        private System.Windows.Forms.TextBox eligibilityRatingTextBox;
        private System.Windows.Forms.DateTimePicker eligibilityExamDateDateTimePicker;
        private System.Windows.Forms.TextBox eligibilityExamPlaceTextBox;
        private System.Windows.Forms.TextBox eligibilityLicenseNoTextBox;
        private System.Windows.Forms.DateTimePicker eligibilityLicenseDateDateTimePicker;
        private System.Windows.Forms.Label modifieddateLabel2;
    }
}