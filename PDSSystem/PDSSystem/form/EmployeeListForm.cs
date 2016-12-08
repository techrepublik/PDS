using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BarcodeLib;
using PDSSystem.dal.classes;
using PDSSystem.dal.data;
using PDSSystem.dal.man;

namespace PDSSystem.form
{
    public partial class EmployeeListForm : Form
    {
        Barcode _b = new Barcode();
        public Personnel Personnel { get; set; }
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            if (Personnel == null) return;
            personnelBindingSource.DataSource = Personnel;
        }

        private void personnelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (personnelBindingSource != null)
            {
                Validate();
                if (pictureBox1.Image != null)
                    ((Personnel) personnelBindingSource.Current).Photo = UtilityClass.ImageToByte(pictureBox1.Image);
                if (_b.EncodedImage != null)
                    ((Personnel) personnelBindingSource.Current).BarcodeImage = UtilityClass.ImageToByte(_b.EncodedImage);
                personnelBindingSource.EndEdit();
                var iResult = PersonnelManagement.Save((Personnel)personnelBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    cSIdNoTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void personnelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (personnelBindingSource != null)
            {
                personnelBindingNavigatorSaveItem.Enabled = true;
                if (((Personnel)personnelBindingSource.Current).Photo != null)
                {
                    pictureBox1.Image = UtilityClass.ByteToImage(((Personnel)personnelBindingSource.Current).Photo.ToArray());
                }
                GenrateBarcode(personnelIdNoTextBox.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = @"Jpeg (*.jpg)|*.jpg|Jpeg (*.jpeg)|*.jpeg|Png (*.png) |*.png|Gif (*.gif) | *.gif";
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = openDialog.FileName;
                byte[] tempBuffer = UtilityClass.ReadFile(openDialog.FileName);
                pictureBox1.Image = UtilityClass.ByteToImage(tempBuffer);
            }
        }

        private void linkLabelBarcode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenrateBarcode(personnelIdNoTextBox.Text);
        }

        private void GenrateBarcode(string barcodeText)
        {
            if (barcodeText.Length > 0)
            {
                try
                {
                    var W = 280;
                    var H = 70;

                    _b.Alignment = AlignmentPositions.CENTER;
                    TYPE type = TYPE.CODE128;
                    _b.IncludeLabel = true;
                    _b.LabelPosition = LabelPositions.BOTTOMCENTER;

                    barcode.BackgroundImage = _b.Encode(type, personnelIdNoTextBox.Text.Trim(), Color.Black, Color.White, W,
                        H);

                    barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2,
                        (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"There was an error gnerating barcode. Please check Agency Id No.",
                        @"Barcode Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Write(ex.Message);
                }
                
            }
        }
    }
}
