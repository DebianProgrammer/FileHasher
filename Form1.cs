using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FileHasher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // maybe make a something that compares the file hashes with something the user enters
        private void Copy512_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA512text.Text);
        }

        private void SHA1text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "All Files(*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            string realmd5 = GetMD5Hash(openFileDialog1.FileName);
            string realsha1 = GetSHA1Hash(openFileDialog1.FileName);
            string realsha256 = GetSHA256Hash(openFileDialog1.FileName);
            string realsha384 = GetSHA384Hash(openFileDialog1.FileName);
            string realsha512 = GetSHA512Hash(openFileDialog1.FileName);
            MD5text.Text = realmd5;
            SHA1text.Text = realsha1;
            SHA256text.Text = realsha256;
            SHA384text.Text = realsha384;
            SHA512text.Text = realsha512;
            
        }
        // md5 below
        public static string GetMD5Hash(string str)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] bytes = Encoding.Default.GetBytes(str);
            byte[] encoded = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
                sb.Append(encoded[i].ToString("x2"));

            return sb.ToString();
        }
        // sha1 below
        public static string GetSHA1Hash(string str)
        {
            System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] bytes = Encoding.Default.GetBytes(str);
            byte[] encoded = sha1.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
                sb.Append(encoded[i].ToString("x2"));

            return sb.ToString();
        }
        // sha256 below
        public static string GetSHA256Hash(string str)
        {
            System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] bytes = Encoding.Default.GetBytes(str);
            byte[] encoded = sha256.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
                sb.Append(encoded[i].ToString("x2"));

            return sb.ToString();
        }
        // sha384 below
        public static string GetSHA384Hash(string str)
        {
            System.Security.Cryptography.SHA384 sha384 = System.Security.Cryptography.SHA384.Create();
            byte[] bytes = Encoding.Default.GetBytes(str);
            byte[] encoded = sha384.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
                sb.Append(encoded[i].ToString("x2"));

            return sb.ToString();
        }
        // sha512 below
        public static string GetSHA512Hash(string str)
        {
            System.Security.Cryptography.SHA512 sha512 = System.Security.Cryptography.SHA512.Create();
            byte[] bytes = Encoding.Default.GetBytes(str);
            byte[] encoded = sha512.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
                sb.Append(encoded[i].ToString("x2"));

            return sb.ToString();
        }
        private void ComparePaste_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
        }

        private void Copy256_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA256text.Text);
        }

        private void Copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA1text.Text);
        }

        private void Copy5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MD5text.Text);
        }

        private void CompareMD5_Click(object sender, EventArgs e)
        { // i dont know if it detects capital letters and lowercase letters yet
            if(String.Equals(textBox2.Text, MD5text.Text, StringComparison.OrdinalIgnoreCase) == true)
            {
                MessageBox.Show("They are the same", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("They are not the same!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompareSHA384_Click(object sender, EventArgs e)
        {
            if (String.Equals(textBox2.Text, SHA384text.Text, StringComparison.OrdinalIgnoreCase) == true)
            {
                MessageBox.Show("They are the same", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("They are not the same!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Copy384_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA384text.Text);
        }

        private void CompareSHA1_Click(object sender, EventArgs e)
        {
            if(String.Equals(textBox2.Text, SHA1text.Text, StringComparison.OrdinalIgnoreCase) == true) 
            {
                MessageBox.Show("They are the same", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("They are not the same!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompareSHA256_Click(object sender, EventArgs e)
        {
            if (String.Equals(textBox2.Text, SHA256text.Text, StringComparison.OrdinalIgnoreCase) == true)
            {
                MessageBox.Show("They are the same", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("They are not the same!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompareSHA512_Click(object sender, EventArgs e)
        {
            if (String.Equals(textBox2.Text, SHA512text.Text, StringComparison.OrdinalIgnoreCase) == true)
            {
                MessageBox.Show("They are the same", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("They are not the same!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
