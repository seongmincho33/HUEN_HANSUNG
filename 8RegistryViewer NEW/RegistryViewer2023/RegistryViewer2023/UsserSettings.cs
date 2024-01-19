using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryViewer2023
{
    public class UserSettings
    {
        private static UserSettings _instance;
        private static readonly object _lock = new object();

        public int MonitorInterval { get; set; } = 1000;

        protected UserSettings()
        {
            // Initialize settings
        }

        public static UserSettings Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserSettings();
                        // Load settings from file or database
                        // Example: _instance.MonitorInterval = LoadMonitorIntervalFromSettings();
                    }
                    return _instance;
                }
            }
        }

        // Example
        // Method to load MonitorInterval from settings (file, database, etc.)
        private int LoadMonitorIntervalFromSettings()
        {
            // Implement loading logic here
            // For example, read from a config file or database
            return 1000; // Return the loaded interval
        }
    }

}
