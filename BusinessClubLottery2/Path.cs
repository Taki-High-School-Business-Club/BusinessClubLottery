using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessClubLottery2 {

    public class Path {

        public readonly string NAMELIST;
        public readonly string CACHE;
        public readonly string HISTORY;
        public readonly string FILE;
        public readonly string BACKUP;
        public readonly string PROPERTIES;
        public readonly string ABSENT;

        public Path () {
            this.FILE = @"config";
            this.NAMELIST = @"config/namelist.tbc";
            this.CACHE = @"config/cache.tbc";
            this.HISTORY = @"config/history.tbc";
            this.BACKUP = @"config/backup.txt";
            this.PROPERTIES = @"config/tbc.properties";
            this.ABSENT = @"config/absent.tbc";
        }            
    }
}
