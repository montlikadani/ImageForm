using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageForm {
    public partial class Form1 : Form {

        private readonly AddNewUser addNewUser;
        private readonly ModifyUser modifyUser;

        public Form1() {
            InitializeComponent();

            addNewUser = new AddNewUser();
            modifyUser = new ModifyUser();
            RefreshUsers();
        }

        public void RefreshUsers() {
            usersBox.Items.Clear();

            Database.SqlCommand.CommandText = "select * from felhasznalo;";

            using (MySqlDataReader reader = Database.SqlCommand.ExecuteReader()) {
                while (reader.Read()) {
                    byte[] imgBytes = reader.GetFieldValue<byte[]>(3);

                    usersBox.Items.Add(new User(reader.GetInt32("id"), reader.GetString("nev"), reader.GetDateTime("szuldate"),
                        imgBytes.Length == 0 ? null : Image.FromStream(new MemoryStream(imgBytes))));
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            addNewUser.ShowDialog(this);
        }

        private void usersBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (!(usersBox.SelectedItem is User user)) {
                return;
            }

            changeButton.Enabled = removeButton.Enabled = true;

            nevBox.Text = user.Nev;
            szulDate.Text = user.SzulDate.ToString();
            pictureBox.Image = user.ProfilePicture;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Database.Connection.Close();
        }

        private async void removeButton_Click(object sender, EventArgs e) {
            if (!(usersBox.SelectedItem is User user)) {
                return;
            }

            if (MessageBox.Show("Biztosan el szeretné távolítani a kiválasztott felhasználót?", "felhasználói adat eltávolítása", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) {
                return;
            }

            await Database.PerformSqlCommand("delete from `felhasznalo` where `id` = @0;", user.Id);

            changeButton.Enabled = removeButton.Enabled = false;
            nevBox.Text = szulDate.Text = "";
            pictureBox.Image = null;
            RefreshUsers();

            MessageBox.Show("A kiválasztott felhasználó eltávolítva", "Felhasználói adat eltávolítva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeButton_Click(object sender, EventArgs e) {
            modifyUser.currentUser = usersBox.SelectedItem as User;
            modifyUser.ShowDialog(this);
        }
    }
}
