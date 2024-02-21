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
                var visualiser = new RewardVisualiser(rewardTypeComboBox, questComboBox, amountField, idField, textLabel);
                _manager = new RewardManager(rewardTreeView, visualiser);
            }

            _manager.Visualiser.AfterViewUpdated += (RewardVisualiser visualiser) => {
                UpdateEnabled(null != visualiser.Reward);
            };

            if (hasRewards) _manager.Visualiser.SetReward(Manager.Instance.QuestManager.Visualiser.CurrentQuest.Rewards[0]);
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
    }
}
