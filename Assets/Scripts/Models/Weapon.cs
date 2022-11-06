using Assets.Scripts.Enums;

namespace Assets.Scripts.Models
{
    public class Weapon : BaseEntity
    {
        public WeaponType WeaponType;
        public int WeaponLevel;
        public int Attack;
        public int Defence;
        public int Weight;
    }
}
