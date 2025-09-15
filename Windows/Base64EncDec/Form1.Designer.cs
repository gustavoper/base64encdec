namespace Base64EncDec
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
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnEncDec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbResult
            // 
            this.rtbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbResult.Location = new System.Drawing.Point(3, 18);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(936, 312);
            this.rtbResult.TabIndex = 0;
            this.rtbResult.Text = "";
            this.rtbResult.TextChanged += new System.EventHandler(this.rtbResult_TextChanged);
            // 
            // rtbData
            // 
            this.rtbData.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbData.Location = new System.Drawing.Point(3, 18);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(936, 288);
            this.rtbData.TabIndex = 1;
            this.rtbData.Text = "";
            this.rtbData.TextChanged += new System.EventHandler(this.rtbData_TextChanged);
            // 
            // btnEncDec
            // 
            this.btnEncDec.Location = new System.Drawing.Point(730, 336);
            this.btnEncDec.Name = "btnEncDec";
            this.btnEncDec.Size = new System.Drawing.Size(200, 43);
            this.btnEncDec.TabIndex = 2;
            this.btnEncDec.Text = "Encode/Decode";
            this.btnEncDec.UseVisualStyleBackColor = true;
            this.btnEncDec.Click += new System.EventHandler(this.btnEncDec_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] { "Encode", "Decode" });
            this.listBox1.Location = new System.Drawing.Point(12, 336);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 52);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rtbResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 333);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.rtbData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 309);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 752);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEncDec);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Encoder - Decoder Base64";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnEncDec;
        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}