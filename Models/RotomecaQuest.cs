using System.Collections.Generic;

using Step = QuestManager.Models.Step;
using Reward = QuestManager.Classes.UnknownObject;
using QuestManager.Enums.Quests;

namespace QuestManager.Models
{
    public class RotomecaQuest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Giver { get; set; }
        public string Location { get; set; }
        public QuestType QuestType { get; set; }
        public List<Step> Steps { get; set; }
        public List<Reward> Rewards { get; set; }

        public RotomecaQuest(int id)
        {
            Id = id;
            Name = string.Empty;
            Description = string.Empty;
            Giver = string.Empty;
            Location = string.Empty;
            Steps = new List<Step>();
            Rewards = new List<Reward>();
            QuestType = QuestType.Main;
        }
    }
}
