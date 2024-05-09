using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestManager.Models
{
    public class QuestVisualiser
    {
        private TextBox _name;
        private RichTextBox _description;
        private TextBox _giver;
        private TextBox _localization;
        private CheckBox _isMainQuest;
        private TreeView _stepsView;
        private TreeView _rewardsView;
        private RotomecaQuest _currentQuest;
        public RotomecaQuest CurrentQuest => _currentQuest;
        public QuestVisualiser(TextBox name, RichTextBox description, TextBox giver, TextBox localization, CheckBox isMainQuest, TreeView stepsView, TreeView rewardsView)
        {
            _name = name;
            _description = description;
            _giver = giver;
            _localization = localization;
            _isMainQuest = isMainQuest;
            _stepsView = stepsView;
            _rewardsView = rewardsView;
        }

        public void ChangeQuest(RotomecaQuest quest)
        {
            _currentQuest = quest;
            _Update();
        }

        private void _Update()
        {
            _name.Text = _currentQuest.Name;
            _description.Text = _currentQuest.Description;
            _giver.Text = _currentQuest.Giver;
            _localization.Text = _currentQuest.Location;
            _isMainQuest.Checked = _currentQuest.QuestType == Enums.Quests.QuestType.Main;
            Update();
        }

        private void _UpdateTree(ref TreeView tree, List<string> nodes)
        {
            tree.Nodes.Clear();

            for (int i = 0, len = nodes.Count; i < len; ++i)
            {
                tree.Nodes.Add($"{i + 1} : {nodes[i]}");
            }
        }

        public void Update()
        {
            _UpdateTree(ref _stepsView, CurrentQuest.Steps.Select(x => x.ToString()).ToList());
            _UpdateTree(ref _rewardsView, CurrentQuest.Rewards.Select(x => x.ToString()).ToList());
        }
    }
}
