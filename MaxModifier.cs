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
    public partial class MaxModifier : Form
    {
        public int StartMax {  get; set; }
        public int ModifiedMaximum { get; set; }
        private bool _validated;
        public MaxModifier(int max, Point position)
        {
            InitializeComponent();
            _validated = false;
            StartMax = max;
            maxControl.Value = StartMax;
            //SetDesktopLocation(position.X, position.Y);
            Location = position;
            StartPosition = FormStartPosition.Manual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _validated = true;
            Close();
        }

        private void value_updated(object sender, EventArgs e)
        {
            ModifiedMaximum = (int)((NumericUpDown)sender).Value;
        }

        public int MaximumValue
        {
            get
            {
                if (_validated) return ModifiedMaximum;
                else return StartMax;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
