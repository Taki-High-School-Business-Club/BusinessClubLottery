
namespace BusinessClubLottery2.Settings {
    partial class Settings {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namelist = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.namelisthint = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namelisthint);
            this.groupBox1.Controls.Add(this.namelist);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.readbtn);
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "名簿の編集";
            // 
            // namelist
            // 
            this.namelist.Location = new System.Drawing.Point(6, 104);
            this.namelist.Multiline = true;
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(248, 186);
            this.namelist.TabIndex = 1;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(6, 296);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(248, 35);
            this.updatebtn.TabIndex = 0;
            this.updatebtn.Text = "名簿の更新";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(6, 63);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(248, 35);
            this.readbtn.TabIndex = 0;
            this.readbtn.Text = "名簿の読み込み";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(6, 22);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(248, 35);
            this.clearbtn.TabIndex = 0;
            this.clearbtn.Text = "名簿の初期化";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // namelisthint
            // 
            this.namelisthint.AutoSize = true;
            this.namelisthint.Location = new System.Drawing.Point(7, 336);
            this.namelisthint.Name = "namelisthint";
            this.namelisthint.Size = new System.Drawing.Size(31, 15);
            this.namelisthint.TabIndex = 2;
            this.namelisthint.TabStop = true;
            this.namelisthint.Text = "書式";
            this.namelisthint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.namelisthint_LinkClicked);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox namelist;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.LinkLabel namelisthint;
    }
}