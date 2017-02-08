namespace PDSSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDataSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDSListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfLeaveApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.leavePreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizardFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPDSList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBarcode = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLeave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonService = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.serviceRecordToolStripMenuItem,
            this.leaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "&Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logo&ut";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDataSheetToolStripMenuItem,
            this.serviceRecordToolStripMenuItem1,
            this.leaveManagementToolStripMenuItem,
            this.toolStripMenuItem2,
            this.preferencesToolStripMenuItem,
            this.wizardFormToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // personalDataSheetToolStripMenuItem
            // 
            this.personalDataSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDSListToolStripMenuItem,
            this.updatePDSToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.settingToolStripMenuItem});
            this.personalDataSheetToolStripMenuItem.Name = "personalDataSheetToolStripMenuItem";
            this.personalDataSheetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.personalDataSheetToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.personalDataSheetToolStripMenuItem.Text = "&Personal Data Sheet Management";
            // 
            // pDSListToolStripMenuItem
            // 
            this.pDSListToolStripMenuItem.Name = "pDSListToolStripMenuItem";
            this.pDSListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.pDSListToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.pDSListToolStripMenuItem.Text = "&PDS List";
            this.pDSListToolStripMenuItem.Click += new System.EventHandler(this.pDSListToolStripMenuItem_Click);
            // 
            // updatePDSToolStripMenuItem
            // 
            this.updatePDSToolStripMenuItem.Name = "updatePDSToolStripMenuItem";
            this.updatePDSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.updatePDSToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.updatePDSToolStripMenuItem.Text = "&Barcode Search";
            this.updatePDSToolStripMenuItem.Click += new System.EventHandler(this.updatePDSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem5.Text = "Wizard PDS Form";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.settingToolStripMenuItem.Text = "&Preferences";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // serviceRecordToolStripMenuItem1
            // 
            this.serviceRecordToolStripMenuItem1.Name = "serviceRecordToolStripMenuItem1";
            this.serviceRecordToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.serviceRecordToolStripMenuItem1.Size = new System.Drawing.Size(293, 22);
            this.serviceRecordToolStripMenuItem1.Text = "&Service Record Management";
            // 
            // leaveManagementToolStripMenuItem
            // 
            this.leaveManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfLeaveApplicationToolStripMenuItem,
            this.toolStripMenuItem4,
            this.leavePreferencesToolStripMenuItem});
            this.leaveManagementToolStripMenuItem.Name = "leaveManagementToolStripMenuItem";
            this.leaveManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.leaveManagementToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.leaveManagementToolStripMenuItem.Text = "&Leave Management";
            // 
            // listOfLeaveApplicationToolStripMenuItem
            // 
            this.listOfLeaveApplicationToolStripMenuItem.Name = "listOfLeaveApplicationToolStripMenuItem";
            this.listOfLeaveApplicationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listOfLeaveApplicationToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.listOfLeaveApplicationToolStripMenuItem.Text = "List of Leave Application";
            this.listOfLeaveApplicationToolStripMenuItem.Click += new System.EventHandler(this.listOfLeaveApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(240, 6);
            // 
            // leavePreferencesToolStripMenuItem
            // 
            this.leavePreferencesToolStripMenuItem.Name = "leavePreferencesToolStripMenuItem";
            this.leavePreferencesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.leavePreferencesToolStripMenuItem.Text = "Leave Preferences";
            this.leavePreferencesToolStripMenuItem.Click += new System.EventHandler(this.leavePreferencesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(290, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.preferencesToolStripMenuItem.Text = "&User Management";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // wizardFormToolStripMenuItem
            // 
            this.wizardFormToolStripMenuItem.Name = "wizardFormToolStripMenuItem";
            this.wizardFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.wizardFormToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.wizardFormToolStripMenuItem.Text = "&Wizard Form";
            this.wizardFormToolStripMenuItem.Click += new System.EventHandler(this.wizardFormToolStripMenuItem_Click);
            // 
            // serviceRecordToolStripMenuItem
            // 
            this.serviceRecordToolStripMenuItem.Name = "serviceRecordToolStripMenuItem";
            this.serviceRecordToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.serviceRecordToolStripMenuItem.Text = "&Report";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.leaveToolStripMenuItem.Text = "&Windows";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPDSList,
            this.toolStripButtonBarcode,
            this.toolStripButtonLeave,
            this.toolStripButtonService});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1150, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPDSList
            // 
            this.toolStripButtonPDSList.Image = global::PDSSystem.Properties.Resources.Contacts_2;
            this.toolStripButtonPDSList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPDSList.Name = "toolStripButtonPDSList";
            this.toolStripButtonPDSList.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonPDSList.Text = "PDS List";
            this.toolStripButtonPDSList.Click += new System.EventHandler(this.toolStripButtonPDSList_Click);
            // 
            // toolStripButtonBarcode
            // 
            this.toolStripButtonBarcode.Image = global::PDSSystem.Properties.Resources.Compose_Email;
            this.toolStripButtonBarcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBarcode.Name = "toolStripButtonBarcode";
            this.toolStripButtonBarcode.Size = new System.Drawing.Size(108, 22);
            this.toolStripButtonBarcode.Text = "Barcode Search";
            this.toolStripButtonBarcode.Click += new System.EventHandler(this.toolStripButtonBarcode_Click);
            // 
            // toolStripButtonLeave
            // 
            this.toolStripButtonLeave.Image = global::PDSSystem.Properties.Resources.Pics_1;
            this.toolStripButtonLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLeave.Name = "toolStripButtonLeave";
            this.toolStripButtonLeave.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonLeave.Text = "Leave Form";
            // 
            // toolStripButtonService
            // 
            this.toolStripButtonService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonService.Name = "toolStripButtonService";
            this.toolStripButtonService.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonService.Text = "Service Record";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 437);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDataSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leaveManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDSListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonPDSList;
        private System.Windows.Forms.ToolStripButton toolStripButtonBarcode;
        private System.Windows.Forms.ToolStripButton toolStripButtonLeave;
        private System.Windows.Forms.ToolStripButton toolStripButtonService;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem wizardFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfLeaveApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem leavePreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

