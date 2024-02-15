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

        public override string ToString()
        {
            string str;

            if (Settings.Instance.NameInsteadOfDesc) str = string.IsNullOrEmpty(Description) ? _ToStringDesc() : Description;
            else str = _ToStringDesc();

            if (IsHidden) str = $"({str})";

            return str;
        }

        private string _ToStringDesc()
        {
            string str;
            switch (Type)
            {
                case StepType.Variable:
                    str = $"La variable {GameDataId} doit atteindre la valeur {Amount}";
                    break;
                case StepType.Switch:
                    str = $"L'interrupteur {GameDataId} {(Amount == 1 ? "doit" : "ne doit pas")} être activé";
                    break;
                case StepType.Location:
                    str = $"Aller à {Description}";
                    break;
                case StepType.TalkingTo:
                    str = $"Parler à {Description}";
                    break;
                case StepType.Kill:
                    str = $"Tuer {Amount} ennemi{(Amount > 1 ? "s" : string.Empty)} avec l'id {GameDataId}";
                    break;
                case StepType.GetItem:
                    str = $"Obtenir {Amount} objets avec l'id {GameDataId}";
                    break;
                case StepType.GetArmor:
                    str = $"Obtenir {Amount} armures avec l'id {GameDataId}";
                    break;
                case StepType.GetWeapon:
                    str = $"Obtenir {Amount} armes avec l'id {GameDataId}";
                    break;
                case StepType.Custom:
                    str = "Personnalisée";
                    break;
                default:
                    throw new NotSupportedException();
            }

            return str;
        }
    }
}
