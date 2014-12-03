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
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(12, 250);
            this.txt_result.MaxLength = 128;
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(537, 105);
            this.txt_result.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(12, 229);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(51, 18);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "Result";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(12, 13);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(40, 18);
            this.lbl_input.TabIndex = 3;
            this.lbl_input.Text = "Input";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(12, 34);
            this.txt_input.MaxLength = 128;
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(537, 105);
            this.txt_input.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(245, 373);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(91, 35);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Hash";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_algorithm
            // 
            this.cb_algorithm.FormattingEnabled = true;
            this.cb_algorithm.Items.AddRange(new object[] {
            "SHA-512",
            "SHA-384",
            "SHA-256",
            "SHA-1"});
            this.cb_algorithm.Location = new System.Drawing.Point(12, 185);
            this.cb_algorithm.Name = "cb_algorithm";
            this.cb_algorithm.Size = new System.Drawing.Size(121, 21);
            this.cb_algorithm.TabIndex = 4;
            // 
            // lbl_algorithm
            // 
            this.lbl_algorithm.AutoSize = true;
            this.lbl_algorithm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_algorithm.Location = new System.Drawing.Point(12, 164);
            this.lbl_algorithm.Name = "lbl_algorithm";
            this.lbl_algorithm.Size = new System.Drawing.Size(74, 18);
            this.lbl_algorithm.TabIndex = 5;
            this.lbl_algorithm.Text = "Algorithm";
            this.lbl_algorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 422);
            this.Controls.Add(this.lbl_algorithm);
            this.Controls.Add(this.cb_algorithm);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_result);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 460);
            this.MinimumSize = new System.Drawing.Size(577, 460);
            this.Name = "Form1";
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
    }
}

