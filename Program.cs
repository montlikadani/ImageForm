using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageForm {
    internal static class Program {

        public static Form1 MainForm { get; private set; }

        [STAThread]
        static void Main() {
            _ = Database.SqlCommand;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm = new Form1());
        }

        public static byte[] ImageToBytes(Image img) {
            return (byte[]) new ImageConverter().ConvertTo(img, typeof(byte[]));
        }
    }
}
