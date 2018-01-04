using System.Configuration;

namespace MSIBootstrapperDecompiler.Helpers
{
    public static class ConfigHelper
    {
        /// <summary>
        /// Reads application config value using key
        /// </summary>
        /// <param name="key">string: word used as key in application configuration file</param>
        /// <returns></returns>
        public static string ReadConfigString(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var value = config.AppSettings.Settings[key].Value;

            return value;
        }
    }
}
