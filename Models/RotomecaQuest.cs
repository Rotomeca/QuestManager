using Steps = System.Collections.Generic.List<QuestManager.Models.Step>;
using Rewards = System.Collections.Generic.List<QuestManager.Models.Reward>;
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
        public Steps Steps { get; set; }
        public Rewards Rewards { get; set; }

        public RotomecaQuest(int id)
        {
            Id = id;
            Name = string.Empty;
            Description = string.Empty;
            Giver = string.Empty;
            Location = string.Empty;
            Steps = new Steps();
            Rewards = new Rewards();
            QuestType = QuestType.Main;
        }
    }
}
