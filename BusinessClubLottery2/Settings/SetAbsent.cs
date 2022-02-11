using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using BusinessClubLottery2.Events;
using System.Windows.Forms;

namespace BusinessClubLottery2.Settings {
    class SetAbsent {
        private static Path path = new Path();

        public string[] names;
        public string[] absents;

        public SetAbsent() {
            if (File.Exists(path.ABSENT)) {
                this.absents = FileManagement.Readtxt(path.ABSENT).Split();
            } else {
                this.absents = new string[] { };
            }
        }
        
        public bool IsAbsent() {
            foreach(string val in absents) {
                if (names.Where(c => c == val).ToArray().Length > 0) return true;
                //MessageBox.Show(Array.IndexOf<string>(names, val).ToString() + " " + names[0]);
            }
            return false;
        }
    }
}
