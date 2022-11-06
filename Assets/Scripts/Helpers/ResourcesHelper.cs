using UnityEngine;

namespace Assets.Scripts.Helpers
{
    public class ResourcesHelper
    {
        public static TextAsset LoadText(string path)
        {
            var result = Resources.Load<TextAsset>(path);
            return result;
        }

        public static Sprite LoadImage(string path)
        {
            var result = Resources.Load<Sprite>(path);
            return result;
        }
    }
}
