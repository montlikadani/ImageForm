using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
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
            return (byte[])new ImageConverter().ConvertTo(img, typeof(byte[]));
        }

        public static string GetAllImageExtensions() {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            return string.Format("{0}|Összes kép fájl ({1})|{1}", string.Join("|", codecs.Select(codec =>
                string.Format("{0} ({1})|{1}", codec.CodecName, codec.FilenameExtension)).ToArray()),
                string.Join(";", codecs.Select(codec => codec.FilenameExtension).ToArray()));
        }
    }
}
