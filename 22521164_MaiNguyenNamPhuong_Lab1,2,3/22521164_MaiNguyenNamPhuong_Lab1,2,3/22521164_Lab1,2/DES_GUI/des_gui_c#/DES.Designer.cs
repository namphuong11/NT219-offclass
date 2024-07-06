namespace des_gui_c_
{
    partial class DES
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
            components = new System.ComponentModel.Container();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            rtbPlain = new RichTextBox();
            label2 = new Label();
            btnInputCipher = new Button();
            rtbCipher = new RichTextBox();
            label1 = new Label();
            btnInputPlaintext = new Button();
            btnMode = new Button();
            btnGenKey = new Button();
            cbCPtextFormat = new ComboBox();
            cbPlaintextFormat = new ComboBox();
            txbCipher = new TextBox();
            txbPlain = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnDec = new Button();
            btnEnc = new Button();
            richTextBox1 = new RichTextBox();
            cbRCVtextFormat = new ComboBox();
            txbRcv = new TextBox();
            btnReadRcv = new Button();
            btnReadCipher = new Button();
            btnReadPlain = new Button();
            txbPri = new TextBox();
            cbFormat = new ComboBox();
            btnRead = new Button();
            cbMode = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(907, 305);
            label6.Name = "label6";
            label6.Size = new Size(180, 32);
            label6.TabIndex = 96;
            label6.Text = "RcvText Format:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(907, 236);
            label5.Name = "label5";
            label5.Size = new Size(211, 32);
            label5.TabIndex = 95;
            label5.Text = "Ciphertext Format:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(907, 166);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 94;
            label4.Text = "Plaintext Format:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(907, 99);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 93;
            label3.Text = "Key Format:";
            // 
            // rtbPlain
            // 
            rtbPlain.BorderStyle = BorderStyle.None;
            rtbPlain.Location = new Point(956, 410);
            rtbPlain.Name = "rtbPlain";
            rtbPlain.Size = new Size(400, 115);
            rtbPlain.TabIndex = 92;
            rtbPlain.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 605);
            label2.Name = "label2";
            label2.Size = new Size(46, 32);
            label2.TabIndex = 91;
            label2.Text = "OR";
            // 
            // btnInputCipher
            // 
            btnInputCipher.BackColor = Color.SteelBlue;
            btnInputCipher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInputCipher.ForeColor = Color.White;
            btnInputCipher.Location = new Point(798, 564);
            btnInputCipher.Name = "btnInputCipher";
            btnInputCipher.Size = new Size(141, 115);
            btnInputCipher.TabIndex = 90;
            btnInputCipher.Text = "Input Ciphertext";
            btnInputCipher.UseVisualStyleBackColor = false;
            btnInputCipher.Click += btnInputCipher_Click;
            // 
            // rtbCipher
            // 
            rtbCipher.BorderStyle = BorderStyle.None;
            rtbCipher.Location = new Point(956, 564);
            rtbCipher.Name = "rtbCipher";
            rtbCipher.Size = new Size(400, 115);
            rtbCipher.TabIndex = 89;
            rtbCipher.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(712, 451);
            label1.Name = "label1";
            label1.Size = new Size(46, 32);
            label1.TabIndex = 88;
            label1.Text = "OR";
            // 
            // btnInputPlaintext
            // 
            btnInputPlaintext.BackColor = Color.SteelBlue;
            btnInputPlaintext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInputPlaintext.ForeColor = Color.White;
            btnInputPlaintext.Location = new Point(798, 410);
            btnInputPlaintext.Name = "btnInputPlaintext";
            btnInputPlaintext.Size = new Size(141, 115);
            btnInputPlaintext.TabIndex = 87;
            btnInputPlaintext.Text = "Input Plaintext";
            btnInputPlaintext.UseVisualStyleBackColor = false;
            btnInputPlaintext.Click += btnInputPlaintext_Click;
            // 
            // btnMode
            // 
            btnMode.BackColor = Color.SteelBlue;
            btnMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMode.ForeColor = Color.White;
            btnMode.Location = new Point(125, 143);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(200, 46);
            btnMode.TabIndex = 85;
            btnMode.Text = "Mode";
            btnMode.UseVisualStyleBackColor = false;
            // 
            // btnGenKey
            // 
            btnGenKey.BackColor = Color.ForestGreen;
            btnGenKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenKey.ForeColor = Color.White;
            btnGenKey.Location = new Point(798, 716);
            btnGenKey.Name = "btnGenKey";
            btnGenKey.Size = new Size(184, 115);
            btnGenKey.TabIndex = 83;
            btnGenKey.Text = "Genkey";
            btnGenKey.UseVisualStyleBackColor = false;
            btnGenKey.Click += btnGenKey_Click;
            // 
            // cbCPtextFormat
            // 
            cbCPtextFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCPtextFormat.FlatStyle = FlatStyle.Flat;
            cbCPtextFormat.FormattingEnabled = true;
            cbCPtextFormat.Items.AddRange(new object[] { "DER", "Base64", "HEX" });
            cbCPtextFormat.Location = new Point(1129, 233);
            cbCPtextFormat.Name = "cbCPtextFormat";
            cbCPtextFormat.Size = new Size(227, 40);
            cbCPtextFormat.TabIndex = 78;
            // 
            // cbPlaintextFormat
            // 
            cbPlaintextFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlaintextFormat.FlatStyle = FlatStyle.Flat;
            cbPlaintextFormat.FormattingEnabled = true;
            cbPlaintextFormat.Items.AddRange(new object[] { "Text", "DER", "Base64", "HEX" });
            cbPlaintextFormat.Location = new Point(1129, 166);
            cbPlaintextFormat.Name = "cbPlaintextFormat";
            cbPlaintextFormat.Size = new Size(227, 40);
            cbPlaintextFormat.TabIndex = 77;
            // 
            // txbCipher
            // 
            txbCipher.BackColor = Color.White;
            txbCipher.Location = new Point(289, 568);
            txbCipher.Multiline = true;
            txbCipher.Name = "txbCipher";
            txbCipher.ReadOnly = true;
            txbCipher.Size = new Size(395, 111);
            txbCipher.TabIndex = 75;
            // 
            // txbPlain
            // 
            txbPlain.BackColor = Color.White;
            txbPlain.Location = new Point(289, 415);
            txbPlain.Multiline = true;
            txbPlain.Name = "txbPlain";
            txbPlain.ReadOnly = true;
            txbPlain.Size = new Size(395, 110);
            txbPlain.TabIndex = 74;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnDec
            // 
            btnDec.BackColor = Color.ForestGreen;
            btnDec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDec.ForeColor = Color.White;
            btnDec.Location = new Point(1182, 720);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(174, 111);
            btnDec.TabIndex = 82;
            btnDec.Text = "Decrypt";
            btnDec.UseVisualStyleBackColor = false;
            btnDec.Click += btnDec_Click;
            // 
            // btnEnc
            // 
            btnEnc.BackColor = Color.ForestGreen;
            btnEnc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnc.ForeColor = Color.White;
            btnEnc.Location = new Point(988, 720);
            btnEnc.Name = "btnEnc";
            btnEnc.Size = new Size(188, 111);
            btnEnc.TabIndex = 81;
            btnEnc.Text = "Encrypt";
            btnEnc.UseVisualStyleBackColor = false;
            btnEnc.Click += btnEnc_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(83, 866);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1318, 342);
            richTextBox1.TabIndex = 80;
            richTextBox1.Text = "";
            // 
            // cbRCVtextFormat
            // 
            cbRCVtextFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRCVtextFormat.FlatStyle = FlatStyle.Flat;
            cbRCVtextFormat.FormattingEnabled = true;
            cbRCVtextFormat.Items.AddRange(new object[] { "Text", "Base64", "PEM" });
            cbRCVtextFormat.Location = new Point(1129, 297);
            cbRCVtextFormat.Name = "cbRCVtextFormat";
            cbRCVtextFormat.Size = new Size(227, 40);
            cbRCVtextFormat.TabIndex = 79;
            // 
            // txbRcv
            // 
            txbRcv.BackColor = Color.White;
            txbRcv.Location = new Point(289, 720);
            txbRcv.Multiline = true;
            txbRcv.Name = "txbRcv";
            txbRcv.ReadOnly = true;
            txbRcv.Size = new Size(395, 111);
            txbRcv.TabIndex = 76;
            // 
            // btnReadRcv
            // 
            btnReadRcv.BackColor = Color.SteelBlue;
            btnReadRcv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadRcv.ForeColor = Color.White;
            btnReadRcv.Location = new Point(124, 720);
            btnReadRcv.Name = "btnReadRcv";
            btnReadRcv.Size = new Size(135, 111);
            btnReadRcv.TabIndex = 73;
            btnReadRcv.Text = "Recover File";
            btnReadRcv.UseVisualStyleBackColor = false;
            btnReadRcv.Click += btnReadRcv_Click;
            // 
            // btnReadCipher
            // 
            btnReadCipher.BackColor = Color.SteelBlue;
            btnReadCipher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadCipher.ForeColor = Color.White;
            btnReadCipher.Location = new Point(124, 571);
            btnReadCipher.Name = "btnReadCipher";
            btnReadCipher.Size = new Size(141, 115);
            btnReadCipher.TabIndex = 72;
            btnReadCipher.Text = "Ciphertext File";
            btnReadCipher.UseVisualStyleBackColor = false;
            btnReadCipher.Click += btnReadCipher_Click;
            // 
            // btnReadPlain
            // 
            btnReadPlain.BackColor = Color.SteelBlue;
            btnReadPlain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadPlain.ForeColor = Color.White;
            btnReadPlain.Location = new Point(124, 415);
            btnReadPlain.Name = "btnReadPlain";
            btnReadPlain.Size = new Size(141, 110);
            btnReadPlain.TabIndex = 71;
            btnReadPlain.Text = "Plaintext File";
            btnReadPlain.UseVisualStyleBackColor = false;
            btnReadPlain.Click += btnReadPlain_Click;
            // 
            // txbPri
            // 
            txbPri.BackColor = Color.White;
            txbPri.Location = new Point(340, 200);
            txbPri.Multiline = true;
            txbPri.Name = "txbPri";
            txbPri.ReadOnly = true;
            txbPri.Size = new Size(428, 96);
            txbPri.TabIndex = 70;
            // 
            // cbFormat
            // 
            cbFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormat.FlatStyle = FlatStyle.Flat;
            cbFormat.FormattingEnabled = true;
            cbFormat.Items.AddRange(new object[] { "DER", "Base64", "HEX" });
            cbFormat.Location = new Point(1129, 96);
            cbFormat.Name = "cbFormat";
            cbFormat.Size = new Size(227, 40);
            cbFormat.TabIndex = 69;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.SteelBlue;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(125, 200);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(200, 96);
            btnRead.TabIndex = 68;
            btnRead.Text = "Key File";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // cbMode
            // 
            cbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMode.FlatStyle = FlatStyle.Flat;
            cbMode.FormattingEnabled = true;
            cbMode.Items.AddRange(new object[] { "ECB", "CBC", "CFB", "OFB", "CTR" });
            cbMode.Location = new Point(340, 143);
            cbMode.Name = "cbMode";
            cbMode.Size = new Size(428, 40);
            cbMode.TabIndex = 97;
            // 
            // DES
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 1305);
            Controls.Add(cbMode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rtbPlain);
            Controls.Add(label2);
            Controls.Add(btnInputCipher);
            Controls.Add(rtbCipher);
            Controls.Add(label1);
            Controls.Add(btnInputPlaintext);
            Controls.Add(btnMode);
            Controls.Add(btnGenKey);
            Controls.Add(cbCPtextFormat);
            Controls.Add(cbPlaintextFormat);
            Controls.Add(txbCipher);
            Controls.Add(txbPlain);
            Controls.Add(btnDec);
            Controls.Add(btnEnc);
            Controls.Add(richTextBox1);
            Controls.Add(cbRCVtextFormat);
            Controls.Add(txbRcv);
            Controls.Add(btnReadRcv);
            Controls.Add(btnReadCipher);
            Controls.Add(btnReadPlain);
            Controls.Add(txbPri);
            Controls.Add(cbFormat);
            Controls.Add(btnRead);
            Name = "DES";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DES Encyption";
            Load += DES_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox rtbPlain;
        private Label label2;
        private Button btnInputCipher;
        private RichTextBox rtbCipher;
        private Label label1;
        private Button btnInputPlaintext;
        private Button btnMode;
        private Button btnGenKey;
        private ComboBox cbCPtextFormat;
        private ComboBox cbPlaintextFormat;
        private TextBox txbCipher;
        private TextBox txbPlain;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnDec;
        private Button btnEnc;
        private RichTextBox richTextBox1;
        private ComboBox cbRCVtextFormat;
        private TextBox txbRcv;
        private Button btnReadRcv;
        private Button btnReadCipher;
        private Button btnReadPlain;
        private TextBox txbPri;
        private ComboBox cbFormat;
        private Button btnRead;
        private ComboBox cbMode;
    }
}
