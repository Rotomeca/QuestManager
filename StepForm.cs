using QuestManager.Enums.Quests.Steps;
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
        }
    }
}
