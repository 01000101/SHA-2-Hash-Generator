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

namespace SHA2HashGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cb_algorithm.SelectedItem = "SHA-512";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            byte[] bPasswd = Encoding.UTF8.GetBytes(txt_input.Text);
            string hashPasswd_tmp = String.Empty;

            switch ((string)cb_algorithm.SelectedItem)
            {
                case "SHA-512":
                    {
                        using (SHA512 shaM = new SHA512Managed())
                        {
                            hashPasswd_tmp = BitConverter.ToString(shaM.ComputeHash(bPasswd));
                        }
                    } break;

                case "SHA-384":
                    {
                        using (SHA384 shaM = new SHA384Managed())
                        {
                            hashPasswd_tmp = BitConverter.ToString(shaM.ComputeHash(bPasswd));
                        }
                    } break;

                case "SHA-256":
                    {
                        using (SHA256 shaM = new SHA256Managed())
                        {
                            hashPasswd_tmp = BitConverter.ToString(shaM.ComputeHash(bPasswd));
                        }
                    } break;

                case "SHA-1":
                    {
                        using (SHA1 shaM = new SHA1Managed())
                        {
                            hashPasswd_tmp = BitConverter.ToString(shaM.ComputeHash(bPasswd));
                        }
                    } break;

                default:
                    {
                        hashPasswd_tmp = "ERROR, unkonwn algorithm selected";
                    } break;
            }

            txt_result.Text = hashPasswd_tmp.Replace("-", "");
        }
    }
}
