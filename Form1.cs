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
            cb_rounds.SelectedItem = "1";
            cb_PBKDF2.SelectedItem = "No";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            byte[] bPasswd = Encoding.UTF8.GetBytes(txt_input.Text);
            string hashPasswd_tmp = String.Empty;

            if ( (string)cb_PBKDF2.SelectedItem == "No" )
            {
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
                            hashPasswd_tmp = "ERROR, unknown algorithm selected";
                        } break;
                }

                txt_result.Text = hashPasswd_tmp.Replace("-", "");
            }
            else if( (string)cb_PBKDF2.SelectedItem == "Yes" ) 
            {
                byte[] bSalt = Encoding.UTF8.GetBytes(txt_salt.Text);
                int itr = Convert.ToInt32((string)cb_rounds.SelectedItem);

                switch ((string)cb_algorithm.SelectedItem)
                {
                    case "SHA-512":
                        {
                            using (var hmac = new HMACSHA512())
                            {
                                var df = new Medo.Security.Cryptography.Pbkdf2(hmac, bPasswd, bSalt, itr);
                                hashPasswd_tmp = BitConverter.ToString(df.GetBytes(64));
                            }
                        } break;

                    case "SHA-384":
                        {
                            using (var hmac = new HMACSHA384())
                            {
                                var df = new Medo.Security.Cryptography.Pbkdf2(hmac, bPasswd, bSalt, itr);
                                hashPasswd_tmp = BitConverter.ToString(df.GetBytes(48));
                            }
                        } break;

                    case "SHA-256":
                        {
                            using (var hmac = new HMACSHA256())
                            {
                                var df = new Medo.Security.Cryptography.Pbkdf2(hmac, bPasswd, bSalt, itr);
                                hashPasswd_tmp = BitConverter.ToString(df.GetBytes(32));
                            }
                        } break;

                    case "SHA-1":
                        {
                            using (var hmac = new HMACSHA1())
                            {
                                var df = new Medo.Security.Cryptography.Pbkdf2(hmac, bPasswd, bSalt, itr);
                                hashPasswd_tmp = BitConverter.ToString(df.GetBytes(20));
                            }
                        } break;
                }

                txt_result.Text = hashPasswd_tmp.Replace("-", "");
            }
        }

        private void cb_PBKDF2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)cb_PBKDF2.SelectedItem)
            {
                case "Yes":
                    {
                        cb_rounds.Enabled = true;
                        txt_salt.Enabled = true;
                        txt_salt.ReadOnly = false;
                    } break;

                case "No":
                    {
                        cb_rounds.Enabled = false;
                        txt_salt.Enabled = false;
                        txt_salt.ReadOnly = true;
                    } break;

                default:
                    {
                        txt_result.Text = "ERROR, unknown PBKDF2 option selected";
                    } break;
            }
        }
    }
}
