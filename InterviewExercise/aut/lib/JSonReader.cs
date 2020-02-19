using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterviewExercise.aut.lib
{
    public class JSonReader
    {
        static JObject properties = null;

        public static void LoadJson(string fileName)
        {
            JObject jObject = JObject.Parse(File.ReadAllText(Environment.CurrentDirectory.Replace("bin\\Debug\\netcoreapp2.1", "aut\\lib\\" + fileName)));

            using (StreamReader file = File.OpenText(Environment.CurrentDirectory.Replace("bin\\Debug\\netcoreapp2.1", "aut\\lib\\" + fileName)))
            using (JsonTextReader tr = new JsonTextReader(file))
            {
                properties = (JObject)JToken.ReadFrom(tr);
            }
        }

        public static string GetProperty(string FileName, string PropName)
        {
            LoadJson(FileName);
            return properties.SelectToken(PropName).ToString();
        }
    }
}
