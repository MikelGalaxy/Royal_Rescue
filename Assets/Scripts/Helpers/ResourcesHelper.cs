using Newtonsoft.Json;
using System;
using UnityEngine;

namespace Assets.Scripts.Helpers
{
    public static class ResourcesHelper
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

        public static T LoadJson<T>(string path) where T : class
        {
            var textAsset = LoadText(path);
            if(textAsset != null && !string.IsNullOrEmpty(textAsset.text))
            {
                var json = JsonUtility.FromJson<T>(textAsset.text);
                return json;
            }

            throw new Exception("Text resource is empty or not found");
        }
    }
}
