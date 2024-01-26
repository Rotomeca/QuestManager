using QuestManager.Enums.Quests.Steps;
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
    public partial class StepForm : Form
    {
        private StepManager _manager;
        public StepForm()
        {
            InitializeComponent();
        }

        private void StepForm_Load(object sender, EventArgs e)
        {
            steptype.Items.Clear();

            foreach (var item in Enum.GetNames(typeof(QuestStepType)))
            {
                steptype.Items.Add(item);
            }

            var initialiser = StepVisualiser.Initialiser.Start()
                .InitType(steptype)
                .InitSwitchState(switchState)
                .InitAmount(amountLabel, amount, unitLabel)
                .InitDescription(desc_label, long_desc, short_desc)
                .InitIsVisible(isVisible)
                .InitNextSteps(nextSteps, listBox1)
                .InitGameDataId(gameDataIdLabel, gameDataId);

            _manager = new StepManager(allSteps, initialiser);
            _manager.Visualiser.UpdateNextSteps();
            _SetNextStupButtonStyle(listBox1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addStepButton_Click(object sender, EventArgs e)
        {
            _manager.Add();
            _manager.Visualiser.UpdateNextSteps();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _manager.RemoveCurrent();
            _manager.Visualiser.UpdateNextSteps();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void steptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newType = (QuestStepType)Enum.Parse(typeof(QuestStepType), (sender as ComboBox).SelectedItem.ToString());
            if (_manager?.Visualiser?.CurrentStep != null && newType != _manager.Visualiser.CurrentStep.Type)
            {
                _manager.Visualiser.CurrentStep.Type = newType;
                _manager.UpdateName().Visualiser.UpdateStep();
            }
        }

        private void gameDataId_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)Math.Round((sender as NumericUpDown).Value);
            if (_manager?.Visualiser.CurrentStep != null && id != _manager.Visualiser.CurrentStep.GameDataId)
            {
                _manager.Visualiser.CurrentStep.GameDataId = (uint)id;
                _manager.UpdateName().Visualiser.UpdateStep();
            }
        }

        private void amount_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)Math.Round((sender as NumericUpDown).Value);
            if (_manager?.Visualiser.CurrentStep != null && value != _manager.Visualiser.CurrentStep.Amount)
            {
                _manager.Visualiser.CurrentStep.Amount = value;
                _manager.UpdateName().Visualiser.UpdateStep();
            }
        }

        private void isVisible_CheckedChanged(object sender, EventArgs e)
        {
            bool value = !(sender as CheckBox).Checked;
            if (_manager?.Visualiser.CurrentStep != null && value != _manager.Visualiser.CurrentStep.IsHidden)
            {
                _manager.Visualiser.CurrentStep.IsHidden = value;
                _manager.UpdateName().Visualiser.UpdateStep();
            }
        }

        private void short_desc_TextChanged(object sender, EventArgs e)
        {
            string value = (sender as TextBox).Text;
            if (_manager?.Visualiser.CurrentStep != null && value != _manager.Visualiser.CurrentStep.Description)
            {
                _manager.Visualiser.CurrentStep.Description = value;
                _manager.UpdateName().Visualiser.UpdateStep();
            }
        }

        private void long_desc_TextChanged(object sender, EventArgs e)
        {
            RichTextBox desc = sender as RichTextBox;
            int cursorPos = desc.SelectionStart;
            string value = desc.Text;
            if (_manager?.Visualiser.CurrentStep != null && value != _manager.Visualiser.CurrentStep.Description)
            {
                _manager.Visualiser.CurrentStep.Description = value;
                _manager.Visualiser.UpdateStep();
                desc.SelectionStart = cursorPos;
            }
        }

        private void switchState_CheckedChanged(object sender, EventArgs e)
        {
            int state = (sender as CheckBox).Checked ? 1 : 0;
            if (_manager?.Visualiser.CurrentStep != null && state != _manager.Visualiser.CurrentStep.Amount)
            {
                _manager.Visualiser.CurrentStep.Amount = state;
                _manager.UpdateName().Visualiser.UpdateStep();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SetNextStupButtonStyle(sender as ListBox);
        }

        private void _SetNextStupButtonStyle(ListBox sender)
        {
            if (sender.SelectedIndex == -1)
            {
                addNextStepButton.Enabled = false;
                removeNextStepButton.Enabled = false;
            }
            else
            {
                addNextStepButton.Enabled = true;
                removeNextStepButton.Enabled = true;
            }
        }

        private void addNextStepButton_Click(object sender, EventArgs e)
        {
            if (!_manager.Visualiser.CurrentStep.NextSteps.Contains(listBox1.SelectedIndex))
            {
                _manager.Visualiser.CurrentStep.NextSteps.Add(listBox1.SelectedIndex);
                _manager.Visualiser.UpdateStep();
                listBox1.SelectedIndex = -1;
                _SetNextStupButtonStyle(listBox1);
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter une étape qui éxiste déjà !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
