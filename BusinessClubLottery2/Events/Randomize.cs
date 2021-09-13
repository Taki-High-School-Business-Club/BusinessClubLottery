using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BusinessClubLottery2.Events {
    public partial class Randomize {

        public static int Getnum (int min, int max) {

            Random p = new Random();
            return p.Next(min, max + 1);
        }

        public static int[] GetArray (int min, int max) {
            
            /*
            if (max > min || max - min < value) {
                MessageBox.Show("エラーが発生しました。\n入力された値が不正です。");
                return null;
            }
            */
            
            int[] output = new int[max];
            int i = 0;

            while (true) {

                if (i >= max) break;

                int _tmp = Getnum(min, max);

                if (Array.IndexOf<int>(output, _tmp) < 0) {
                    output[i] = _tmp;
                    i++;
                }
            }

            //MessageBox.Show(output.Length.ToString());
            return output;

        }

    }
}
