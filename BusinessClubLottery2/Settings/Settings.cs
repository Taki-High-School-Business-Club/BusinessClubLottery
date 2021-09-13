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
            MessageBox.Show("入力例:\n\nstart{\n<一人目>\n<二人目>\n<三人目>\n}end\n\n上記のように、要素間は改行し、start{ }endで囲うようにしてください。","書式");
        }
    }
}
