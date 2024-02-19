using QuestManager.Enums.Quests.Rewards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager.Enums.Quests.Rewards
{
    public enum RewardType
    {
        Variable,
        Switch,
        Gold,
        Item,
        Armor,
        Weapon,
        Quest
    }

    public static class RewardTypeExt
    {
        public static bool HasId(this RewardType type)
        {
            switch (type)
            {
                case RewardType.Gold: return false;
                default: return true;
            }
        }
    }
}

namespace QuestManager
{
    public static class RewardTypeExt2
    {

        public static bool HasId(this Models.Reward reward)
        {
            return reward.Type.HasId();
        }
    }
}

