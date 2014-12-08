namespace SHA2HashGenerator
{
    partial class Form1
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
            this.txt_result = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_algorithm = new System.Windows.Forms.ComboBox();
            this.lbl_algorithm = new System.Windows.Forms.Label();
            this.lbl_rounds = new System.Windows.Forms.Label();
            this.cb_rounds = new System.Windows.Forms.ComboBox();
            this.lbl_PBKDF2 = new System.Windows.Forms.Label();
            this.cb_PBKDF2 = new System.Windows.Forms.ComboBox();
            this.lbl_salt = new System.Windows.Forms.Label();
            this.txt_salt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.DimGray;
            this.txt_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.ForeColor = System.Drawing.Color.White;
            this.txt_result.Location = new System.Drawing.Point(12, 340);
            this.txt_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_result.MaxLength = 128;
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(630, 128);
            this.txt_result.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(12, 317);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(58, 19);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "Result";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(14, 19);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(48, 19);
            this.lbl_input.TabIndex = 3;
            this.lbl_input.Text = "Input";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.Color.DimGray;
            this.txt_input.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.ForeColor = System.Drawing.Color.White;
            this.txt_input.Location = new System.Drawing.Point(14, 42);
            this.txt_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_input.MaxLength = 512;
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(628, 128);
            this.txt_input.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_submit.Location = new System.Drawing.Point(282, 476);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(106, 43);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Hash";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_algorithm
            // 
            this.cb_algorithm.BackColor = System.Drawing.Color.DimGray;
            this.cb_algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_algorithm.ForeColor = System.Drawing.Color.White;
            this.cb_algorithm.FormattingEnabled = true;
            this.cb_algorithm.Items.AddRange(new object[] {
            "SHA-512",
            "SHA-384",
            "SHA-256",
            "SHA-1"});
            this.cb_algorithm.Location = new System.Drawing.Point(14, 209);
            this.cb_algorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_algorithm.Name = "cb_algorithm";
            this.cb_algorithm.Size = new System.Drawing.Size(140, 24);
            this.cb_algorithm.TabIndex = 4;
            // 
            // lbl_algorithm
            // 
            this.lbl_algorithm.AutoSize = true;
            this.lbl_algorithm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_algorithm.Location = new System.Drawing.Point(14, 183);
            this.lbl_algorithm.Name = "lbl_algorithm";
            this.lbl_algorithm.Size = new System.Drawing.Size(83, 19);
            this.lbl_algorithm.TabIndex = 5;
            this.lbl_algorithm.Text = "Algorithm";
            this.lbl_algorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rounds
            // 
            this.lbl_rounds.AutoSize = true;
            this.lbl_rounds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rounds.Location = new System.Drawing.Point(502, 183);
            this.lbl_rounds.Name = "lbl_rounds";
            this.lbl_rounds.Size = new System.Drawing.Size(70, 19);
            this.lbl_rounds.TabIndex = 7;
            this.lbl_rounds.Text = "Rounds";
            this.lbl_rounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_rounds
            // 
            this.cb_rounds.BackColor = System.Drawing.Color.DimGray;
            this.cb_rounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rounds.Enabled = false;
            this.cb_rounds.ForeColor = System.Drawing.Color.White;
            this.cb_rounds.FormattingEnabled = true;
            this.cb_rounds.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000",
            "100000"});
            this.cb_rounds.Location = new System.Drawing.Point(502, 209);
            this.cb_rounds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_rounds.Name = "cb_rounds";
            this.cb_rounds.Size = new System.Drawing.Size(140, 24);
            this.cb_rounds.TabIndex = 6;
            // 
            // lbl_PBKDF2
            // 
            this.lbl_PBKDF2.AutoSize = true;
            this.lbl_PBKDF2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PBKDF2.Location = new System.Drawing.Point(269, 183);
            this.lbl_PBKDF2.Name = "lbl_PBKDF2";
            this.lbl_PBKDF2.Size = new System.Drawing.Size(75, 19);
            this.lbl_PBKDF2.TabIndex = 9;
            this.lbl_PBKDF2.Text = "PBKDF2";
            this.lbl_PBKDF2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_PBKDF2
            // 
            this.cb_PBKDF2.BackColor = System.Drawing.Color.DimGray;
            this.cb_PBKDF2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PBKDF2.ForeColor = System.Drawing.Color.White;
            this.cb_PBKDF2.FormattingEnabled = true;
            this.cb_PBKDF2.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cb_PBKDF2.Location = new System.Drawing.Point(269, 209);
            this.cb_PBKDF2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_PBKDF2.Name = "cb_PBKDF2";
            this.cb_PBKDF2.Size = new System.Drawing.Size(140, 24);
            this.cb_PBKDF2.TabIndex = 8;
            this.cb_PBKDF2.SelectedIndexChanged += new System.EventHandler(this.cb_PBKDF2_SelectedIndexChanged);
            // 
            // lbl_salt
            // 
            this.lbl_salt.AutoSize = true;
            this.lbl_salt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salt.Location = new System.Drawing.Point(12, 247);
            this.lbl_salt.Name = "lbl_salt";
            this.lbl_salt.Size = new System.Drawing.Size(38, 19);
            this.lbl_salt.TabIndex = 10;
            this.lbl_salt.Text = "Salt";
            this.lbl_salt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_salt
            // 
            this.txt_salt.BackColor = System.Drawing.Color.DimGray;
            this.txt_salt.Enabled = false;
            this.txt_salt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salt.ForeColor = System.Drawing.Color.White;
            this.txt_salt.Location = new System.Drawing.Point(14, 270);
            this.txt_salt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_salt.MaxLength = 128;
            this.txt_salt.Name = "txt_salt";
            this.txt_salt.ReadOnly = true;
            this.txt_salt.Size = new System.Drawing.Size(630, 26);
            this.txt_salt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(654, 532);
            this.Controls.Add(this.lbl_salt);
            this.Controls.Add(this.txt_salt);
            this.Controls.Add(this.lbl_PBKDF2);
            this.Controls.Add(this.cb_PBKDF2);
            this.Controls.Add(this.lbl_rounds);
            this.Controls.Add(this.cb_rounds);
            this.Controls.Add(this.lbl_algorithm);
            this.Controls.Add(this.cb_algorithm);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_result);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 570);
            this.MinimumSize = new System.Drawing.Size(670, 570);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Josh\'s Hash Raptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cb_algorithm;
        private System.Windows.Forms.Label lbl_algorithm;
        private System.Windows.Forms.Label lbl_rounds;
        private System.Windows.Forms.ComboBox cb_rounds;
        private System.Windows.Forms.Label lbl_PBKDF2;
        private System.Windows.Forms.ComboBox cb_PBKDF2;
        private System.Windows.Forms.Label lbl_salt;
        private System.Windows.Forms.TextBox txt_salt;
    }
}

