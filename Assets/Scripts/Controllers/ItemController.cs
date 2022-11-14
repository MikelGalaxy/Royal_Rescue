using Assets.Scripts.Dtos;
using Assets.Scripts.Helpers;
using Assets.Scripts.Mappers;
using Assets.Scripts.Models;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class ItemController : MonoBehaviour
    {
        public List<Weapon> WeaponsList;
        void Start()
        {
            LoadWeapons();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void LoadWeapons()
        {
            var itemList = ResourcesHelper.LoadJson<WeaponsJson>("Text/Weapons");
            WeaponsList = itemList.weapons.Select(weapon => ItemMapper.Map(weapon)).ToList();
        }
    }
}
