using Assets.Scripts.Enums;
using System;

namespace Assets.Scripts.Models
{
    [Serializable]
    public class Weapon : Wearable
    {
        public WeaponType WeaponType;
        public int WeaponLevel;
    }
}
