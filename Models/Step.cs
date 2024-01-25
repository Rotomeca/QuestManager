using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StepType = QuestManager.Enums.Quests.Steps.QuestStepType;

namespace QuestManager.Models
{
    public class Step
    {
        public StepType Type { get; set; }
        public uint GameDataId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public bool IsHidden { get; set; }
        public List<int> NextSteps { get; set; }

        public Step()
        {
            Type = StepType.Variable;
            GameDataId = 0;
            Description = string.Empty;
            Amount = 0;
            IsHidden = false;
            NextSteps = new List<int>();
        }

        public bool ShowAmount() => !(new List<StepType>() { StepType.Switch, StepType.TalkingTo, StepType.Location }.Contains(Type));

        public bool ShowSwitchState() => StepType.Switch == Type;

        public bool ShowGameDataId() => !(new List<StepType>() { StepType.TalkingTo, StepType.Location }.Contains(Type));

        public string GetDescriptionLabel()
        {
            string name;

            switch (Type)
            {
                case StepType.TalkingTo:
                    name = "Parler à";
                    break;

                case StepType.Location:
                    name = "Destination";
                    break;

                default:
                    name = "Description";
                    break;
            }

            return name;
        }

        public string AmountLabel()
        {
            string label;

            switch (Type)
            {
                case StepType.Kill:
                    label = "Tuer";
                    break;

                case StepType.Variable:
                    label = "La variable doit valoir";
                    break;

                default:
                    label = "Obtenir";
                    break;
            }

            return label;
        }

        public string AmountUnit()
        {
            string label;

            switch (Type)
            {
                case StepType.Kill:
                    label = $"Ennemi{(Amount > 1 ? "s" : string.Empty)}";
                    break;

                default:
                    label = string.Empty;
                    break;
            }

            return label;
        }
    }
}
