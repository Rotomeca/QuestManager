using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rewards = System.Collections.Generic.List<QuestManager.Models.Reward>;

namespace QuestManager.Managers
{
    public class RewardManager
    {
        private RewardVisualiser _visualiser;
        private TreeView _rewardTree;
        private Rewards _Rewards => Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards;

        public RewardVisualiser Visualiser => _visualiser;

        public RewardManager(TreeView view, RewardVisualiser visualiser) { 
            _visualiser = visualiser;
            _rewardTree = view;
        }

        public void Add()
        {
            Add(new Reward());
        }

        public void Add(Reward reward)
        {
            _Rewards.Add(reward);
            _rewardTree.Nodes.Add(reward.ToString());
        }

        public void Remove(int index)
        {
            _Rewards.RemoveAt(index);
            _rewardTree.Nodes.RemoveAt(index);
        }
    }
}
