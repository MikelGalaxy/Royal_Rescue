using Assets.Scripts.Enums;

namespace Assets.Scripts.Models
{
    public class Consumable : BaseEntity
    {
        public ConsumableType ConsumableType;
        public int BuffPower;   //also understood as how much it heals
        public int BuffDuration; //in case of temp potions
    }
}
