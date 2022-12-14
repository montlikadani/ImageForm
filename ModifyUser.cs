using System;
using System.Windows.Forms;

namespace ImageForm {
    public partial class ModifyUser : Form {

        public User currentUser;

        public ModifyUser() {
            InitializeComponent();

            szulDate.MaxDate = DateTime.Today;
            szulDate.MinDate = DateTime.Now.AddYears(-250);

            openFileDialog.Filter = Program.GetAllImageExtensions();
            openFileDialog.AddExtension = openFileDialog.CheckFileExists = openFileDialog.CheckPathExists = true;
        }

        private void ModifyUser_Load(object sender, EventArgs e) {
            szulDate.Value = currentUser.SzulDate;
            nevBox.Text = currentUser.Nev;
            removeImgButton.Enabled = (pictureBox.Image = currentUser.ProfilePicture) != null;
        }

        private async void modifyUserButton_Click(object sender, EventArgs e) {
            await Database.PerformSqlCommand("update `felhasznalo` set `nev` = @0, `szuldate` = @1, `pfp` = @2 where `id` = @3;",
               nevBox.Text, szulDate.Value, Program.ImageToBytes(pictureBox.Image), currentUser.Id);

            Program.MainForm.RefreshUsers();
            MessageBox.Show("A felhasználó adatai frissítve lettek", "Felhasználó adatok frissítése", MessageBoxButtons.OK);
            Close();
        }

        private void ModifyUser_FormClosing(object sender, FormClosingEventArgs e) {
            nevBox.Text = "";
            szulDate.Value = DateTime.Now.AddDays(-1);
            pictureBox.Image = null;
        }

        private void addImage_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                removeImgButton.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void removeImgButton_Click(object sender, EventArgs e) {
            pictureBox.Image = null;
            removeImgButton.Enabled = false;
        }

        private void nevBox_TextChanged(object sender, EventArgs e) {
            modifyUserButton.Enabled = nevBox.Text.Trim().Length != 0;
        }
    }
}
