using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessClubLottery2.Events;
using BusinessClubLottery2.Settings;

namespace BusinessClubLottery2 {

    public partial class Form1 : Form {

        public Path path = new Path();

        public Form1() {

            InitializeComponent();

            if (!(File.Exists(path.FILE))) {
                FileManagement.CreateDirectory(path.FILE);
            }

            if (!(File.Exists(path.CACHE))) {
                FileManagement.CreateFile(path.CACHE);
            }

            if (!(File.Exists(path.HISTORY))) {
                FileManagement.CreateFile(path.HISTORY);
            }

            if (!(File.Exists(path.NAMELIST))) {
                FileManagement.CreateFile(path.NAMELIST);
            }
        }

        private void lotbtn_Click(object sender, EventArgs e) {

            int value = 0;

            try {
                value = int.Parse(valuebox.Text);
            } catch (Exception ex) {
                MessageBox.Show($"入力された値が不正です。\n\nException: {ex}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (value <= 0 || ListEvent.ToList(FileManagement.Readtxt(path.NAMELIST)).Length - 2 < value) {
                MessageBox.Show($"入力された値が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReferHistory.EditCache(value);

            string[] result = new string[value];
            string[] rawresultlist = new string[value];
            string rawresult = "";

            while (true) {

                if (FileManagement.Readtxt(path.NAMELIST).Contains("start{") && FileManagement.Readtxt(path.NAMELIST).Contains("}end")) {
                    rawresult = ListEvent.ListToStr(ListEvent.RandomizeList(ListEvent.ToList(FileManagement.Readtxt(path.NAMELIST))));
                } else {
                    MessageBox.Show("名簿の書式が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rawresultlist = rawresult.Split('\n');

                for (int i = 0; i <= value - 1; i++) {
                    result[i] = rawresultlist[i];
                }

                if (!(ReferHistory.IsOverlap(result, ListEvent.ToList2(FileManagement.Readtxt(path.CACHE))))) {
                    break;
                }
                //MessageBox.Show("草");

            }

            resultbox.Text = ListEvent.ListToStr(result);
            ReferHistory.WriteHistory(result);
        }

        private void settingbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Settings.Settings form = new Settings.Settings();
            form.ShowDialog(this);
            form.Dispose();
        }
    }
}
