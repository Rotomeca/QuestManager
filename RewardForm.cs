using QuestManager.Enums.Quests.Rewards;
using QuestManager.Managers;
using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestManager
{
    public partial class RewardForm : Form
    {
        private RewardManager _manager;
        public RewardForm()
        {
            InitializeComponent();

            bool hasRewards = UpdateEnabled();

            rewardTypeComboBox.Items.Clear();
            rewardTypeComboBox.Items.AddRange(Enum.GetNames(typeof(RewardType)));

            questComboBox.Items.Clear();
            questComboBox.Items.AddRange(Manager.Instance.QuestManager.Quests.Select(x => x.Name).ToArray());

            {
                var visualiser = new RewardVisualiser(rewardTypeComboBox, questComboBox, amountField, idField, textLabel, customDurability, enableEqpt, enableNewDurability, setCustomDurability, customNewDurabilityMax, durability);
                _manager = new RewardManager(rewardTreeView, visualiser);
            }

            _manager.Visualiser.AfterViewUpdated += (RewardVisualiser visualiser) => {
                UpdateEnabled(null != visualiser.Reward);
            };

            if (hasRewards) _manager.Visualiser.SetReward(Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards.Last());
        }

        private bool UpdateEnabled(bool? state = null)
        {
            bool enabled = state ?? Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards.Count > 0;
            rewardTypeComboBox.Enabled = enabled;
            idField.Enabled = enabled;
            amountField.Enabled = enabled;
            questComboBox.Enabled = enabled;

            if (null == state) removeButton.Enabled = enabled;

            return enabled;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _manager.Add();
            UpdateEnabled();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            _manager.Remove(rewardTreeView.SelectedNode.Index);
        }

        private void rewardTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void rewardTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void customDurability_CheckedChanged(object sender, EventArgs e)
        {
            _manager.Visualiser.Reward.Durability.Active = !_manager.Visualiser.Reward.Durability.Active;
            _manager.Visualiser.UpdateView();
        }

        private void enableEqpt_CheckedChanged(object sender, EventArgs e)
        {
            if (_manager.Visualiser.Reward.Durability.Durabilty > 0) _manager.Visualiser.Reward.Durability.Durabilty = 0;
            else
            {
                _manager.Visualiser.Reward.Durability.Durabilty = (uint)(setCustomDurability.Value == 0 ? 1 : setCustomDurability.Value);
                setCustomDurability.Value = _manager.Visualiser.Reward.Durability.Durabilty;
            }

            _manager.Visualiser.UpdateView();
        }

        private void enableNewDurability_CheckedChanged(object sender, EventArgs e)
        {
            if (_manager.Visualiser.Reward.Durability.UpdateMax > 0) _manager.Visualiser.Reward.Durability.UpdateMax = 0;   
            else
            {
                _manager.Visualiser.Reward.Durability.UpdateMax = (int)(customNewDurabilityMax.Value == 0 ? 1 : customNewDurabilityMax.Value);
                customNewDurabilityMax.Value = _manager.Visualiser.Reward.Durability.UpdateMax;
            }
            _manager.Visualiser.UpdateView();
        }

        private void rewardTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //_manager.SelectNode(e.Node);
        }

        private void amountField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void setCustomDurability_ValueChanged(object sender, EventArgs e)
        {
            _manager.Visualiser.Reward.Durability.Durabilty = (uint)((NumericUpDown)sender).Value;
        }

        private void customNewDurabilityMax_ValueChanged(object sender, EventArgs e)
        {
            _manager.Visualiser.Reward.Durability.UpdateMax = (int)((NumericUpDown)sender).Value;
        }
    }
}
