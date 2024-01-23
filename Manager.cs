using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager
{
    public class Manager
    {
        public Managers.QuestManager QuestManager => _questManager;
        private Managers.QuestManager _questManager;
        private Manager() {

        }


        public Manager New(Managers.QuestManager questManager)
        {
            _questManager = questManager;

            return this;
        }

        public Manager Load(string json)
        {
            _questManager.Load(json);
            return this;
        }



        private static Manager _instance;
        public static Manager Instance {
            get {
                if ( _instance == null ) _instance = new Manager();

                return _instance;
            } 
        }
    }
}
