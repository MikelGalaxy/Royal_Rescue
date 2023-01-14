using System;

namespace Assets.Scripts.Dtos
{
    [Serializable]
    public class ArmorModel
    {
        public string id;
        public string name;
        public string resourceName;
        public int attack;
        public int defense;
        public int weight;
        public int armorLevel;
    }

    [Serializable]
    internal class ArmorJson
    {
        public ArmorModel[] armors;
    }
}
