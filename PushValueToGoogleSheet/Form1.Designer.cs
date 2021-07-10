
namespace PushValueToGoogleSheet
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
            this.browserBtn = new System.Windows.Forms.Button();
            this.pushToGoogleBtn = new System.Windows.Forms.Button();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.sheetIdTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTabTxt = new System.Windows.Forms.TextBox();
            this.getGoogleSheetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameSaveTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // browserBtn
            // 
            this.browserBtn.Location = new System.Drawing.Point(492, 55);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(75, 23);
            this.browserBtn.TabIndex = 0;
            this.browserBtn.Text = "Browser";
            this.browserBtn.UseVisualStyleBackColor = true;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // pushToGoogleBtn
            // 
            this.pushToGoogleBtn.Location = new System.Drawing.Point(135, 261);
            this.pushToGoogleBtn.Name = "pushToGoogleBtn";
            this.pushToGoogleBtn.Size = new System.Drawing.Size(87, 45);
            this.pushToGoogleBtn.TabIndex = 1;
            this.pushToGoogleBtn.Text = "Push";
            this.pushToGoogleBtn.UseVisualStyleBackColor = true;
            this.pushToGoogleBtn.Click += new System.EventHandler(this.pushToGoogleBtn_Click);
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(121, 56);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(338, 22);
            this.filePathTxt.TabIndex = 2;
            // 
            // sheetIdTxt
            // 
            this.sheetIdTxt.Location = new System.Drawing.Point(121, 105);
            this.sheetIdTxt.Name = "sheetIdTxt";
            this.sheetIdTxt.Size = new System.Drawing.Size(338, 22);
            this.sheetIdTxt.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(80, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 15);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "  sharkilybk-249@spotify-1615884083054.iam.gserviceaccount.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "File text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sheet id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name tab";
            // 
            // nameTabTxt
            // 
            this.nameTabTxt.Location = new System.Drawing.Point(121, 155);
            this.nameTabTxt.Name = "nameTabTxt";
            this.nameTabTxt.Size = new System.Drawing.Size(338, 22);
            this.nameTabTxt.TabIndex = 7;
            // 
            // getGoogleSheetBtn
            // 
            this.getGoogleSheetBtn.Location = new System.Drawing.Point(344, 261);
            this.getGoogleSheetBtn.Name = "getGoogleSheetBtn";
            this.getGoogleSheetBtn.Size = new System.Drawing.Size(87, 45);
            this.getGoogleSheetBtn.TabIndex = 9;
            this.getGoogleSheetBtn.Text = "Get";
            this.getGoogleSheetBtn.UseVisualStyleBackColor = true;
            this.getGoogleSheetBtn.Click += new System.EventHandler(this.getGoogleSheetBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Folder save";
            // 
            // fileNameSaveTxt
            // 
            this.fileNameSaveTxt.Location = new System.Drawing.Point(121, 206);
            this.fileNameSaveTxt.Name = "fileNameSaveTxt";
            this.fileNameSaveTxt.Size = new System.Drawing.Size(338, 22);
            this.fileNameSaveTxt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Browser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameSaveTxt);
            this.Controls.Add(this.getGoogleSheetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTabTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sheetIdTxt);
            this.Controls.Add(this.filePathTxt);
            this.Controls.Add(this.pushToGoogleBtn);
            this.Controls.Add(this.browserBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browserBtn;
        private System.Windows.Forms.Button pushToGoogleBtn;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.TextBox sheetIdTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTabTxt;
        private System.Windows.Forms.Button getGoogleSheetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameSaveTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

