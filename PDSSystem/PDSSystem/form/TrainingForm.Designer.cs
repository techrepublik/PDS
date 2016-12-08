namespace PDSSystem.form
{
    partial class TrainingForm
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
            System.Windows.Forms.Label trainingNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label trainingDate1Label;
            System.Windows.Forms.Label trainingDate2Label;
            System.Windows.Forms.Label trainingNoHoursLabel;
            System.Windows.Forms.Label trainingSponsorLabel;
            System.Windows.Forms.Label modifieddateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            this.trainingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.trainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.trainingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.trainingNameTextBox = new System.Windows.Forms.TextBox();
            this.trainingDate1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trainingDate2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trainingNoHoursTextBox = new System.Windows.Forms.TextBox();
            this.trainingSponsorTextBox = new System.Windows.Forms.TextBox();
            this.modifieddateLabel1 = new System.Windows.Forms.Label();
            trainingNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            trainingDate1Label = new System.Windows.Forms.Label();
            trainingDate2Label = new System.Windows.Forms.Label();
            trainingNoHoursLabel = new System.Windows.Forms.Label();
            trainingSponsorLabel = new System.Windows.Forms.Label();
            modifieddateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBindingNavigator)).BeginInit();
            this.trainingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingNameLabel
            // 
            trainingNameLabel.AutoSize = true;
            trainingNameLabel.Location = new System.Drawing.Point(22, 52);
            trainingNameLabel.Name = "trainingNameLabel";
            trainingNameLabel.Size = new System.Drawing.Size(140, 13);
            trainingNameLabel.TabIndex = 1;
            trainingNameLabel.Text = "Title of Seminar/Conference";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 13);
            label1.TabIndex = 3;
            label1.Text = "Workshop/Short Courses";
            // 
            // trainingDate1Label
            // 
            trainingDate1Label.AutoSize = true;
            trainingDate1Label.Location = new System.Drawing.Point(22, 105);
            trainingDate1Label.Name = "trainingDate1Label";
            trainingDate1Label.Size = new System.Drawing.Size(108, 13);
            trainingDate1Label.TabIndex = 4;
            trainingDate1Label.Text = "Training Date (Start) :";
            // 
            // trainingDate2Label
            // 
            trainingDate2Label.AutoSize = true;
            trainingDate2Label.Location = new System.Drawing.Point(22, 130);
            trainingDate2Label.Name = "trainingDate2Label";
            trainingDate2Label.Size = new System.Drawing.Size(102, 13);
            trainingDate2Label.TabIndex = 6;
            trainingDate2Label.Text = "Training Date (End):";
            // 
            // trainingNoHoursLabel
            // 
            trainingNoHoursLabel.AutoSize = true;
            trainingNoHoursLabel.Location = new System.Drawing.Point(22, 155);
            trainingNoHoursLabel.Name = "trainingNoHoursLabel";
            trainingNoHoursLabel.Size = new System.Drawing.Size(67, 13);
            trainingNoHoursLabel.TabIndex = 8;
            trainingNoHoursLabel.Text = "No of Hours:";
            // 
            // trainingSponsorLabel
            // 
            trainingSponsorLabel.AutoSize = true;
            trainingSponsorLabel.Location = new System.Drawing.Point(22, 179);
            trainingSponsorLabel.Name = "trainingSponsorLabel";
            trainingSponsorLabel.Size = new System.Drawing.Size(90, 13);
            trainingSponsorLabel.TabIndex = 10;
            trainingSponsorLabel.Text = "Training Sponsor:";
            // 
            // modifieddateLabel
            // 
            modifieddateLabel.AutoSize = true;
            modifieddateLabel.Location = new System.Drawing.Point(22, 233);
            modifieddateLabel.Name = "modifieddateLabel";
            modifieddateLabel.Size = new System.Drawing.Size(76, 13);
            modifieddateLabel.TabIndex = 12;
            modifieddateLabel.Text = "Modified Date:";
            // 
            // trainingBindingNavigator
            // 
            this.trainingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trainingBindingNavigator.BindingSource = this.trainingBindingSource;
            this.trainingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trainingBindingNavigator.DeleteItem = null;
            this.trainingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.trainingBindingNavigatorSaveItem});
            this.trainingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trainingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trainingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trainingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trainingBindingNavigator.Name = "trainingBindingNavigator";
            this.trainingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trainingBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.trainingBindingNavigator.TabIndex = 0;
            this.trainingBindingNavigator.Text = "bindingNavigator1";
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
            // trainingBindingSource
            // 
            this.trainingBindingSource.DataSource = typeof(PDSSystem.dal.data.Training);
            this.trainingBindingSource.CurrentChanged += new System.EventHandler(this.trainingBindingSource_CurrentChanged);
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
            // trainingBindingNavigatorSaveItem
            // 
            this.trainingBindingNavigatorSaveItem.Enabled = false;
            this.trainingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trainingBindingNavigatorSaveItem.Image")));
            this.trainingBindingNavigatorSaveItem.Name = "trainingBindingNavigatorSaveItem";
            this.trainingBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.trainingBindingNavigatorSaveItem.Text = "Save Data";
            this.trainingBindingNavigatorSaveItem.Click += new System.EventHandler(this.trainingBindingNavigatorSaveItem_Click);
            // 
            // trainingNameTextBox
            // 
            this.trainingNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingBindingSource, "TrainingName", true));
            this.trainingNameTextBox.Location = new System.Drawing.Point(170, 49);
            this.trainingNameTextBox.Multiline = true;
            this.trainingNameTextBox.Name = "trainingNameTextBox";
            this.trainingNameTextBox.Size = new System.Drawing.Size(434, 44);
            this.trainingNameTextBox.TabIndex = 0;
            // 
            // trainingDate1DateTimePicker
            // 
            this.trainingDate1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trainingBindingSource, "TrainingDate1", true));
            this.trainingDate1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trainingDate1DateTimePicker.Location = new System.Drawing.Point(170, 100);
            this.trainingDate1DateTimePicker.Name = "trainingDate1DateTimePicker";
            this.trainingDate1DateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.trainingDate1DateTimePicker.TabIndex = 1;
            // 
            // trainingDate2DateTimePicker
            // 
            this.trainingDate2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trainingBindingSource, "TrainingDate2", true));
            this.trainingDate2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.trainingDate2DateTimePicker.Location = new System.Drawing.Point(170, 126);
            this.trainingDate2DateTimePicker.Name = "trainingDate2DateTimePicker";
            this.trainingDate2DateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.trainingDate2DateTimePicker.TabIndex = 2;
            // 
            // trainingNoHoursTextBox
            // 
            this.trainingNoHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingBindingSource, "TrainingNoHours", true));
            this.trainingNoHoursTextBox.Location = new System.Drawing.Point(170, 151);
            this.trainingNoHoursTextBox.Name = "trainingNoHoursTextBox";
            this.trainingNoHoursTextBox.Size = new System.Drawing.Size(140, 20);
            this.trainingNoHoursTextBox.TabIndex = 3;
            // 
            // trainingSponsorTextBox
            // 
            this.trainingSponsorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingBindingSource, "TrainingSponsor", true));
            this.trainingSponsorTextBox.Location = new System.Drawing.Point(170, 176);
            this.trainingSponsorTextBox.Multiline = true;
            this.trainingSponsorTextBox.Name = "trainingSponsorTextBox";
            this.trainingSponsorTextBox.Size = new System.Drawing.Size(434, 42);
            this.trainingSponsorTextBox.TabIndex = 4;
            // 
            // modifieddateLabel1
            // 
            this.modifieddateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainingBindingSource, "modifieddate", true));
            this.modifieddateLabel1.Location = new System.Drawing.Point(170, 232);
            this.modifieddateLabel1.Name = "modifieddateLabel1";
            this.modifieddateLabel1.Size = new System.Drawing.Size(100, 23);
            this.modifieddateLabel1.TabIndex = 13;
            this.modifieddateLabel1.Text = "...";
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 276);
            this.Controls.Add(modifieddateLabel);
            this.Controls.Add(this.modifieddateLabel1);
            this.Controls.Add(trainingSponsorLabel);
            this.Controls.Add(this.trainingSponsorTextBox);
            this.Controls.Add(trainingNoHoursLabel);
            this.Controls.Add(this.trainingNoHoursTextBox);
            this.Controls.Add(trainingDate2Label);
            this.Controls.Add(this.trainingDate2DateTimePicker);
            this.Controls.Add(trainingDate1Label);
            this.Controls.Add(this.trainingDate1DateTimePicker);
            this.Controls.Add(label1);
            this.Controls.Add(trainingNameLabel);
            this.Controls.Add(this.trainingNameTextBox);
            this.Controls.Add(this.trainingBindingNavigator);
            this.Name = "TrainingForm";
            this.Text = "Training Form";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingBindingNavigator)).EndInit();
            this.trainingBindingNavigator.ResumeLayout(false);
            this.trainingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource trainingBindingSource;
        private System.Windows.Forms.BindingNavigator trainingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton trainingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox trainingNameTextBox;
        private System.Windows.Forms.DateTimePicker trainingDate1DateTimePicker;
        private System.Windows.Forms.DateTimePicker trainingDate2DateTimePicker;
        private System.Windows.Forms.TextBox trainingNoHoursTextBox;
        private System.Windows.Forms.TextBox trainingSponsorTextBox;
        private System.Windows.Forms.Label modifieddateLabel1;
    }
}