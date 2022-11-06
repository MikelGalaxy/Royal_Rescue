using Assets.Scripts.Enums;
using Assets.Scripts.Helpers;
using Assets.Scripts.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Ui.Shared
{
    public class Slot : MonoBehaviour
    {
        public Image SlotImage;
        public TextMeshProUGUI SlotText;
        public SlotType SlotType;

        protected string EntityId;
        // Start is called before the first frame update
        void Start()
        {
            DisplayEmpty();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void DisplayEmpty()
        {
            SlotText.gameObject.SetActive(false);
            LoadImage(SlotType, "background");
        }

        protected void Display(BaseEntity BaseEntity, int amount = 0)
        {
            if (amount != 0)
            {
                UpdateText(amount.ToString());
            }

            EntityId = BaseEntity.Id;
            LoadImage(SlotType, BaseEntity.ResourceName);
        }

        private void LoadImage(SlotType slotType, string resourceName)
        {
            var folder = slotType.ToString();
            SlotImage.sprite = ResourcesHelper.LoadImage($"Graphics/{folder}/{resourceName}");
        }

        protected void UpdateText(string newText)
        {
            SlotText.gameObject.SetActive(true);
            SlotText.text = newText;
        }
    }

}
