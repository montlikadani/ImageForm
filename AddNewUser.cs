using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageForm {
    public partial class AddNewUser : Form {

        public AddNewUser() {
            InitializeComponent();

            szulDate.MaxDate = DateTime.Today;
            szulDate.MinDate = DateTime.Now.AddYears(-250);

            openFileDialog.Filter = Program.GetAllImageExtensions();
            openFileDialog.AddExtension = openFileDialog.CheckFileExists = openFileDialog.CheckPathExists = true;
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
                removeImgButton.Enabled = true;
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

        private void removeImgButton_Click(object sender, EventArgs e) {
            pictureBox.Image = null;
            removeImgButton.Enabled = false;
        }
    }
}
