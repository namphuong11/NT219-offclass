namespace Lab_4_2_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheck = new Button();
            btnOpenOutput = new Button();
            btnOpenCA = new Button();
            txbOutput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txbCA = new TextBox();
            cbFormat = new ComboBox();
            btnOpenImm = new Button();
            label4 = new Label();
            txbImm = new TextBox();
            btnOpenWebsiteCert = new Button();
            label5 = new Label();
            txbWebCert = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.LightSalmon;
            btnCheck.Font = new Font("Microsoft Sans Serif", 9F);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(503, 366);
            btnCheck.Margin = new Padding(2, 1, 2, 1);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(361, 33);
            btnCheck.TabIndex = 19;
            btnCheck.Text = "Check Cert";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnOpenOutput
            // 
            btnOpenOutput.BackColor = Color.Black;
            btnOpenOutput.Font = new Font("Microsoft Sans Serif", 9F);
            btnOpenOutput.ForeColor = Color.White;
            btnOpenOutput.Location = new Point(783, 310);
            btnOpenOutput.Margin = new Padding(2, 1, 2, 1);
            btnOpenOutput.Name = "btnOpenOutput";
            btnOpenOutput.Size = new Size(82, 35);
            btnOpenOutput.TabIndex = 18;
            btnOpenOutput.Text = "...";
            btnOpenOutput.UseVisualStyleBackColor = false;
            btnOpenOutput.Click += btnOpenOutput_Click;
            // 
            // btnOpenCA
            // 
            btnOpenCA.BackColor = Color.Black;
            btnOpenCA.Font = new Font("Microsoft Sans Serif", 9F);
            btnOpenCA.ForeColor = Color.White;
            btnOpenCA.Location = new Point(782, 92);
            btnOpenCA.Margin = new Padding(2, 1, 2, 1);
            btnOpenCA.Name = "btnOpenCA";
            btnOpenCA.Size = new Size(82, 35);
            btnOpenCA.TabIndex = 17;
            btnOpenCA.Text = "...";
            btnOpenCA.UseVisualStyleBackColor = false;
            btnOpenCA.Click += btnOpenCA_Click;
            // 
            // txbOutput
            // 
            txbOutput.Font = new Font("Microsoft Sans Serif", 9F);
            txbOutput.Location = new Point(503, 310);
            txbOutput.Margin = new Padding(2, 1, 2, 1);
            txbOutput.Multiline = true;
            txbOutput.Name = "txbOutput";
            txbOutput.Size = new Size(361, 35);
            txbOutput.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(503, 294);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 15;
            label3.Text = "Path to save Output:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(502, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 14;
            label2.Text = "Path to open RootCA Cert:";
            // 
            // txbCA
            // 
            txbCA.Font = new Font("Microsoft Sans Serif", 9F);
            txbCA.Location = new Point(502, 92);
            txbCA.Margin = new Padding(2, 1, 2, 1);
            txbCA.Multiline = true;
            txbCA.Name = "txbCA";
            txbCA.Size = new Size(362, 35);
            txbCA.TabIndex = 13;
            // 
            // cbFormat
            // 
            cbFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormat.FlatStyle = FlatStyle.Flat;
            cbFormat.Font = new Font("Microsoft Sans Serif", 9F);
            cbFormat.FormattingEnabled = true;
            cbFormat.Items.AddRange(new object[] { "PEM", "DER" });
            cbFormat.Location = new Point(502, 30);
            cbFormat.Margin = new Padding(2, 1, 2, 1);
            cbFormat.Name = "cbFormat";
            cbFormat.Size = new Size(362, 23);
            cbFormat.TabIndex = 50;
            // 
            // btnOpenImm
            // 
            btnOpenImm.BackColor = Color.Black;
            btnOpenImm.Font = new Font("Microsoft Sans Serif", 9F);
            btnOpenImm.ForeColor = Color.White;
            btnOpenImm.Location = new Point(782, 163);
            btnOpenImm.Margin = new Padding(2, 1, 2, 1);
            btnOpenImm.Name = "btnOpenImm";
            btnOpenImm.Size = new Size(82, 35);
            btnOpenImm.TabIndex = 22;
            btnOpenImm.Text = "...";
            btnOpenImm.UseVisualStyleBackColor = false;
            btnOpenImm.Click += btnOpenImm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(502, 147);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 15);
            label4.TabIndex = 21;
            label4.Text = "Path to open Intermediate Cert:";
            // 
            // txbImm
            // 
            txbImm.Font = new Font("Microsoft Sans Serif", 9F);
            txbImm.Location = new Point(502, 163);
            txbImm.Margin = new Padding(2, 1, 2, 1);
            txbImm.Multiline = true;
            txbImm.Name = "txbImm";
            txbImm.Size = new Size(362, 35);
            txbImm.TabIndex = 20;
            // 
            // btnOpenWebsiteCert
            // 
            btnOpenWebsiteCert.BackColor = Color.Black;
            btnOpenWebsiteCert.Font = new Font("Microsoft Sans Serif", 9F);
            btnOpenWebsiteCert.ForeColor = Color.White;
            btnOpenWebsiteCert.Location = new Point(782, 234);
            btnOpenWebsiteCert.Margin = new Padding(2, 1, 2, 1);
            btnOpenWebsiteCert.Name = "btnOpenWebsiteCert";
            btnOpenWebsiteCert.Size = new Size(82, 35);
            btnOpenWebsiteCert.TabIndex = 25;
            btnOpenWebsiteCert.Text = "...";
            btnOpenWebsiteCert.UseVisualStyleBackColor = false;
            btnOpenWebsiteCert.Click += btnOpenWebsiteCert_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(503, 218);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 24;
            label5.Text = "Path to open Website Cert:";
            // 
            // txbWebCert
            // 
            txbWebCert.Font = new Font("Microsoft Sans Serif", 9F);
            txbWebCert.Location = new Point(502, 234);
            txbWebCert.Margin = new Padding(2, 1, 2, 1);
            txbWebCert.Multiline = true;
            txbWebCert.Name = "txbWebCert";
            txbWebCert.Size = new Size(362, 35);
            txbWebCert.TabIndex = 23;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 9F);
            richTextBox1.Location = new Point(11, 10);
            richTextBox1.Margin = new Padding(2, 1, 2, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(467, 419);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(880, 439);
            Controls.Add(richTextBox1);
            Controls.Add(btnOpenWebsiteCert);
            Controls.Add(label5);
            Controls.Add(txbWebCert);
            Controls.Add(btnOpenImm);
            Controls.Add(label4);
            Controls.Add(txbImm);
            Controls.Add(btnCheck);
            Controls.Add(btnOpenOutput);
            Controls.Add(btnOpenCA);
            Controls.Add(txbOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbCA);
            Controls.Add(cbFormat);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private Button btnOpenOutput;
        private Button btnOpenCA;
        private TextBox txbOutput;
        private Label label3;
        private Label label2;
        private TextBox txbCA;
        private ComboBox cbFormat;
        private Button btnOpenImm;
        private Label label4;
        private TextBox txbImm;
        private Button btnOpenWebsiteCert;
        private Label label5;
        private TextBox txbWebCert;
        private RichTextBox richTextBox1;
    }
}
