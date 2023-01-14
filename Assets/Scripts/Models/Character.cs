using System;

namespace Assets.Scripts.Models
{
    [Serializable]
    public class Character
    {
        public string Id;
        public string Name;

        //BASE Attributes
        public int Level = 1;
        public int Strength = 1;
        public int Agility = 1;
        public int HpLevel = 10;
        public int EnergyLevel = 10;
    }
}
