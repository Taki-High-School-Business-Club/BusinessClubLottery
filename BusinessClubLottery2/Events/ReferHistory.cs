using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BusinessClubLottery2.Events {
    public partial class ReferHistory {

        static Path path = new Path();

        public static bool IsOverlap(string[] list, string[] cache) {

            for (int i = 0; i <= list.Length - 1; i++) {
                if (Array.IndexOf<string>(cache, list[i].Replace("\r\n", "\n").Split(new[] { '\n', '\r' })[0]) >= 0) {
                    return true;
                }
            }
            return false;
        }

        public static void WriteHistory(string[] result) {

            DateTime dt = DateTime.Now;
            string date = dt.ToString();
            FileManagement.Addtxt(path.HISTORY, $"\n\n{date}\n\n");
            FileManagement.Addtxt(path.HISTORY, ListEvent.ListToStr(result));
        }

        public static void WriteCache(string[] result) {

            FileManagement.Addtxt(path.CACHE, ListEvent.ListToStr(result));
        }

        public static void EditCache(int value) {

            string[] history = FileManagement.Readtxt(path.CACHE).Replace("\r\n", "\n").Split(new[] { '\n', '\r' });
            string[] namelist = FileManagement.Readtxt(path.NAMELIST).Replace("\r\n", "\n").Split(new[] { '\n', '\r' });
            //MessageBox.Show(history.Length.ToString());
            //MessageBox.Show(namelist.Length.ToString());
            if ((namelist.Length - 2) - history.Length < value - 1) {
                FileManagement.Overwritetxt(path.CACHE, "");
            }
        }
    }
}
