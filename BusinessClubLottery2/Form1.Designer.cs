
namespace BusinessClubLottery2
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
            this.lotbtn = new System.Windows.Forms.Button();
            this.valuebox = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingbtn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lotbtn
            // 
            this.lotbtn.Location = new System.Drawing.Point(12, 12);
            this.lotbtn.Name = "lotbtn";
            this.lotbtn.Size = new System.Drawing.Size(260, 50);
            this.lotbtn.TabIndex = 0;
            this.lotbtn.Text = "抽選";
            this.lotbtn.UseVisualStyleBackColor = true;
            this.lotbtn.Click += new System.EventHandler(this.lotbtn_Click);
            // 
            // valuebox
            // 
            this.valuebox.Location = new System.Drawing.Point(13, 68);
            this.valuebox.Name = "valuebox";
            this.valuebox.Size = new System.Drawing.Size(259, 23);
            this.valuebox.TabIndex = 1;
            this.valuebox.Text = "人数を入力してください";
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(13, 116);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(259, 133);
            this.resultbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "結果";
            // 
            // settingbtn
            // 
            this.settingbtn.AutoSize = true;
            this.settingbtn.Location = new System.Drawing.Point(13, 252);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(31, 15);
            this.settingbtn.TabIndex = 4;
            this.settingbtn.TabStop = true;
            this.settingbtn.Text = "設定";
            this.settingbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingbtn_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.settingbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.valuebox);
            this.Controls.Add(this.lotbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lotbtn;
        private System.Windows.Forms.TextBox valuebox;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel settingbtn;
    }
}

