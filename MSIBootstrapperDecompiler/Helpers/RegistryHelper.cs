using Microsoft.Win32;
using System.Linq;

namespace MSIBootstrapperDecompiler.Helpers
{
    public static class RegistryHelper
    {
        /// <summary>
        /// Checks in registry if array names are installed
        /// </summary>
        /// <param name="programsArray"></param>
        /// <returns></returns>
        public static bool CheckStringArrayInstalled(string[] programsArray)
        {
            var isFound = false;

            string displayName = null;

            var registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (var subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    if (subkey != null) displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName == null) continue;
                    if (programsArray.Any(item => displayName.Contains(item)))
                    {
                        isFound = true;
                    }
                }
                key.Close();
            }

            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key == null) return isFound;
            {
                foreach (var subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    if (subkey != null) displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName == null) continue;
                    if (programsArray.Any(item => displayName.Contains(item)))
                    {
                        isFound = true;
                    }
                }
                key.Close();
            }

            return isFound;
        }
    }
}
