using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessClubLottery2;
using BusinessClubLottery2.Events;

namespace BusinessClubLottery2.Settings {

    public partial class Settings : Form {

        Path path = new Path();

        public Settings() {
            InitializeComponent();           
        }

        private void clearbtn_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("名簿を初期化していいの？", "いいんすか？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.OK) {
                string _tmp = FileManagement.Readtxt(path.NAMELIST).Replace("start{", "").Replace("}end", "");
                FileManagement.Addtxt(path.BACKUP, "\n\n///////////\n\n" + _tmp);
                FileManagement.Overwritetxt(path.NAMELIST, namelist.Text);
                FileManagement.CreateFile(path.NAMELIST);
                MessageBox.Show("名簿を初期化しました！", "おいしかった～");
            }
        }

        private void readbtn_Click(object sender, EventArgs e) {

            namelist.Text = FileManagement.Readtxt(path.NAMELIST);
        }

        private void updatebtn_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("名簿を更新していいの？", "いいんすか？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK) {
                string _tmp = FileManagement.Readtxt(path.NAMELIST).Replace("start{", "").Replace("}end", "");

                FileManagement.Addtxt(path.BACKUP, "\n\n///////////\n\n" + _tmp);

                //if (ListEvent.ToList(namelist.Text)[ListEvent.ToList(namelist.Text).Length - 1] != "") {
                    //namelist.Text += "\n\n";
                //}

                FileManagement.Overwritetxt(path.NAMELIST, namelist.Text);
                MessageBox.Show("名簿を更新しました！", "疲れた～");
            }
        }

        private void namelisthint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("入力例:\n\nstart{\n<一人目>\n<二人目>\n<三人目>\n}end\n\n上記のように、要素間は改行し、start{ }endで囲うようにしてください。","書式", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openfolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("EXPLORER.EXE", path.FILE);
        }

        private void clearhistory_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("履歴を初期化していいの？", "いいんすか？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK) {
                FileManagement.CreateFile(path.HISTORY);
                MessageBox.Show("履歴を初期化しました！", "おいしかった～");
            }
        }

        private void clearcache_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("一時データを初期化していいの？", "いいんすか？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK) {
                FileManagement.CreateFile(path.CACHE);
                MessageBox.Show("一時データを初期化しました！", "おいしかった～");
            }
        }

        private void readhistory_Click(object sender, EventArgs e) {

            cachehistoryBox.Text = FileManagement.Readtxt(path.HISTORY);
        }

        private void readcache_Click(object sender, EventArgs e) {

            cachehistoryBox.Text = FileManagement.Readtxt(path.CACHE);
        }

        private void updatecache_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("一時データを更新していいの？", "いいんすか？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK) {
                FileManagement.Overwritetxt(path.CACHE, cachehistoryBox.Text);
                MessageBox.Show("一時データを更新しました！", "疲れた～");
            }
        }

        private void ifcountdown_CheckedChanged(object sender, EventArgs e) {

            string[] _full = ListEvent.ToList2(FileManagement.Readtxt(path.PROPERTIES));
            _full[1] = ifcountdown.Checked.ToString() + ",";

            string writevalue = ListEvent.ListToStr(_full);
            FileManagement.Overwritetxt(path.PROPERTIES, writevalue);
        }

        private void ifUseCache_CheckedChanged(object sender, EventArgs e) {

            string[] _full = ListEvent.ToList2(FileManagement.Readtxt(path.PROPERTIES));
            _full[3] = ifUseCache.Checked.ToString() + ",";

            string writevalue = ListEvent.ListToStr(_full);
            FileManagement.Overwritetxt(path.PROPERTIES, writevalue);
        }

        private void ifRandomizer_CheckedChanged(object sender, EventArgs e) {

            string[] _full = ListEvent.ToList2(FileManagement.Readtxt(path.PROPERTIES));
            _full[5] = ifRandomizer.Checked.ToString() + ",";

            string writevalue = ListEvent.ListToStr(_full);
            FileManagement.Overwritetxt(path.PROPERTIES, writevalue);
        }

        private void Settings_Load(object sender, EventArgs e) {

            ifcountdown.Checked = Properties.ifCountdown();

            //MessageBox.Show(Properties.ifCountdown().ToString() + "\n" + ifcountdown.Checked.ToString());
            ifUseCache.Checked = Properties.ifUseCache();
            ifRandomizer.Checked = Properties.ifRandomizer();
        }
    }
}