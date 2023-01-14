using Assets.Scripts.Dtos;
using Assets.Scripts.Enums;
using Assets.Scripts.Models;
using System;

namespace Assets.Scripts.Mappers
{
    public class ItemMapper
    {
        public static Weapon Map(WeaponModel model) => new Weapon
        {
            Id = model.id,
            Name = model.name,
            ResourceName = model.resourceName,
            Attack = model.attack,
            Defense = model.defense,
            Weight = model.weight,
            WeaponType = (WeaponType)Enum.Parse(typeof(WeaponType), model.weaponType),
            WeaponLevel = model.weaponLevel
        };

        public static Armor Map(ArmorModel model) => new Armor
        {
            Id = model.id,
            Name = model.name,
            ResourceName = model.resourceName,
            Attack = model.attack,
            Defense = model.defense,
            Weight = model.weight,
            ArmorLevel = model.armorLevel,
            ArmorType = (ArmorType)Enum.Parse(typeof(ArmorType), model.armorType),
        };
    }
}
