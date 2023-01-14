using Assets.Scripts.Models;
using Assets.Scripts.Ui.Shared;
using UnityEngine;

namespace Assets.Scripts.Ui
{
    public class CharacterWindow : MonoBehaviour
    {
        public GameObject Window;
        public Slot Shield;
        public Slot Armor;
        public Slot Weapon;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void LoadWeapon(Weapon weapon)
        {
            Weapon.Display(weapon);
        }

        public void LoadArmor(Armor armor)
        {
            Armor.Display(armor);
        }
    }
}

