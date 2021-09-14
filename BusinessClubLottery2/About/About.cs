using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BusinessClubLottery2.About {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private Process OpenUrl(string url) {

            ProcessStartInfo pi = new ProcessStartInfo() {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }

        private void clubweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("http://tacbusinesscl.com");
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("https://github.com/Ess2021/BusinessClubLottery2");
        }
    }
}
