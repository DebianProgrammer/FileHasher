namespace FileHasher
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SHA512text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Copy512 = new System.Windows.Forms.Button();
            this.Copy256 = new System.Windows.Forms.Button();
            this.Copy1 = new System.Windows.Forms.Button();
            this.Copy5 = new System.Windows.Forms.Button();
            this.Copy384 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SHA256text = new System.Windows.Forms.TextBox();
            this.SHA1text = new System.Windows.Forms.TextBox();
            this.MD5text = new System.Windows.Forms.TextBox();
            this.SHA384text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CompareMD5 = new System.Windows.Forms.Button();
            this.CompareSHA1 = new System.Windows.Forms.Button();
            this.CompareSHA256 = new System.Windows.Forms.Button();
            this.CompareSHA512 = new System.Windows.Forms.Button();
            this.ComparePaste = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CompareSHA384 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Open a file to view its hash";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SHA512text
            // 
            this.SHA512text.Location = new System.Drawing.Point(228, 377);
            this.SHA512text.Name = "SHA512text";
            this.SHA512text.ReadOnly = true;
            this.SHA512text.Size = new System.Drawing.Size(979, 22);
            this.SHA512text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SHA512 Hash:";
            // 
            // Copy512
            // 
            this.Copy512.Location = new System.Drawing.Point(1228, 377);
            this.Copy512.Name = "Copy512";
            this.Copy512.Size = new System.Drawing.Size(109, 28);
            this.Copy512.TabIndex = 2;
            this.Copy512.Text = "Copy";
            this.Copy512.UseVisualStyleBackColor = true;
            this.Copy512.Click += new System.EventHandler(this.Copy512_Click);
            // 
            // Copy256
            // 
            this.Copy256.Location = new System.Drawing.Point(1228, 303);
            this.Copy256.Name = "Copy256";
            this.Copy256.Size = new System.Drawing.Size(109, 30);
            this.Copy256.TabIndex = 3;
            this.Copy256.Text = "Copy";
            this.Copy256.UseVisualStyleBackColor = true;
            this.Copy256.Click += new System.EventHandler(this.Copy256_Click);
            // 
            // Copy1
            // 
            this.Copy1.Location = new System.Drawing.Point(1228, 268);
            this.Copy1.Name = "Copy1";
            this.Copy1.Size = new System.Drawing.Size(109, 30);
            this.Copy1.TabIndex = 4;
            this.Copy1.Text = "Copy";
            this.Copy1.UseVisualStyleBackColor = true;
            this.Copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // Copy5
            // 
            this.Copy5.Location = new System.Drawing.Point(1228, 227);
            this.Copy5.Name = "Copy5";
            this.Copy5.Size = new System.Drawing.Size(109, 27);
            this.Copy5.TabIndex = 5;
            this.Copy5.Text = "Copy";
            this.Copy5.UseVisualStyleBackColor = true;
            this.Copy5.Click += new System.EventHandler(this.Copy5_Click);
            // 
            // Copy384
            // 
            this.Copy384.Location = new System.Drawing.Point(1228, 342);
            this.Copy384.Name = "Copy384";
            this.Copy384.Size = new System.Drawing.Size(109, 29);
            this.Copy384.TabIndex = 6;
            this.Copy384.Text = "Copy";
            this.Copy384.UseVisualStyleBackColor = true;
            this.Copy384.Click += new System.EventHandler(this.Copy384_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "SHA256 Hash:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SHA1 Hash:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "MD5 Hash:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "SHA384 Hash:";
            // 
            // SHA256text
            // 
            this.SHA256text.Location = new System.Drawing.Point(228, 311);
            this.SHA256text.Name = "SHA256text";
            this.SHA256text.ReadOnly = true;
            this.SHA256text.Size = new System.Drawing.Size(979, 22);
            this.SHA256text.TabIndex = 11;
            // 
            // SHA1text
            // 
            this.SHA1text.Location = new System.Drawing.Point(228, 272);
            this.SHA1text.Name = "SHA1text";
            this.SHA1text.ReadOnly = true;
            this.SHA1text.Size = new System.Drawing.Size(979, 22);
            this.SHA1text.TabIndex = 12;
            this.SHA1text.TextChanged += new System.EventHandler(this.SHA1text_TextChanged);
            // 
            // MD5text
            // 
            this.MD5text.Location = new System.Drawing.Point(228, 233);
            this.MD5text.Name = "MD5text";
            this.MD5text.ReadOnly = true;
            this.MD5text.Size = new System.Drawing.Size(979, 22);
            this.MD5text.TabIndex = 13;
            // 
            // SHA384text
            // 
            this.SHA384text.Location = new System.Drawing.Point(228, 342);
            this.SHA384text.Name = "SHA384text";
            this.SHA384text.ReadOnly = true;
            this.SHA384text.Size = new System.Drawing.Size(979, 22);
            this.SHA384text.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(688, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "FileHasher - Get the file hash to verify files!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1213, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(979, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "File Opened:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(228, 548);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(979, 27);
            this.textBox2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 38);
            this.label8.TabIndex = 20;
            this.label8.Text = "Compare hashes!";
            // 
            // CompareMD5
            // 
            this.CompareMD5.Location = new System.Drawing.Point(207, 599);
            this.CompareMD5.Name = "CompareMD5";
            this.CompareMD5.Size = new System.Drawing.Size(167, 31);
            this.CompareMD5.TabIndex = 21;
            this.CompareMD5.Text = "Compare with MD5";
            this.CompareMD5.UseVisualStyleBackColor = true;
            this.CompareMD5.Click += new System.EventHandler(this.CompareMD5_Click);
            // 
            // CompareSHA1
            // 
            this.CompareSHA1.Location = new System.Drawing.Point(395, 600);
            this.CompareSHA1.Name = "CompareSHA1";
            this.CompareSHA1.Size = new System.Drawing.Size(167, 31);
            this.CompareSHA1.TabIndex = 22;
            this.CompareSHA1.Text = "Compare with SHA1";
            this.CompareSHA1.UseVisualStyleBackColor = true;
            this.CompareSHA1.Click += new System.EventHandler(this.CompareSHA1_Click);
            // 
            // CompareSHA256
            // 
            this.CompareSHA256.Location = new System.Drawing.Point(580, 599);
            this.CompareSHA256.Name = "CompareSHA256";
            this.CompareSHA256.Size = new System.Drawing.Size(167, 32);
            this.CompareSHA256.TabIndex = 23;
            this.CompareSHA256.Text = "Compare with SHA256";
            this.CompareSHA256.UseVisualStyleBackColor = true;
            this.CompareSHA256.Click += new System.EventHandler(this.CompareSHA256_Click);
            // 
            // CompareSHA512
            // 
            this.CompareSHA512.Location = new System.Drawing.Point(960, 598);
            this.CompareSHA512.Name = "CompareSHA512";
            this.CompareSHA512.Size = new System.Drawing.Size(167, 32);
            this.CompareSHA512.TabIndex = 24;
            this.CompareSHA512.Text = "Compare with SHA512";
            this.CompareSHA512.UseVisualStyleBackColor = true;
            this.CompareSHA512.Click += new System.EventHandler(this.CompareSHA512_Click);
            // 
            // ComparePaste
            // 
            this.ComparePaste.Location = new System.Drawing.Point(661, 505);
            this.ComparePaste.Name = "ComparePaste";
            this.ComparePaste.Size = new System.Drawing.Size(165, 37);
            this.ComparePaste.TabIndex = 25;
            this.ComparePaste.Text = "Paste";
            this.ComparePaste.UseVisualStyleBackColor = true;
            this.ComparePaste.Click += new System.EventHandler(this.ComparePaste_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(559, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Note: the area below is to compare a hash another website gave you to check your " +
    "files";
            // 
            // CompareSHA384
            // 
            this.CompareSHA384.Location = new System.Drawing.Point(768, 599);
            this.CompareSHA384.Name = "CompareSHA384";
            this.CompareSHA384.Size = new System.Drawing.Size(174, 30);
            this.CompareSHA384.TabIndex = 27;
            this.CompareSHA384.Text = "Compare with SHA384";
            this.CompareSHA384.UseVisualStyleBackColor = true;
            this.CompareSHA384.Click += new System.EventHandler(this.CompareSHA384_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 668);
            this.Controls.Add(this.CompareSHA384);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComparePaste);
            this.Controls.Add(this.CompareSHA512);
            this.Controls.Add(this.CompareSHA256);
            this.Controls.Add(this.CompareSHA1);
            this.Controls.Add(this.CompareMD5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SHA384text);
            this.Controls.Add(this.MD5text);
            this.Controls.Add(this.SHA1text);
            this.Controls.Add(this.SHA256text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Copy384);
            this.Controls.Add(this.Copy5);
            this.Controls.Add(this.Copy1);
            this.Controls.Add(this.Copy256);
            this.Controls.Add(this.Copy512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHA512text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SHA512text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Copy512;
        private System.Windows.Forms.Button Copy256;
        private System.Windows.Forms.Button Copy1;
        private System.Windows.Forms.Button Copy5;
        private System.Windows.Forms.Button Copy384;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SHA256text;
        private System.Windows.Forms.TextBox SHA1text;
        private System.Windows.Forms.TextBox MD5text;
        private System.Windows.Forms.TextBox SHA384text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CompareMD5;
        private System.Windows.Forms.Button CompareSHA1;
        private System.Windows.Forms.Button CompareSHA256;
        private System.Windows.Forms.Button CompareSHA512;
        private System.Windows.Forms.Button ComparePaste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CompareSHA384;
    }
}

