using System;

namespace MyLibrary
{
    public static class JsonUtils
    {
        public static string GetJson(Object aObject)
        {
            return aObject is null ? null : Newtonsoft.Json.JsonConvert.SerializeObject(aObject);
        }

        public static T GetObject<T>(string aJson)
        {
            return string.IsNullOrEmpty(aJson) ? default : Newtonsoft.Json.JsonConvert.DeserializeObject<T>(aJson);
        }
    }
}
