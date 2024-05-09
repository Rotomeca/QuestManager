using QuestManager.Enums.Quests.Rewards;
using QuestManager.Managers;
using QuestManager.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager.Models
{
    public class Reward : IEquatable<Reward>
    {
        private static List<string> _ids = new List<string>();
        private string _internalId;
        public RewardType Type { get; set; }
        public int GameDataId { get; set; }
        public int Amount { get; set; }
        public DurabilityOptions Durability { get; set; }

        public Reward()
        {
            _internalId = _GenerateInternalId();
            Type = RewardType.Gold;
            GameDataId = 0;
            Amount = 0;
            Durability = new DurabilityOptions();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Reward);
        }

        public bool Equals(Reward other)
        {
            return !(other is null) &&
                   Type == other.Type &&
                   GameDataId == other.GameDataId &&
                   Amount == other.Amount &&
                   _internalId == other._internalId &&
                   Durability.Equals(other.Durability);
        }

        public override int GetHashCode()
        {
            int hashCode = 1654345086;
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            hashCode = hashCode * -1521134295 + GameDataId.GetHashCode();
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            hashCode = hashCode * -1521134295 + Durability.GetHashCode();
            hashCode = hashCode * -1521134295 + _internalId.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            switch (Type)
            {
                case RewardType.Variable:
                    return $"La variable {GameDataId} vaut {Amount}";
                case RewardType.Switch:
                    return $"L'intérrupteur {GameDataId} est activé";
                case RewardType.Gold:
                    return $"Obtenir {Amount} or(s)";
                case RewardType.Item:
                    return $"Obtenir {Amount} objet(s) {GameDataId}";
                case RewardType.Armor:
                    return $"Obtenir {Amount} armures(s) {GameDataId} {Durability}";
                case RewardType.Weapon:
                    return $"Obtenir {Amount} armes(s) {GameDataId} {Durability}";
                case RewardType.Quest:
                    return $"Débloquer la quête \"{Manager.Instance.QuestManager[GameDataId].Name}\"";
                default:
                    return string.Empty;
            }
        }

        private string _GenerateInternalId()
        {
            string id = string.Empty;
            Random rdm = new Random();
            int size = rdm.Next(1, _ids.Count + 5);

            for (int i = 0; i < size; ++i)
            {
                id += rdm.Next(0, 9);
            }

            if (_ids.Contains(id)) return _GenerateInternalId();
            else return id;
        }

        public static bool operator ==(Reward left, Reward right)
        {
            return EqualityComparer<Reward>.Default.Equals(left, right);
        }

        public static bool operator !=(Reward left, Reward right)
        {
            return !(left == right);
        }
    }
}
