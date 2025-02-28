using System.Collections.Generic;
namespace TeamSpettro.SettingsSystem
{
    /// <summary>
    /// Script that manages settings with d2dyno's Setting System.
    /// </summary>
    public static class SettingsManager
    {
        #region Get
        public static int GetInt(string name, int defaultValue = 0)
        {
            if (Resources.Settings.Int == null)
            {
                Resources.Settings.Int = new Dictionary<string, int>();
            }
            var settingsInt = Resources.Settings.Int;
            if (settingsInt.ContainsKey(name))
            {
                int keyVal;
                settingsInt.TryGetValue(name, out keyVal);
                return keyVal;
            }
            else
            {
                settingsInt.Add(name, defaultValue);
                Resources.Settings.Int = settingsInt;
                return defaultValue;
            }
        }
        public static float GetFloat(string name, float defaultValue = 0)
        {
            if (Resources.Settings.Float == null)
            {
                Resources.Settings.Float = new Dictionary<string, float>();
            }
            var settingsFloat = Resources.Settings.Float;
            if (settingsFloat.ContainsKey(name))
            {
                float keyVal;
                settingsFloat.TryGetValue(name, out keyVal);
                return keyVal;
            }
            else
            {
                settingsFloat.Add(name, defaultValue);
                Resources.Settings.Float = settingsFloat;
                return defaultValue;
            }
        }

        public static string GetString(string name, string defaultValue = "")
        {
            if (Resources.Settings.String == null)
            {
                Resources.Settings.String = new Dictionary<string, string>();
            }          
            var settingsString = Resources.Settings.String;
            if (settingsString.ContainsKey(name))
            {
                string keyVal;
                settingsString.TryGetValue(name, out keyVal);
                return keyVal;
            }
            else
            {
                settingsString.Add(name, defaultValue);
                Resources.Settings.String = settingsString;
                return defaultValue;
            }
        }
        public static bool GetBool(string name, bool defaultValue = false)
        {
            if (Resources.Settings.Bool == null)
            {
                Resources.Settings.Bool = new Dictionary<string, bool>();
            }
            var settingsBool = Resources.Settings.Bool;
            if (settingsBool.ContainsKey(name))
            {
                bool keyVal;
                settingsBool.TryGetValue(name, out keyVal);
                return keyVal;
            }
            else
            {
                settingsBool.Add(name, defaultValue);
                Resources.Settings.Bool = settingsBool;
                return defaultValue;
            }
        }
        public static object EnumerateSettings()
        {
            return Resources.Settings.ExportSettings();
        }
        #endregion
        #region Set
        public static void SetInt(string name, int value)
        {
            if (Resources.Settings.Int == null)
            {
                Resources.Settings.Int = new Dictionary<string, int>();
            }
           
            var settingsInt = Resources.Settings.Int;
            settingsInt[name] = value;
            Resources.Settings.Int = settingsInt;
        }

        public static void SetFloat(string name, float value)
        {
            if (Resources.Settings.Float == null)
            {
                Resources.Settings.Float = new Dictionary<string, float>();
            }
          
            var settingsFloat = Resources.Settings.Float;
            settingsFloat[name] = value;
            Resources.Settings.Float = settingsFloat;
            
        }
        public static void SetString(string name, string value)
        {
            if (Resources.Settings.String == null)
            {
                Resources.Settings.String = new Dictionary<string, string>();
            }
            var settingsString = Resources.Settings.String;
            settingsString[name] = value;
            Resources.Settings.String = settingsString;
            
        }
        public static void SetBool(string name, bool value)
        {
            if (Resources.Settings.Bool == null)
            {
                Resources.Settings.Bool = new Dictionary<string, bool>();
            }
           
            var settingsBool = Resources.Settings.Bool;
            settingsBool[name] = value;
            Resources.Settings.Bool = settingsBool;
            
        }
        #endregion
        #region Delete
        public static void DeleteAll()
        {
            var settings = Resources.Settings;

            settings.String.Clear();
            settings.Int.Clear();
            settings.Float.Clear();
            Resources.Settings = settings;
            System.IO.File.Copy(Resources.Settings.GetPath(), System.IO.Path.Combine(System.IO.Directory.GetParent(Resources.Settings.GetPath()).FullName, "backupsettings"));
            System.IO.File.Delete(Resources.Settings.GetPath());
        }
        #endregion

        #region Has
        public static bool HasInt(string key)
        {
            var settings = Resources.Settings.Int;
            int val;
            return settings.TryGetValue(key, out val);

        }
        public static bool HasFloat(string key)
        {
            var settings = Resources.Settings.Float;
            float val;
            return settings.TryGetValue(key, out val);

        }
        public static bool HasString(string key)
        {
            var settings = Resources.Settings.String;
            string val;
            return settings.TryGetValue(key, out val);

        }
        #endregion
    }

}