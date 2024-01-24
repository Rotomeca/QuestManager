﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestManager.Models
{
    public class StepVisualiser
    {
        private sealed class Data
        {
            public ComboBox type;
            public CheckBox isVisible;
            public RichTextBox description;
            public TextBox who_where;
            public Label descLabel;
            public NumericUpDown amount;
            public CheckBox switchState;
            public Label amountLabel;
            public Label amountUnitLabel;
            public TreeView nextSteps;
           
            private Data() {}

            public static Data Provide() { return new Data(); }
        }
        public sealed class Initialiser
        {
            private Data _controls;
            public Initialiser()
            {
                _controls = Data.Provide();
            }

            public Initialiser InitType(ComboBox type)
            {
                _controls.type = type;
                return this;
            }

            public Initialiser InitIsVisible(CheckBox isVisible)
            {
                _controls.isVisible = isVisible;
                return this;
            }

            public Initialiser InitDescription(Label label, RichTextBox desc, TextBox name)
            {
                _controls.descLabel = label;
                _controls.description = desc;
                _controls.who_where = name;
                return this;
            }

            public Initialiser InitAmount(Label label, NumericUpDown amount, Label unit)
            {
                _controls.amountLabel = label;
                _controls.amountUnitLabel = unit;
                _controls.amount = amount;
                return this;
            }

            public Initialiser InitSwitchState(CheckBox switchState)
            {
                _controls.switchState = switchState;
                return this;
            }

            public Initialiser InitNextSteps(TreeView nextSteps)
            {
                _controls.nextSteps = nextSteps;
                return this;
            }

            public object Get() => _controls;
        }

        private Data _controls;
        private Step _currentStep;

        public Step CurrentStep => _currentStep;

        public StepVisualiser(Initialiser initialiser)
        {
            _controls = initialiser.Get() as Data;
        }

        public StepVisualiser ChangeStep(Step step)
        {
            _currentStep = step;
            _controls.type.Text = Enum.GetName(typeof(Step), step.Type);
            _controls.isVisible.Checked = !step.IsHidden;
            return this;
        }
    }
}