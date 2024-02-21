using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestManager.Managers
{
    public class RewardManager
    {
        private RewardVisualiser _visualiser;
        private TreeView _rewardTree;

        public RewardVisualiser Visualiser => _visualiser;

        public RewardManager(TreeView view, RewardVisualiser visualiser) { 
            _visualiser = visualiser;
            _rewardTree = view;
        }

        public void Add()
        {
            Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards.Add(new Reward());
            _rewardTree.Nodes.Add(Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards.Last().ToString());
            _visualiser.SetReward(Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards.Last());
        }
    }
}
