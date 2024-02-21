using QuestManager.Enums.Quests.Rewards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestManager.Models
{
    public class RewardVisualiser
    {
        private ComboBox _rewardType;
        private NumericUpDown _rewardAmount;
        private NumericUpDown _rewardId;
        private ComboBox _questSelected;
        private Label _label;
        private Reward _currentReward;

        public event Action<RewardVisualiser> AfterViewUpdated;

        public Reward Reward => _currentReward;

        public RewardVisualiser(ComboBox rewardType, ComboBox questSelected, NumericUpDown amount, NumericUpDown id, Label label)
        {
            _questSelected = questSelected;
            _rewardAmount = amount;
            _rewardType = rewardType;
            _rewardId = id;
            _label = label;

            _questSelected.TextChanged += (object sender, EventArgs e) =>
            {
                _UpdateGameDataId((sender as ComboBox).SelectedIndex);
            };

            _rewardId.ValueChanged += (object sender, EventArgs e) =>
            {
                _UpdateGameDataId((int)(sender as NumericUpDown).Value);
            };

            _rewardType.TextChanged += (object sender, EventArgs e) =>
            {
                if (null != _currentReward) _currentReward.Type = (RewardType)Enum.Parse(_currentReward.Type.GetType(), (sender as ComboBox).Text);
                UpdateView();
            };

            _rewardAmount.ValueChanged += (object sender, EventArgs e) =>
            {
                if (null != _currentReward) _currentReward.Amount = (int)(sender as NumericUpDown).Value;
            };

        }

        private void _UpdateGameDataId(int index)
        {
            if (null != _currentReward) _currentReward.GameDataId = index;
        }

        public void UpdateView()
        {
            if (Reward != null)
            {
                bool hasAmount = _currentReward.HasAmount();
                bool hasId = _currentReward.HasId();
                _rewardType.Text = _currentReward.Type.ToString();

                _rewardAmount.Visible = hasAmount;
                _rewardId.Visible = hasId;
                _label.Visible = hasId;

                switch (_currentReward.Type)
                {
                    case RewardType.Quest:
                        _questSelected.Visible = true;
                        _label.Visible = false;
                        _rewardId.Visible = false;
                        break;
                    default:
                        _questSelected.Visible = false;
                        break;
                }
            }

            AfterViewUpdated?.Invoke(this);
        }

        public void SetReward(Reward reward)
        {
            _currentReward = reward;
            UpdateView();
        }
    }
}
