using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace SimpleMD5Cracker
{
    public partial class Form1 : Form
    {
        string wordlsistPath;
        string rock;
        string en;
        string de;
        string top;
        string Hash;
        string Pass = "";
        bool close_loop = false;
        bool start = false;

        StreamReader file;
        StreamReader file1;
        StreamReader file2;
        StreamReader file3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            if (txtMD5.Text == "")
            {
                start = false;
            }
            else
            {
                start = true;
            }

            Hash = txtMD5.Text.ToUpper();
            txtPasswd.Clear();

            file = new StreamReader(Rock);
            file1 = new StreamReader(TOP);
            file2 = new StreamReader(EN);
            file3 = new StreamReader(DE);

            if(start == true)
            {
                try
                {
                    while (close_loop == false && (Pass = file.ReadLine()) != null)
                    {
                        if (MD5Hash(Pass).Equals(Hash))
                        {
                            txtPasswd.Text = Pass;
                            closeAll();
                            close_loop = true;
                        }
                        else
                        {
                            Pass = file1.ReadLine();
                            if (MD5Hash(Pass).Equals(Hash))
                            {
                                txtPasswd.Text = Pass;
                                closeAll();
                                close_loop = true;
                            }
                            else
                            {
                                Pass = file2.ReadLine();
                                if (MD5Hash(Pass).Equals(Hash))
                                {
                                    txtPasswd.Text = Pass;
                                    closeAll();
                                    close_loop = true;
                                }
                                else
                                {
                                    Pass = file3.ReadLine();
                                    if (MD5Hash(Pass).Equals(Hash))
                                    {
                                        txtPasswd.Text = Pass;
                                        closeAll();
                                        close_loop = true;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must type in the hash!");
            }

            close_loop = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Choose the path to the wordlists";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                wordlsistPath = Path.GetFullPath(dialog.SelectedPath);
                rock = wordlsistPath + @"\rockyou.txt";
                en = wordlsistPath + @"\english.txt";
                de = wordlsistPath + @"\german.txt";
                top = wordlsistPath + @"\top.txt";
                if (!File.Exists(rock))
                {
                    MessageBox.Show("Rockyou wasn/'t found!");
                }
                if (!File.Exists(en))
                {
                    MessageBox.Show("english wasn/'t found!");
                }
                if (!File.Exists(de))
                {
                    MessageBox.Show("german wasn/'t found!");
                }
                if (!File.Exists(top))
                {
                    MessageBox.Show("Top wasn/'t found!");
                }
            }
        }

        public string Rock
        {
            get
            {
                return rock;
            }
        }

        public string EN
        {
            get
            {
                return en;
            }
        }

        public string DE
        {
            get
            {
                return de;
            }
        }

        public string TOP
        {
            get
            {
                return top;
            }
        }

        private static string MD5Hash(string md5)
        {
            StringBuilder builder = new StringBuilder();
            MD5CryptoServiceProvider mD5Crypto = new MD5CryptoServiceProvider();
            byte[] bytes = mD5Crypto.ComputeHash(new UTF8Encoding().GetBytes(md5));

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2"));
            }
            return builder.ToString();
        }

        private void closeAll()
        {
            file.Close();
            file1.Close();
            file2.Close();
            file3.Close();
        }
    }
}
