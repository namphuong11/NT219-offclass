namespace Lab_5_ECDSA_GUI
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnGenKey = new Button();
            btnPublicKey = new Button();
            btnPrivateKey = new Button();
            txbPub = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txbPri = new TextBox();
            label1 = new Label();
            cbFormatKey = new ComboBox();
            tabPage2 = new TabPage();
            btnSign2 = new Button();
            label7 = new Label();
            txbSign2 = new TextBox();
            btnFile2 = new Button();
            label6 = new Label();
            txbFile2 = new TextBox();
            btnSign = new Button();
            btnPri2 = new Button();
            label5 = new Label();
            txbPrivateKey2 = new TextBox();
            tabPage3 = new TabPage();
            btnSign3 = new Button();
            label4 = new Label();
            txbSign3 = new TextBox();
            btnVerify3 = new Button();
            label8 = new Label();
            txbVerify3 = new TextBox();
            btnVerify = new Button();
            btnPub3 = new Button();
            label9 = new Label();
            txbPublicKey3 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(589, 371);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(btnGenKey);
            tabPage1.Controls.Add(btnPublicKey);
            tabPage1.Controls.Add(btnPrivateKey);
            tabPage1.Controls.Add(txbPub);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txbPri);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbFormatKey);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(581, 343);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Key Gen";
            // 
            // btnGenKey
            // 
            btnGenKey.BackColor = Color.Black;
            btnGenKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenKey.ForeColor = Color.White;
            btnGenKey.Location = new Point(36, 267);
            btnGenKey.Margin = new Padding(2, 1, 2, 1);
            btnGenKey.Name = "btnGenKey";
            btnGenKey.Size = new Size(510, 38);
            btnGenKey.TabIndex = 8;
            btnGenKey.Text = "GENKEY";
            btnGenKey.UseVisualStyleBackColor = false;
            btnGenKey.Click += btnGenKey_Click;
            // 
            // btnPublicKey
            // 
            btnPublicKey.BackColor = Color.Black;
            btnPublicKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPublicKey.ForeColor = Color.White;
            btnPublicKey.Location = new Point(449, 195);
            btnPublicKey.Margin = new Padding(2, 1, 2, 1);
            btnPublicKey.Name = "btnPublicKey";
            btnPublicKey.Size = new Size(97, 38);
            btnPublicKey.TabIndex = 7;
            btnPublicKey.Text = "...";
            btnPublicKey.UseVisualStyleBackColor = false;
            btnPublicKey.Click += btnPublicKey_Click;
            // 
            // btnPrivateKey
            // 
            btnPrivateKey.BackColor = Color.Black;
            btnPrivateKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrivateKey.ForeColor = Color.White;
            btnPrivateKey.Location = new Point(449, 118);
            btnPrivateKey.Margin = new Padding(2, 1, 2, 1);
            btnPrivateKey.Name = "btnPrivateKey";
            btnPrivateKey.Size = new Size(97, 40);
            btnPrivateKey.TabIndex = 6;
            btnPrivateKey.Text = "...";
            btnPrivateKey.UseVisualStyleBackColor = false;
            btnPrivateKey.Click += btnPrivateKey_Click;
            // 
            // txbPub
            // 
            txbPub.Location = new Point(36, 195);
            txbPub.Margin = new Padding(2, 1, 2, 1);
            txbPub.Multiline = true;
            txbPub.Name = "txbPub";
            txbPub.Size = new Size(510, 40);
            txbPub.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(36, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 4;
            label3.Text = "Path to save Public Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(36, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 3;
            label2.Text = "Path to save Private Key:";
            // 
            // txbPri
            // 
            txbPri.Location = new Point(36, 118);
            txbPri.Margin = new Padding(2, 1, 2, 1);
            txbPri.Multiline = true;
            txbPri.Name = "txbPri";
            txbPri.Size = new Size(510, 40);
            txbPri.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(36, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Key Format:";
            // 
            // cbFormatKey
            // 
            cbFormatKey.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormatKey.FlatStyle = FlatStyle.Popup;
            cbFormatKey.FormattingEnabled = true;
            cbFormatKey.Items.AddRange(new object[] { "PEM", "DER" });
            cbFormatKey.Location = new Point(114, 31);
            cbFormatKey.Margin = new Padding(2, 1, 2, 1);
            cbFormatKey.Name = "cbFormatKey";
            cbFormatKey.Size = new Size(432, 23);
            cbFormatKey.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(btnSign2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txbSign2);
            tabPage2.Controls.Add(btnFile2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txbFile2);
            tabPage2.Controls.Add(btnSign);
            tabPage2.Controls.Add(btnPri2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txbPrivateKey2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(581, 343);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sign";
            // 
            // btnSign2
            // 
            btnSign2.BackColor = Color.Black;
            btnSign2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSign2.ForeColor = Color.White;
            btnSign2.Location = new Point(431, 213);
            btnSign2.Margin = new Padding(2, 1, 2, 1);
            btnSign2.Name = "btnSign2";
            btnSign2.Size = new Size(97, 40);
            btnSign2.TabIndex = 21;
            btnSign2.Text = "...";
            btnSign2.UseVisualStyleBackColor = false;
            btnSign2.Click += btnSign2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(42, 188);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 20;
            label7.Text = "Path to save Signature:";
            // 
            // txbSign2
            // 
            txbSign2.Location = new Point(42, 213);
            txbSign2.Margin = new Padding(2, 1, 2, 1);
            txbSign2.Multiline = true;
            txbSign2.Name = "txbSign2";
            txbSign2.Size = new Size(486, 40);
            txbSign2.TabIndex = 19;
            // 
            // btnFile2
            // 
            btnFile2.BackColor = Color.Black;
            btnFile2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFile2.ForeColor = Color.White;
            btnFile2.Location = new Point(431, 134);
            btnFile2.Margin = new Padding(2, 1, 2, 1);
            btnFile2.Name = "btnFile2";
            btnFile2.Size = new Size(97, 40);
            btnFile2.TabIndex = 18;
            btnFile2.Text = "...";
            btnFile2.UseVisualStyleBackColor = false;
            btnFile2.Click += btnFile2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(42, 108);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 17;
            label6.Text = "Filename to Sign:";
            // 
            // txbFile2
            // 
            txbFile2.Location = new Point(42, 134);
            txbFile2.Margin = new Padding(2, 1, 2, 1);
            txbFile2.Multiline = true;
            txbFile2.Name = "txbFile2";
            txbFile2.Size = new Size(486, 40);
            txbFile2.TabIndex = 16;
            txbFile2.TextChanged += txbFile2_TextChanged;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.Black;
            btnSign.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSign.ForeColor = Color.White;
            btnSign.Location = new Point(42, 275);
            btnSign.Margin = new Padding(2, 1, 2, 1);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(486, 38);
            btnSign.TabIndex = 15;
            btnSign.Text = "SIGN";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += button1_Click;
            // 
            // btnPri2
            // 
            btnPri2.BackColor = Color.Black;
            btnPri2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPri2.ForeColor = Color.White;
            btnPri2.Location = new Point(431, 54);
            btnPri2.Margin = new Padding(2, 1, 2, 1);
            btnPri2.Name = "btnPri2";
            btnPri2.Size = new Size(97, 40);
            btnPri2.TabIndex = 13;
            btnPri2.Text = "...";
            btnPri2.UseVisualStyleBackColor = false;
            btnPri2.Click += btnPri2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(42, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 10;
            label5.Text = "Path to open Private Key:";
            // 
            // txbPrivateKey2
            // 
            txbPrivateKey2.Location = new Point(42, 54);
            txbPrivateKey2.Margin = new Padding(2, 1, 2, 1);
            txbPrivateKey2.Multiline = true;
            txbPrivateKey2.Name = "txbPrivateKey2";
            txbPrivateKey2.Size = new Size(486, 40);
            txbPrivateKey2.TabIndex = 9;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Silver;
            tabPage3.Controls.Add(btnSign3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txbSign3);
            tabPage3.Controls.Add(btnVerify3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txbVerify3);
            tabPage3.Controls.Add(btnVerify);
            tabPage3.Controls.Add(btnPub3);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(txbPublicKey3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 1, 2, 1);
            tabPage3.Size = new Size(581, 343);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Verify";
            // 
            // btnSign3
            // 
            btnSign3.BackColor = Color.Black;
            btnSign3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSign3.ForeColor = Color.White;
            btnSign3.Location = new Point(436, 214);
            btnSign3.Margin = new Padding(2, 1, 2, 1);
            btnSign3.Name = "btnSign3";
            btnSign3.Size = new Size(97, 40);
            btnSign3.TabIndex = 31;
            btnSign3.Text = "...";
            btnSign3.UseVisualStyleBackColor = false;
            btnSign3.Click += btnSign3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(47, 189);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 15);
            label4.TabIndex = 30;
            label4.Text = "Path to open Signature File:";
            // 
            // txbSign3
            // 
            txbSign3.Location = new Point(47, 214);
            txbSign3.Margin = new Padding(2, 1, 2, 1);
            txbSign3.Multiline = true;
            txbSign3.Name = "txbSign3";
            txbSign3.Size = new Size(486, 40);
            txbSign3.TabIndex = 29;
            // 
            // btnVerify3
            // 
            btnVerify3.BackColor = Color.Black;
            btnVerify3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerify3.ForeColor = Color.White;
            btnVerify3.Location = new Point(436, 135);
            btnVerify3.Margin = new Padding(2, 1, 2, 1);
            btnVerify3.Name = "btnVerify3";
            btnVerify3.Size = new Size(97, 40);
            btnVerify3.TabIndex = 28;
            btnVerify3.Text = "...";
            btnVerify3.UseVisualStyleBackColor = false;
            btnVerify3.Click += btnVerify3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(47, 110);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 27;
            label8.Text = "Filename to Verify:";
            // 
            // txbVerify3
            // 
            txbVerify3.Location = new Point(47, 135);
            txbVerify3.Margin = new Padding(2, 1, 2, 1);
            txbVerify3.Multiline = true;
            txbVerify3.Name = "txbVerify3";
            txbVerify3.Size = new Size(486, 40);
            txbVerify3.TabIndex = 26;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Black;
            btnVerify.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(47, 277);
            btnVerify.Margin = new Padding(2, 1, 2, 1);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(486, 38);
            btnVerify.TabIndex = 25;
            btnVerify.Text = "VERIFY";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnPub3
            // 
            btnPub3.BackColor = Color.Black;
            btnPub3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPub3.ForeColor = Color.White;
            btnPub3.Location = new Point(436, 56);
            btnPub3.Margin = new Padding(2, 1, 2, 1);
            btnPub3.Name = "btnPub3";
            btnPub3.Size = new Size(97, 40);
            btnPub3.TabIndex = 24;
            btnPub3.Text = "...";
            btnPub3.UseVisualStyleBackColor = false;
            btnPub3.Click += btnPub3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(47, 30);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(141, 15);
            label9.TabIndex = 23;
            label9.Text = "Path to open Public Key:";
            // 
            // txbPublicKey3
            // 
            txbPublicKey3.Location = new Point(47, 56);
            txbPublicKey3.Margin = new Padding(2, 1, 2, 1);
            txbPublicKey3.Multiline = true;
            txbPublicKey3.Name = "txbPublicKey3";
            txbPublicKey3.Size = new Size(486, 40);
            txbPublicKey3.TabIndex = 22;
            txbPublicKey3.TextChanged += txbPublicKey3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 380);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnGenKey;
        private Button btnPublicKey;
        private Button btnPrivateKey;
        private TextBox txbPub;
        private Label label3;
        private Label label2;
        private TextBox txbPri;
        private Label label1;
        private ComboBox cbFormatKey;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnSign2;
        private Label label7;
        private TextBox txbSign2;
        private Button btnFile2;
        private Label label6;
        private TextBox txbFile2;
        private Button btnSign;
        private Button btnPri2;
        private Label label5;
        private TextBox txbPrivateKey2;
        private Button btnSign3;
        private Label label4;
        private TextBox txbSign3;
        private Button btnVerify3;
        private Label label8;
        private TextBox txbVerify3;
        private Button btnVerify;
        private Button btnPub3;
        private Label label9;
        private TextBox txbPublicKey3;
    }
}
