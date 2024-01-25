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
                .InitNextSteps(nextSteps)
                .InitGameDataId(gameDataIdLabel, gameDataId);

            _manager = new StepManager(allSteps, initialiser);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addStepButton_Click(object sender, EventArgs e)
        {
            _manager.Add();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _manager.RemoveCurrent();
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
                _manager.Visualiser.UpdateStep();
            }
        }
    }
}
