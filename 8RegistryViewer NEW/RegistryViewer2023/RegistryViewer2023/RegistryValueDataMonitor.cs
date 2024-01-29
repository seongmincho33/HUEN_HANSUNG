using Microsoft.Win32.SafeHandles;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Reflection;

namespace RegistryViewer2023
{
    public class RegistryValueDataMonitor : IDisposable
    {
        // Property to get the current monitor interval from UserSettings
        private int MonitorInterval => UserSettings.Instance.MonitorInterval;
        private RegistryKey registryKey;
        private string ValueName;
        private Dictionary<string, object> previousValues;
        private CancellationTokenSource cancellationTokenSource;
        public event EventHandler<RegistryValueChangedEventArgs> RegistryValueChanged;
        
        public RegistryValueDataMonitor(string subKeyPath, string valueName)
        {
            ValueName = valueName;
            if (string.IsNullOrWhiteSpace(subKeyPath))
                throw new ArgumentException("Invalid registry subkey path.");

            // Determine the hive by checking the path
            RegistryHive hive;

            if (subKeyPath.StartsWith("HKEY_CLASSES_ROOT"))
            {
                hive = RegistryHive.ClassesRoot;
                subKeyPath = subKeyPath.Substring("HKEY_CLASSES_ROOT".Length + 1);
            }
            else if (subKeyPath.StartsWith("HKEY_CURRENT_USER"))
            {
                hive = RegistryHive.CurrentUser;
                subKeyPath = subKeyPath.Substring("HKEY_CURRENT_USER".Length + 1);
            }
            else if (subKeyPath.StartsWith("HKEY_LOCAL_MACHINE"))
            {
                hive = RegistryHive.LocalMachine;
                subKeyPath = subKeyPath.Substring("HKEY_LOCAL_MACHINE".Length + 1);
            }
            else if (subKeyPath.StartsWith("HKEY_USERS"))
            {
                hive = RegistryHive.Users;
                subKeyPath = subKeyPath.Substring("HKEY_USERS".Length + 1);
            }
            else if (subKeyPath.StartsWith("HKEY_CURRENT_CONFIG"))
            {
                hive = RegistryHive.CurrentConfig;
                subKeyPath = subKeyPath.Substring("HKEY_CURRENT_CONFIG".Length + 1);
            }
            else
            {
                throw new Exception("Unsupported registry hive in path.");
            }

            registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default).OpenSubKey(subKeyPath, true);

            if (registryKey == null)
                throw new ArgumentException("Failed to open the registry key.");

            
            this.registryKey = registryKey;
            this.previousValues = new Dictionary<string, object>();
            cancellationTokenSource = new CancellationTokenSource();
            Initialize();
        }

        private void Initialize()
        {
            foreach (string valueName in registryKey.GetValueNames())
            {
                previousValues[valueName] = registryKey.GetValue(valueName);
            }

            StartMonitoring();
        }

        public void StartMonitoring()
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested) // You can add your own exit condition here
                {
                    //foreach (string valueName in registryKey.GetValueNames())
                    //{
                        
                    //}

                    object currentValue = registryKey.GetValue(this.ValueName);
                    if (previousValues.ContainsKey(this.ValueName) && !currentValue.Equals(previousValues[this.ValueName]))
                    {
                        // Registry value data has changed
                        RegistryValueChanged?.Invoke(this, new RegistryValueChangedEventArgs(registryKey.Name, this.ValueName, currentValue, previousValues[this.ValueName]));
                        previousValues[this.ValueName] = currentValue;
                    }

                    Thread.Sleep(this.MonitorInterval); // Adjust the polling interval as needed
                }
            });
        }

        public void StopMonitoring()
        {
            cancellationTokenSource.Cancel();
        }

        public void Dispose()
        {
            cancellationTokenSource.Cancel();            
        }
    }

    //public class RegistryMonitor : IDisposable
    //{
    //    private readonly RegistryKey registryKey;
    //    private SafeRegistryHandle safeRegistryHandle;
    //    private bool isMonitoring;

    //    public event EventHandler<RegistryValueChangedEventArgs> RegistryValueNameAndDataChanged;

    //    public RegistryMonitor(string subKeyPath)
    //    {
    //        if (string.IsNullOrWhiteSpace(subKeyPath))
    //            throw new ArgumentException("Invalid registry subkey path.");

    //        // Determine the hive by checking the path
    //        RegistryHive hive;            

    //        if (subKeyPath.StartsWith("HKEY_CLASSES_ROOT"))
    //        {
    //            hive = RegistryHive.ClassesRoot;
    //            subKeyPath = subKeyPath.Substring("HKEY_CLASSES_ROOT".Length + 1);
    //        }
    //        else if (subKeyPath.StartsWith("HKEY_CURRENT_USER"))
    //        {
    //            hive = RegistryHive.CurrentUser;
    //            subKeyPath = subKeyPath.Substring("HKEY_CURRENT_USER".Length + 1);
    //        }
    //        else if (subKeyPath.StartsWith("HKEY_LOCAL_MACHINE"))
    //        {
    //            hive = RegistryHive.LocalMachine;
    //            subKeyPath = subKeyPath.Substring("HKEY_LOCAL_MACHINE".Length + 1);
    //        }
    //        else if (subKeyPath.StartsWith("HKEY_USERS"))
    //        {
    //            hive = RegistryHive.Users;
    //            subKeyPath = subKeyPath.Substring("HKEY_USERS".Length + 1);
    //        }
    //        else if (subKeyPath.StartsWith("HKEY_CURRENT_CONFIG"))
    //        {
    //            hive = RegistryHive.CurrentConfig;
    //            subKeyPath = subKeyPath.Substring("HKEY_CURRENT_CONFIG".Length + 1);
    //        }
    //        else
    //        {
    //            throw new Exception("Unsupported registry hive in path.");
    //        }

    //        int result = RegOpenKeyEx(hive, subKeyPath, 0, (int)RegistryRights.Notify, out safeRegistryHandle);

    //        if (result != 0)
    //            throw new ArgumentException("Failed to open the registry key.");

    //        registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default).OpenSubKey(subKeyPath, true);

    //        isMonitoring = true;

    //        // Start monitoring changes in a background thread.
    //        StartMonitoring();
    //    }

    //    public void Dispose()
    //    {
    //        isMonitoring = false;
    //        safeRegistryHandle?.Close();
    //    }

    //    private void StartMonitoring()
    //    {
    //        ThreadPool.QueueUserWorkItem(state =>
    //        {
    //            while (isMonitoring)
    //            {
    //                if (WaitForSingleObject(safeRegistryHandle.DangerousGetHandle(), 5000) == 0)
    //                {
    //                    // Registry key changes detected
    //                    CheckRegistryChanges();
    //                }
    //            }
    //        });
    //    }

    //    private void CheckRegistryChanges()
    //    {
    //        // Implement your logic to check registry changes here.
    //        // For example, compare current registry values with previous values.

    //        // Notify when value names change
    //        string[] valueNames = registryKey.GetValueNames();

    //        // Notify when value data changes
    //        foreach (var valueName in valueNames)
    //        {
    //            object valueData = registryKey.GetValue(valueName);
    //            RegistryValueNameAndDataChanged?.Invoke(this, new RegistryValueChangedEventArgs(valueName, valueData));
    //        }
    //    }

    //    [DllImport("advapi32.dll", SetLastError = true)]
    //    private static extern int RegOpenKeyEx(
    //        RegistryHive hKey,
    //        string subKey,
    //        int options,
    //        int samDesired,
    //        out SafeRegistryHandle phkResult);

    //    [DllImport("kernel32.dll")]
    //    private static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);
    //}

}
