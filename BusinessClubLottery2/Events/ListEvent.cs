using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BusinessClubLottery2.Events {
    public partial class ListEvent {

        public static string[] ToList (string names) {

            return names.Split('\n');
        }

        public static string[] ToList2 (string names) {

            return names.Replace("\r\n", "\n").Split(new[] { '\n', '\r' });
        }

        public static string[] RandomizeList (string[] list) {

            string[] output = new string[list.Length];
            int[] randomlist = Randomize.GetArray(0, list.Length - 1);

            for (int i = 0; i <= list.Length - 2; i++) {
                output[i] = list[randomlist[i]];

                /*
                if (output[i].Contains("}end")) {
                    output[i] = output[i].Replace("}end", "");
                }

                if (output[i].Contains("start{")) {
                    output[i] = output[i].Replace("start{", "");
                }
                */
            }

            return output;
        }

        public static string ListToStr (string[] list) {

            list = list.Where(val => val != "}end").ToArray();
            //MessageBox.Show(list.Length.ToString());

            string output = "";

            for (int i = 0; i <= list.Length - 2; i++) {
                //MessageBox.Show(list[i].ToString());
                output += list[i] + "\n";
            }

            return output + list[list.Length - 1];
        }
    }
}
