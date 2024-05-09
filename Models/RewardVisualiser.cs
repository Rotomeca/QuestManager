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
        private CheckBox _enableDurabilityModifier;
        private CheckBox _enableCustomDurability;
        private CheckBox _enableNewMaxDurability;
        private NumericUpDown _newDurability;
        private NumericUpDown _maxDurability;
        private Reward _currentReward;
        private GroupBox _durabilityBox;

        public event Action<RewardVisualiser> AfterViewUpdated;

        public Reward Reward => _currentReward;

        public RewardVisualiser(ComboBox rewardType, ComboBox questSelected, NumericUpDown amount, NumericUpDown id, Label label, CheckBox enableDurabilityModifier, CheckBox enableCustomDurability, CheckBox enableNewMaxDurability, NumericUpDown newDurability, NumericUpDown maxDurability, GroupBox durabilityBox)
        {
            _questSelected = questSelected;
            _rewardAmount = amount;
            _rewardType = rewardType;
            _rewardId = id;
            _label = label;
            _enableDurabilityModifier = enableDurabilityModifier;
            _enableCustomDurability = enableCustomDurability;
            _enableNewMaxDurability = enableNewMaxDurability;
            _newDurability = newDurability;
            _maxDurability = maxDurability;
            _durabilityBox = durabilityBox;

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

                _enableDurabilityModifier.Visible = false;
                _enableCustomDurability.Visible = false;
                _enableNewMaxDurability.Visible = false;
                _newDurability.Visible = false;
                _maxDurability.Visible = false;
                _durabilityBox.Visible = false;

                _questSelected.Visible = false;

                switch (_currentReward.Type)
                {
                    case RewardType.Weapon: 
                    case RewardType.Armor:
                        _durabilityBox.Visible = true;
                        _enableCustomDurability.Visible = true;
                        _enableDurabilityModifier.Visible = true;
                        _enableNewMaxDurability.Visible = true;
                        _newDurability.Visible = true;
                        _maxDurability.Visible = true;

                        _enableDurabilityModifier.Enabled = true;
                        _enableCustomDurability.Enabled = _enableDurabilityModifier.Checked;
                        _enableNewMaxDurability.Enabled = _enableDurabilityModifier.Checked;

                        _enableDurabilityModifier.Checked = _currentReward.Durability.Active;
                        _enableCustomDurability.Checked = _currentReward.Durability.Durabilty > 0;
                        _enableNewMaxDurability.Checked = _currentReward.Durability.UpdateMax > 0;

                        _newDurability.Enabled = _enableDurabilityModifier.Checked && _enableCustomDurability.Checked;
                        _maxDurability.Enabled = _enableDurabilityModifier.Checked && _enableNewMaxDurability.Checked;
                        break;

                    case RewardType.Quest:
                        _questSelected.Visible = true;
                        _label.Visible = false;
                        _rewardId.Visible = false;
                        break;
                    default:
                        break;
                }
            }

            AfterViewUpdated?.Invoke(this);
        }

        public void UpdateViewData()
        {
            if (_currentReward != null)
            {
                _rewardType.SelectedValue = _currentReward.Type.ToString();
                _rewardId.Value = _currentReward.GameDataId;
                _rewardAmount.Value = _currentReward.Amount;
                
                switch (_currentReward.Type)
                {
                    case RewardType.Quest:
                        _questSelected.SelectedIndex = _currentReward.GameDataId;
                        break;

                    case RewardType.Weapon:
                    case RewardType.Armor:
                        _newDurability.Value = _currentReward.Durability.Durabilty;
                        _maxDurability.Value = _currentReward.Durability.UpdateMax;
                        break;
                }
            }
        }

        public void SetReward(Reward reward)
        {
            _currentReward = reward;
            UpdateViewData();
            UpdateView();
        }
    }
}
