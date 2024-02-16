using QuestManager.Enums.Quests.Rewards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager.Models
{
    public class Reward
    {
        public RewardType Type { get; set; }
        public int GameDataId { get; set; }
        public int Amount { get; set; }

        public Reward()
        {
            Type = RewardType.Gold;
            GameDataId = 0;
            Amount = 0;
        }
    }
}
