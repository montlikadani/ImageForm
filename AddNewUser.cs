using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace ImageForm {
    public partial class AddNewUser : Form {

        public AddNewUser() {
            InitializeComponent();

            szulDate.MaxDate = DateTime.Today;
            szulDate.MinDate = DateTime.Now.AddYears(-250);

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            openFileDialog.Filter = string.Format("{0}|All image files ({1})|{1}",
                string.Join("|", codecs.Select(codec => string.Format("{0} ({1})|{1}", codec.CodecName, codec.FilenameExtension)).ToArray()),
                string.Join(";", codecs.Select(codec => codec.FilenameExtension).ToArray()));
        }

        private async void addButton_Click(object sender, EventArgs e) {
            await Database.PerformSqlCommand("insert into `felhasznalo` (`nev`, `szuldate`, `pfp`) VALUES (@0, @1, @2);",
                nevBox.Text, szulDate.Value, Program.ImageToBytes(pictureBox.Image));

            Program.MainForm.RefreshUsers();
            Close();
        }

        private void nevBox_TextChanged(object sender, EventArgs e) {
            addButton.Enabled = nevBox.Text.Trim().Length != 0;
        }

        private void addImage_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void AddNewUser_FormClosing(object sender, FormClosingEventArgs e) {
            nevBox.Text = "";
            szulDate.Value = DateTime.Now.AddDays(-1);
            pictureBox.Image = null;
            addButton.Enabled = false;
        }
    }
}
