using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager
{
    public class Settings
    {
        private static Settings _instance;
        public static Settings Instance
        {
            get
            {
                if ( null == _instance) _instance = new Settings();

                return _instance;
            }
        }

        public bool NameInsteadOfDesc { get; set; }

        private Settings()
        {
            NameInsteadOfDesc = true;
        }
    }
}
