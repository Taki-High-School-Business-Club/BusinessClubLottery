
namespace BusinessClubLottery2.About {
    partial class About {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clubweb = new System.Windows.Forms.LinkLabel();
            this.github = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "ビジネス部抽選アプリ v1.0.0 (β)\r\n(2021.09.15)\r\n\r\n制作 - 滝高校ビジネス部アーカイブ班";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusinessClubLottery2.Resources.icon_archive_3;
            this.pictureBox1.Location = new System.Drawing.Point(124, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BusinessClubLottery2.Resources.icon_background;
            this.pictureBox2.Location = new System.Drawing.Point(37, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // clubweb
            // 
            this.clubweb.AutoSize = true;
            this.clubweb.Location = new System.Drawing.Point(12, 156);
            this.clubweb.Name = "clubweb";
            this.clubweb.Size = new System.Drawing.Size(143, 15);
            this.clubweb.TabIndex = 2;
            this.clubweb.TabStop = true;
            this.clubweb.Text = "https://tacbusinesscl.com";
            this.clubweb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clubweb_LinkClicked);
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Location = new System.Drawing.Point(12, 171);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(213, 30);
            this.github.TabIndex = 2;
            this.github.TabStop = true;
            this.github.Text = "https://github.com/Ess2021/BusinessCl\r\nubLottery2";
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 221);
            this.Controls.Add(this.github);
            this.Controls.Add(this.clubweb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 260);
            this.Name = "About";
            this.Text = "このアプリについて";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel clubweb;
        private System.Windows.Forms.LinkLabel github;
    }
}