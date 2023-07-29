using System.Text;
using ProjectGraphQL.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ProjectGraphQL.Service
{
    public class MusicCollectionService
    {
        private const string jsonFileName = "Musics.json";

        //Deserialize object
        public static MusicCollection FromJson()
        {   
            if (File.Exists(jsonFileName))
            {
                var jsonContent = File.ReadAllText(jsonFileName, Encoding.UTF8);
                return JsonConvert.DeserializeObject<MusicCollection>(jsonContent);
            }
            return new();
        }

        //Serialize object
        public static void ToJson(MusicCollection musicCollection)
        {
            var jsonContent = JsonConvert.SerializeObject(musicCollection, new JsonSerializerSettings 
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },

                Formatting = Formatting.Indented
            });
            File.WriteAllText(jsonFileName, jsonContent);
        }
    }
}