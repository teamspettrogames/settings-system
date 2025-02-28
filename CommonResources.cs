using System;
using System.IO;
using TeamSpettro.SettingsSystem;
namespace TeamSpettro
{
    public static class Resources
    {
        public static string SettingsFilePath;
        public static Settings Settings;
        public static void Initialize(string in_PathSettings)
        {
            SettingsFilePath = in_PathSettings;
            Settings = new Settings();
        }
    }
}
