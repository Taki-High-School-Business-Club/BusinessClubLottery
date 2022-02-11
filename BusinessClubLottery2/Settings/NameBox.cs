using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using BusinessClubLottery2;
using BusinessClubLottery2.Events;

namespace BusinessClubLottery2.Settings {
    public partial class NameBox : Form {
        private static Path path = new Path();
        public string[] selected;
        public NameBox() {
            InitializeComponent();

            string rawnames = FileManagement.Readtxt(path.NAMELIST);
            string[] names = ListEvent.ToList2(rawnames).Where(val =>
                !val.Contains("start{") && !val.Contains("}end")
                ).ToArray();
            foreach (string name in names) {
                NameListBox.Items.Add(name);
            }

            if (File.Exists(path.ABSENT)) {
                try {
                    string[] absents = FileManagement.Readtxt(path.ABSENT).Split();
                    string[] checkedBoxValues = new string[0];
                    foreach (string items in NameListBox.Items) {
                        Array.Resize<string>(ref checkedBoxValues, checkedBoxValues.Length + 1);
                        checkedBoxValues[checkedBoxValues.Length - 1] = items;
                    }
                    foreach (string val in absents) {
                        int index = Array.IndexOf(checkedBoxValues, val);
                        if (index >= 0) {
                            NameListBox.SetItemChecked(index, true);
                        }
                    }
                } catch {
                    /*ここ何書けばいいんだよ*/
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e) {
            string[] submitted = new string[0];
            foreach (string checkedItems in NameListBox.CheckedItems) {
                Array.Resize<string>(ref submitted, submitted.Length + 1);
                submitted[submitted.Length - 1] = checkedItems;
            }

            this.selected = submitted;
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e) {
            this.selected = null;
            this.Close();
        }
    }
}
