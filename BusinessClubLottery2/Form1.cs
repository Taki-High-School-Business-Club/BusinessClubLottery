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

        private static Path path = new Path();

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
                FileManagement.Overwritetxt(path.NAMELIST, Resources.namelist_default);

            }

            if (!(File.Exists(path.PROPERTIES))) {
                FileManagement.CreateFile(path.PROPERTIES);
                FileManagement.Overwritetxt(path.PROPERTIES, Resources.properties_default);
            }
        }
        

        private void lotbtn_Click(object sender, EventArgs e) {

            int value = 0;

            bool ifCountdown = Properties.ifCountdown();
            bool ifUseCache = Properties.ifUseCache();
            bool ifRandomValue = Properties.ifRandomValue();
            bool ifRandomizer = Properties.ifRandomizer();

            if (ifRandomizer) {

                int[] vs = GetRandomNum(valuebox.Text);
                if (vs.Length == 0) return;

                string[] vs1 = new string[vs.Length];

                for (int i = 0; i <= vs.Length - 1; i++) vs1[i] = vs[i].ToString();

                string text = "";
                for (int i = 0; i <= vs1.Length - 2; i++) {
                    //MessageBox.Show(list[i].ToString());
                    text += vs1[i] + ", ";
                }

                if (ifCountdown) {
                    for (int i = 3; i >= 1; i--) {
                        MessageBox.Show(i.ToString());
                    }
                    MessageBox.Show(".....");
                }

                resultbox.Text = text + vs1[vs1.Length - 1];
                return;
            }

            if (!ifRandomValue) {

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
            }

            if (!(CheckSyntax())) {
                MessageBox.Show("名簿の書式が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReferHistory.EditCache(value);

            //string[] result = new string[] { null };

            string[] result = Lot(value, ifUseCache, ifRandomValue);

            if (ifCountdown) {
                for (int i = 3; i >= 1; i--) {
                    MessageBox.Show(i.ToString());                    
                }
                MessageBox.Show(".....");
            }

            resultbox.Text = ListEvent.ListToStr(result);
            ReferHistory.WriteHistory(result);
        }

        private bool CheckSyntax() {

            //bool containsStart = FileManagement.Readtxt(path.NAMELIST).Contains("start{");
            //bool containsEnd = FileManagement.Readtxt(path.NAMELIST).Contains("}end");

            string[] namelist = ListEvent.ToList2(FileManagement.Readtxt(path.NAMELIST));

            if (namelist[0].Contains("start{") && namelist[namelist.Length - 1].Contains("}end")) {
                return true;
            }

            return false;
        }

        private void settingbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Settings.Settings form = new Settings.Settings();
            form.ShowDialog(this);
            form.Dispose();
        }

        /// <summary>
        /// 
        /// 以下Lot実行関数
        /// setValue - 結果個数指定あり (ifRandomValue)
        /// useHistory - cache書き込みあり (ifUseCache)
        /// 
        /// </summary>
        private static string[] Lot (int value, bool useHistory, bool setValue) {

            string[] result = new string[1];

            if (!setValue) {
                result = new string[value];
            }

            string[] rawresultlist = new string[value];
            string rawresult = "";

            if (useHistory) {

                while (true) {

                    rawresult = ListEvent.ListToStr(ListEvent.RandomizeList(ListEvent.ToList(FileManagement.Readtxt(path.NAMELIST))));

                    rawresultlist = rawresult.Split('\n');

                    if (!setValue) {

                        for (int i = 0; i <= value - 1; i++) {
                            result[i] = rawresultlist[i];
                        }

                    } else {

                        int length = Randomize.Getnum(2, rawresultlist.Length - 2);
                        Array.Resize<string>(ref result, length);

                        for (int i = 0; i <= length - 1; i++) {
                            result[i] = rawresultlist[i];
                        }
                    }

                    if (!(ReferHistory.IsOverlap(result, ListEvent.ToList2(FileManagement.Readtxt(path.CACHE))))) {

                        //for (int j = 0; j <= result.Length - 1; j++) {
                        //    MessageBox.Show(result[j].Replace("\r\n", "\n").Split(new[] { '\n', '\r' })[0] + "あ");
                        //}
                        break;
                    }
                    //MessageBox.Show("草");

                }
            } else {

                rawresult = ListEvent.ListToStr(ListEvent.RandomizeList(ListEvent.ToList(FileManagement.Readtxt(path.NAMELIST))));

                rawresultlist = rawresult.Split('\n');

                if (!setValue) {

                    for (int i = 0; i <= value - 1; i++) {
                        result[i] = rawresultlist[i];
                    }

                } else {

                    int length = Randomize.Getnum(2, rawresultlist.Length - 2);
                    Array.Resize<string>(ref result, length);

                    for (int i = 0; i <= length - 1; i++) {
                        result[i] = rawresultlist[i];
                    }
                }
            }

            ReferHistory.WriteCache(result);
            ReferHistory.WriteHistory(result);
            return result;
        }

        private static int[] GetRandomNum (string input) { //cf Randomize.GetArray
            //syntax: min:max:value

            try {
                string[] values = input.Split(':');

                if (int.Parse(values[1]) - int.Parse(values[0]) < int.Parse(values[2])) {
                    MessageBox.Show($"入力された値が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("以下の書式で入力してください。\n\n{最小値}:{最大値}:{個数}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return new int[] { };
                }

                int[] output = new int[int.Parse(values[2])];
                int i = 0;

                while (true) {

                    if (i >= int.Parse(values[2])) break;

                    int _tmp = Randomize.Getnum(int.Parse(values[0]), int.Parse(values[1]));

                    if (Array.IndexOf<int>(output, _tmp) < 0) {
                        output[i] = _tmp;
                        i++;
                    }
                }

                return output;

            } catch (Exception ex) {

                MessageBox.Show($"入力された値が不正です。\n\nException: {ex}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("以下の書式で入力してください。\n\n{最小値}:{最大値}:{個数}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new int[] { };
            }
        }

        private void showabout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            About.About form = new About.About();
            form.Show();
        }
    }
}
