using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BusinessClubLottery2.Events {

    public partial class FileManagement {

        public static string Readtxt (string path) {

            string output = "";

            try {
                var ListPath = File.ReadAllText(path);
                output = ListPath;

            } catch {
                output = null;
            }
            return output;
        }

        public static void Addtxt (string path, string text) {

            string filePath = path;
            Encoding enc = Encoding.GetEncoding("utf-16");

            System.IO.File.AppendAllText(filePath, text, enc);
        }

        public static void Overwritetxt (string path, string text) {

            string filePath = path;
            Encoding enc = Encoding.GetEncoding("utf-16");

            System.IO.File.WriteAllText(filePath, text, enc);
        }

        public static void CreateFile (string path) {

            StreamWriter sw = File.CreateText(path);
            sw.Close();
        }

        public static void CreateDirectory (string path) {

            Directory.CreateDirectory(path);
        }
    }
}
