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
        public List<Armor> ArmorsList;

        private UiController _uiController;

        void Start()
        {
            LoadWeapons();
            LoadArmor();
            _uiController = GameObject.FindObjectOfType<UiController>();
            LoadInitialSword();
            LoadInitialArmor();
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

        private void LoadArmor()
        {
            var itemList = ResourcesHelper.LoadJson<ArmorJson>("Text/Armor");
            ArmorsList = itemList.armors.Select(armor => ItemMapper.Map(armor)).ToList();
        }

        private void LoadInitialSword()
        {
            if (_uiController)
            {
                _uiController.CharacterWindow.LoadWeapon(WeaponsList.FirstOrDefault(w => w.WeaponLevel == 1 && w.WeaponType == Enums.WeaponType.OneHandedSword));
            }
        }

        private void LoadInitialArmor()
        {
            if (_uiController)
            {
                _uiController.CharacterWindow.LoadArmor(ArmorsList.FirstOrDefault(w => w.ArmorLevel == 1 && w.ArmorType == Enums.ArmorType.BodyArmor));
            }
        }
    }
}
