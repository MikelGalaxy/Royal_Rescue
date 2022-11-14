using System;

namespace Assets.Scripts.Dtos
{
    [Serializable]
    public class WeaponModel
    {
        public string id;
        public string name;
        public string resourceName;
        public int attack;
        public int defense;
        public int weight;
        public string weaponType;
        public int weaponLevel;
    }

    [Serializable]
    public class WeaponsJson
    {
        public WeaponModel[] weapons;
    }
}
