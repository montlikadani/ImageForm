using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageForm {
    public sealed class Database {

        public static MySqlConnection Connection { get; private set; }
        public static MySqlCommand SqlCommand { get; private set; }

        static Database() {
            try {
                (Connection = new MySqlConnection("server=localhost;user=root;database=felhasznalok;")).Open();
                SqlCommand = Connection.CreateCommand();
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Adatbázis kapcsolódás sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private Database() {
        }

        public static async Task<bool> PerformSqlCommand(string cmd, params object[] values) {
            SqlCommand.CommandText = cmd;
            SqlCommand.Parameters.Clear();

            for (int i = 0; i < values.Length; i++) {
                SqlCommand.Parameters.AddWithValue($"@{i}", values[i]);
            }

            try {
                if ((await SqlCommand.ExecuteNonQueryAsync()) != 1) {
                    return false;
                }
            } catch (System.Data.Common.DbException ex) {
                MessageBox.Show("Hiba lépett fel az adatbázis parancs végrehajtásakor: " + ex.Message, "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
