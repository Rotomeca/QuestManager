using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Parameters = QuestManager.Settings;

namespace QuestManager
{
    public class AppManager
    { 
        private class Data
        {
            public Parameters Settings { get; set; }
            public List<RotomecaQuest> Quests { get; set; }

            public Data()
            {
            }

            public static Data Generate()
            {
                Data data = new Data();
                data.Settings = Parameters.Instance;
                data.Quests = Manager.Instance.QuestManager.Quests;

                return data;
            }
        }

        public static string GetSave()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(Data.Generate());
        }

        public static void Load(string jsonFile)
        {
            var loaded = Newtonsoft.Json.JsonConvert.DeserializeObject<Data>(jsonFile);

            Manager.Instance.Load(Newtonsoft.Json.JsonConvert.SerializeObject(loaded.Quests));

            Parameters.Instance.NameInsteadOfDesc = loaded.Settings.NameInsteadOfDesc;
        }
    }
}
