using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Fencrypt_GUI
{

    public partial class Home : Form
    {
        private Browser childform;
        private EncryptWindow childform2;

        private string finalpath = "";
        public Home()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a text encryption tool which uses 256-bit AES to secure private text files of your choosing." +
                "\nIt was created by Alan Szuszkiewicz.");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var form2 = new Browser(this))
            {
                form2.ShowDialog();
            }
        }
        private void openTxt_Click(object sender, EventArgs e)
        {
            using (var form3 = new EncryptWindow(this))
            {
                form3.ShowDialog();
            }
            // TODO: Send path to decrypt portion of AES_256 Encryptor
            // Open Decrypted text in separate window with edit options
            // save button which re-encrypts the file
        }
    }
}
