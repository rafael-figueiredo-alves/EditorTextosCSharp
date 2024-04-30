using System.Reflection;
using System.Text.Json;

namespace EditorTextos.Serviços
{
    public class Config
    {
        private static Config Instance;
        Configuration setting;

        string SettingsFilePath;

        public static Config Settings()
        {
            if (Instance == null)
            {
                Instance = new Config();
            }
            return Instance;
        }
        private Config()
        {
            SettingsFilePath = new FileInfo(Path.Combine(Path.GetDirectoryName(
                                Assembly.GetExecutingAssembly().Location)!, @"settings.json")).ToString();

            if (!Path.Exists(SettingsFilePath))
            {
                setting = new Configuration();
            }
            else
            {
                using (StreamReader sr = new StreamReader(SettingsFilePath))
                {
                    string JSON = sr.ReadToEnd();
                    setting = JsonSerializer.Deserialize<Configuration>(JSON)!;
                }
            }
        }

        public Configuration settings()
        {
            return setting;
        }

        public bool SaveSettings()
        {
            string _JSON = JsonSerializer.Serialize(setting).ToString();
            try
            {
                File.WriteAllText(SettingsFilePath, _JSON);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class Configuration
    {
        public bool DetectURLs { get; set; } = true;
        public string DefaultFont { get; set; } = "Arial";
        public int DefaultFontSize { get; set; } = 12;
        public bool UseMargins { get; set; } = true;
        public int Zoom { get; set; } = 1;
    }
}
