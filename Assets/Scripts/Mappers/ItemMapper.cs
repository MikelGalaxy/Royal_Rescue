using Assets.Scripts.Dtos;
using Assets.Scripts.Enums;
using Assets.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Mappers
{
    public class ItemMapper
    {
        public static Weapon Map(WeaponModel model)
        {
            return new Weapon
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
        }
    }
}
