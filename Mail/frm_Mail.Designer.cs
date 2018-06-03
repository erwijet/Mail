namespace Mail
{
    partial class frm_Mail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mail));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_creds_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_creds_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_useGmail = new System.Windows.Forms.CheckBox();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.rtb_body = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(60, 10);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(212, 20);
            this.tb_to.TabIndex = 1;
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(60, 36);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(212, 20);
            this.tb_from.TabIndex = 3;
            this.tb_from.TextChanged += new System.EventHandler(this.tb_from_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From: ";
            // 
            // tb_sub
            // 
            this.tb_sub.Location = new System.Drawing.Point(60, 62);
            this.tb_sub.Name = "tb_sub";
            this.tb_sub.Size = new System.Drawing.Size(212, 20);
            this.tb_sub.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tb_port);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_useGmail);
            this.groupBox1.Controls.Add(this.tb_host);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.tb_creds_password);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_creds_username);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 98);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_creds_password
            // 
            this.tb_creds_password.Location = new System.Drawing.Point(77, 43);
            this.tb_creds_password.Name = "tb_creds_password";
            this.tb_creds_password.Size = new System.Drawing.Size(139, 20);
            this.tb_creds_password.TabIndex = 15;
            this.tb_creds_password.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password: ";
            // 
            // tb_creds_username
            // 
            this.tb_creds_username.Location = new System.Drawing.Point(77, 17);
            this.tb_creds_username.Name = "tb_creds_username";
            this.tb_creds_username.Size = new System.Drawing.Size(139, 20);
            this.tb_creds_username.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username:";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(53, 82);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(172, 20);
            this.tb_port.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port: ";
            // 
            // cb_useGmail
            // 
            this.cb_useGmail.AutoSize = true;
            this.cb_useGmail.Location = new System.Drawing.Point(151, 59);
            this.cb_useGmail.Name = "cb_useGmail";
            this.cb_useGmail.Size = new System.Drawing.Size(74, 17);
            this.cb_useGmail.TabIndex = 9;
            this.cb_useGmail.Text = "Use Gmail";
            this.cb_useGmail.UseVisualStyleBackColor = true;
            this.cb_useGmail.CheckedChanged += new System.EventHandler(this.cb_useGmail_CheckedChanged);
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(53, 33);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(172, 20);
            this.tb_host.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Host: ";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(500, 302);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // rtb_body
            // 
            this.rtb_body.Location = new System.Drawing.Point(300, 36);
            this.rtb_body.Name = "rtb_body";
            this.rtb_body.Size = new System.Drawing.Size(275, 260);
            this.rtb_body.TabIndex = 7;
            this.rtb_body.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Body: ";
            // 
            // frm_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 340);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_body);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Mail";
            this.Text = "Mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_creds_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_creds_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_useGmail;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox rtb_body;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

