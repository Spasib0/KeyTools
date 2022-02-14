using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace KeyCheckGui
{
    public class SavedData
    {
        //SaveData[login]
        private Dictionary<string, string> savedData = new Dictionary<string, string>();

        public string this[string key]
        {
            get 
            {
                return savedData.Keys.Contains(key) ? savedData[key] : null; 
            }
            set 
            {
                savedData[key] = value;
                SaveData(savedData);
            }
        }

        public SavedData()
        {
            TryLoadData();
        }

        public void SaveData(Dictionary<string, string> data)
        {
            File.WriteAllText("savedData", JsonSerializer.Serialize(savedData));
        }

        public void TryLoadData()
        {
            if (File.Exists("savedData"))
            {
                var data = File.ReadAllText("savedData");
                savedData = JsonSerializer.Deserialize<Dictionary<string, string>>(data);
            }
        }
    }
}