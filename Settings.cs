namespace TeamSpettro.SettingsSystem
{
    public class Settings : BaseJsonSettingsModel
    {
        public Settings()
        : base(Resources.SettingsFilePath, false)
        {
        }

        public Dictionary<string, int> Int
        {
            get => Get<Dictionary<string, int>>(new Dictionary<string, int>());
            set => Set(value);
        }
        public Dictionary<string, float> Float
        {
            get => Get<Dictionary<string, float>>(new Dictionary<string, float>());
            set => Set(value);
        }
        public Dictionary<string, string> String
        {
            get => Get<Dictionary<string, string>>(new Dictionary<string, string>());
            set => Set(value);

        }
        public Dictionary<string, bool> Bool
        {
            get => Get<Dictionary<string, bool>>(new Dictionary<string, bool>());
            set => Set(value);

        }
    }
}

