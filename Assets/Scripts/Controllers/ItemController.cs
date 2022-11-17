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

        private UiController _uiController;

        void Start()
        {
            LoadWeapons();
            _uiController = GameObject.FindObjectOfType<UiController>();
            LoadInitialSword();
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

        private void LoadInitialSword()
        {
            if (_uiController)
            {
                _uiController.CharacterWindow.LoadWeapon(WeaponsList.FirstOrDefault(w => w.WeaponLevel == 1 && w.WeaponType == Enums.WeaponType.OneHandedSword));
            }
        }
    }
}
