using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Mail
{
    public partial class frm_Mail : Form
    {
        public frm_Mail()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress to = new MailAddress(tb_to.Text);
                MailAddress from = new MailAddress(tb_from.Text);
                MailMessage mail = new MailMessage(from, to);
                mail.Subject = tb_sub.Text;
                mail.Body = rtb_body.Text;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = tb_host.Text;
                smtp.Port = int.Parse(tb_port.Text);
                smtp.Credentials = new NetworkCredential(
                    tb_creds_username.Text, tb_creds_password.Text);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Message Sent!", "Mail");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "OH NO!");
            }
        }

        private void cb_useGmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_useGmail.Checked)
            {
                tb_port.Text = "587";
                tb_host.Text = "smtp.gmail.com";
                tb_creds_username.Text = tb_from.Text;
                tb_port.Enabled = false;
                tb_host.Enabled = false;
            }
            else
            {
                tb_port.Text = "";
                tb_host.Text = "";
                tb_port.Enabled = true;
                tb_host.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tb_creds_password.UseSystemPasswordChar = false;
            else
                tb_creds_password.UseSystemPasswordChar = true;
        }

        private void tb_from_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_from.Text.Substring(tb_from.Text.Length - "@gmail.com".Length).ToLower() == "@gmail.com")
                    cb_useGmail.Checked = true;
                else
                    if (tb_from.Text.Length >= 10)
                        cb_useGmail.Checked = false;
            }
            catch { }
        }
    }
}
