using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessClubLottery2 {

    public class Path {

        public string NAMELIST;
        public string CACHE;
        public string HISTORY;
        public string FILE;
        public string BACKUP;
        public string PROPERTIES;

        public Path () {

            this.FILE = @"config";
            this.NAMELIST = @"config/namelist.tbc";
            this.CACHE = @"config/cache.tbc";
            this.HISTORY = @"config/history.tbc";
            this.BACKUP = @"config/backup.txt";
            this.PROPERTIES = @"config/tbc.properties";
        }            
    }
}
