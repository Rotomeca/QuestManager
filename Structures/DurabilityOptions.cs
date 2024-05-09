using QuestManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager.Structures
{
    public class DurabilityOptions : IEquatable<DurabilityOptions>
    {
        private IntEx _updateMax;
        public bool Active { get; set; }
        public uint Durabilty { get; set; }
        public IntEx UpdateMax { get {
                if (_updateMax == null) { _updateMax = new IntEx(); } 
                return _updateMax;
            } 
            set => _updateMax = value; }

        public DurabilityOptions()
        {
            _Init();
        }

        public DurabilityOptions(uint durability)
        {
            _Init(durability);
        }

        public DurabilityOptions(int updateMax)
        {
            _Init(updateMax:  updateMax);
        }

        public DurabilityOptions(uint durability, int updateMax)
        {
            _Init(durability, updateMax);
        }

        private void _Init(uint durability = 0, int updateMax = 0) {
            if (0 != durability || 0 != updateMax) Active = true;
            else Active = false;

            Durabilty = durability;
            UpdateMax = updateMax;
        }



        public override string ToString()
        {
            if (!Active) return string.Empty;
            else
            {
                var str = string.Empty;

                if (Durabilty != 0) str += $"({Durabilty}/{Durabilty})";
                if (UpdateMax != 0) str += $" => {UpdateMax} ";

                return str;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is DurabilityOptions options && Equals(options);
        }

        public bool Equals(DurabilityOptions other)
        {
            return Active == other.Active &&
                   Durabilty == other.Durabilty &&
                   EqualityComparer<IntEx>.Default.Equals(UpdateMax, other.UpdateMax);
        }

        public override int GetHashCode()
        {
            int hashCode = -872568586;
            hashCode = hashCode * -1521134295 + Active.GetHashCode();
            hashCode = hashCode * -1521134295 + Durabilty.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IntEx>.Default.GetHashCode(UpdateMax);
            return hashCode;
        }

        public static bool operator ==(DurabilityOptions left, DurabilityOptions right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DurabilityOptions left, DurabilityOptions right)
        {
            return !(left == right);
        }
    }
}
