using System;
using System.Collections.Generic;
using System.Text;
using BusinessClubLottery2.Events;

namespace BusinessClubLottery2.Settings {
    public partial class Properties {

        static Path path = new Path();

        //public bool ifCountdown;
        //public bool ifUseCache;
        //public bool ifRandomizer;

        private static string[] properties() {

            string propertiesFile = FileManagement.Readtxt(path.PROPERTIES);
            return ListEvent.ToList2(propertiesFile);
        }

        private static bool TorF (string value) {

            if (value.Contains("True")) return true;
            else return false;
        }

        public static bool ifCountdown () {

            string value = properties()[1];
            return TorF(value);
        }

        public static bool ifUseCache() {

            string value = properties()[3];
            return TorF(value);
        }

        public static bool ifRandomizer() {

            string value = properties()[5];
            return TorF(value);
        }

        public static bool TurnValue (bool value) {

            if (value) return false;
            else return true;
        }
    }
}
