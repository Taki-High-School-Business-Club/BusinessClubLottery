
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
            this.namelisthint = new System.Windows.Forms.LinkLabel();
            this.namelist = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updatecache = new System.Windows.Forms.Button();
            this.cachehistoryBox = new System.Windows.Forms.TextBox();
            this.readcache = new System.Windows.Forms.Button();
            this.clearcache = new System.Windows.Forms.Button();
            this.readhistory = new System.Windows.Forms.Button();
            this.clearhistory = new System.Windows.Forms.Button();
            this.ifcountdown = new System.Windows.Forms.CheckBox();
            this.ifUseCache = new System.Windows.Forms.CheckBox();
            this.ifRandomizer = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.openfolder = new System.Windows.Forms.LinkLabel();
            this.absentbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // namelist
            // 
            this.namelist.Location = new System.Drawing.Point(6, 104);
            this.namelist.Multiline = true;
            this.namelist.Name = "namelist";
            this.namelist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updatecache);
            this.groupBox2.Controls.Add(this.cachehistoryBox);
            this.groupBox2.Controls.Add(this.readcache);
            this.groupBox2.Controls.Add(this.clearcache);
            this.groupBox2.Controls.Add(this.readhistory);
            this.groupBox2.Controls.Add(this.clearhistory);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "データの編集";
            // 
            // updatecache
            // 
            this.updatecache.Location = new System.Drawing.Point(7, 296);
            this.updatecache.Name = "updatecache";
            this.updatecache.Size = new System.Drawing.Size(247, 35);
            this.updatecache.TabIndex = 5;
            this.updatecache.Text = "一時データの更新";
            this.updatecache.UseVisualStyleBackColor = true;
            this.updatecache.Click += new System.EventHandler(this.updatecache_Click);
            // 
            // cachehistoryBox
            // 
            this.cachehistoryBox.Location = new System.Drawing.Point(7, 104);
            this.cachehistoryBox.Multiline = true;
            this.cachehistoryBox.Name = "cachehistoryBox";
            this.cachehistoryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cachehistoryBox.Size = new System.Drawing.Size(247, 186);
            this.cachehistoryBox.TabIndex = 4;
            // 
            // readcache
            // 
            this.readcache.Location = new System.Drawing.Point(133, 63);
            this.readcache.Name = "readcache";
            this.readcache.Size = new System.Drawing.Size(121, 35);
            this.readcache.TabIndex = 3;
            this.readcache.Text = "一時データの読み込み";
            this.readcache.UseVisualStyleBackColor = true;
            this.readcache.Click += new System.EventHandler(this.readcache_Click);
            // 
            // clearcache
            // 
            this.clearcache.Location = new System.Drawing.Point(6, 63);
            this.clearcache.Name = "clearcache";
            this.clearcache.Size = new System.Drawing.Size(121, 35);
            this.clearcache.TabIndex = 2;
            this.clearcache.Text = "一時データの初期化";
            this.clearcache.UseVisualStyleBackColor = true;
            this.clearcache.Click += new System.EventHandler(this.clearcache_Click);
            // 
            // readhistory
            // 
            this.readhistory.Location = new System.Drawing.Point(133, 23);
            this.readhistory.Name = "readhistory";
            this.readhistory.Size = new System.Drawing.Size(121, 35);
            this.readhistory.TabIndex = 1;
            this.readhistory.Text = "履歴の読み込み";
            this.readhistory.UseVisualStyleBackColor = true;
            this.readhistory.Click += new System.EventHandler(this.readhistory_Click);
            // 
            // clearhistory
            // 
            this.clearhistory.Location = new System.Drawing.Point(6, 24);
            this.clearhistory.Name = "clearhistory";
            this.clearhistory.Size = new System.Drawing.Size(121, 34);
            this.clearhistory.TabIndex = 0;
            this.clearhistory.Text = "履歴の初期化";
            this.clearhistory.UseVisualStyleBackColor = true;
            this.clearhistory.Click += new System.EventHandler(this.clearhistory_Click);
            // 
            // ifcountdown
            // 
            this.ifcountdown.AutoSize = true;
            this.ifcountdown.Location = new System.Drawing.Point(545, 34);
            this.ifcountdown.Name = "ifcountdown";
            this.ifcountdown.Size = new System.Drawing.Size(88, 19);
            this.ifcountdown.TabIndex = 2;
            this.ifcountdown.Text = "カウントダウン";
            this.ifcountdown.UseVisualStyleBackColor = true;
            this.ifcountdown.CheckedChanged += new System.EventHandler(this.ifcountdown_CheckedChanged);
            // 
            // ifUseCache
            // 
            this.ifUseCache.AutoSize = true;
            this.ifUseCache.Location = new System.Drawing.Point(545, 60);
            this.ifUseCache.Name = "ifUseCache";
            this.ifUseCache.Size = new System.Drawing.Size(96, 19);
            this.ifUseCache.TabIndex = 3;
            this.ifUseCache.Text = "全要素の周回";
            this.ifUseCache.UseVisualStyleBackColor = true;
            this.ifUseCache.CheckedChanged += new System.EventHandler(this.ifUseCache_CheckedChanged);
            // 
            // ifRandomizer
            // 
            this.ifRandomizer.AutoSize = true;
            this.ifRandomizer.Location = new System.Drawing.Point(545, 86);
            this.ifRandomizer.Name = "ifRandomizer";
            this.ifRandomizer.Size = new System.Drawing.Size(86, 19);
            this.ifRandomizer.TabIndex = 4;
            this.ifRandomizer.Text = "乱数生成器";
            this.ifRandomizer.UseVisualStyleBackColor = true;
            this.ifRandomizer.CheckedChanged += new System.EventHandler(this.ifRandomizer_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(545, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 19);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "人数ランダム（試験的）";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // openfolder
            // 
            this.openfolder.AutoSize = true;
            this.openfolder.Location = new System.Drawing.Point(554, 357);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(118, 15);
            this.openfolder.TabIndex = 6;
            this.openfolder.TabStop = true;
            this.openfolder.Text = "設定格納フォルダを開く";
            this.openfolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openfolder_LinkClicked);
            // 
            // absentbtn
            // 
            this.absentbtn.Location = new System.Drawing.Point(554, 308);
            this.absentbtn.Name = "absentbtn";
            this.absentbtn.Size = new System.Drawing.Size(118, 35);
            this.absentbtn.TabIndex = 7;
            this.absentbtn.Text = "欠席者設定";
            this.absentbtn.UseVisualStyleBackColor = true;
            this.absentbtn.Click += new System.EventHandler(this.absentbtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.absentbtn);
            this.Controls.Add(this.openfolder);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ifRandomizer);
            this.Controls.Add(this.ifUseCache);
            this.Controls.Add(this.ifcountdown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 420);
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "Settings";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox namelist;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.LinkLabel namelisthint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updatecache;
        private System.Windows.Forms.TextBox cachehistoryBox;
        private System.Windows.Forms.Button readcache;
        private System.Windows.Forms.Button clearcache;
        private System.Windows.Forms.Button readhistory;
        private System.Windows.Forms.Button clearhistory;
        private System.Windows.Forms.LinkLabel openfolder;
        public System.Windows.Forms.CheckBox ifcountdown;
        public System.Windows.Forms.CheckBox ifUseCache;
        public System.Windows.Forms.CheckBox ifRandomizer;
        public System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button absentbtn;
    }
}