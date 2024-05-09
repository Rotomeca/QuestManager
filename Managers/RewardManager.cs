using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rewards = System.Collections.Generic.List<QuestManager.Models.Reward>;

namespace QuestManager.Managers
{
    public class RewardManager
    {
        private bool _loaded;
        private RewardVisualiser _visualiser;
        private TreeView _rewardTree;
        private Rewards _Rewards => Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards;

        public RewardVisualiser Visualiser => _visualiser;

        public RewardManager(TreeView view, RewardVisualiser visualiser) { 
            _visualiser = visualiser;
            _rewardTree = view;

            _GenerateTree();


            if (!_loaded)
            {
                _rewardTree.NodeMouseClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                    //int nindex = _tree.Nodes.IndexOf(e.Node);

                    //_visualiser.ChangeStep(_steps[nindex]);
                    SelectNode(e.Node);
                };
                _loaded = true;
            }
        }

        public void Add()
        {
            Add(new Reward());
        }

        public void Add(Reward reward)
        {
            _Rewards.Add(reward);
            SelectNode(_rewardTree.Nodes.Add(_NodeName(_Rewards.Count, reward.ToString())));
        }

        public void Remove(int index)
        {
            _Rewards.RemoveAt(index);
            _rewardTree.Nodes.RemoveAt(index);
        }

        private void _GenerateTree()
        {
            if (_Rewards.Count > 0)
            {
                foreach (var reward in _Rewards)
                {
                    _rewardTree.Nodes.Add(_NodeName(_Rewards.IndexOf(reward), reward.ToString()));
                }

                SelectNode(_rewardTree.Nodes[_rewardTree.Nodes.Count - 1]);
            }
        }

        private string _NodeName(int index, string reward)
        {
            return $"{index} : {reward}";
        }

        public void SelectNode(TreeNode node)
        {
            int currentIndex = _Rewards.IndexOf(_visualiser.Reward);

            if (currentIndex >= 0)
            {
                _rewardTree.Nodes[currentIndex].BackColor = Color.White;
                _rewardTree.Nodes[currentIndex].ForeColor = Color.Black;
            }

            int nodeIndex = _rewardTree.Nodes.IndexOf(node);
            _visualiser.SetReward(_Rewards[nodeIndex]);
            _rewardTree.Nodes[nodeIndex].BackColor = Color.Blue;
            _rewardTree.Nodes[nodeIndex].ForeColor = Color.White;
            _rewardTree.SelectedNode = node;
        }
    }
}
