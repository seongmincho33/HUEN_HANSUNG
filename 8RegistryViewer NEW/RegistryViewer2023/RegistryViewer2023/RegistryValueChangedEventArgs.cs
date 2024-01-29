using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryViewer2023
{
    public class RegistryValueChangedEventArgs : EventArgs
    {
        public string RegistryKeyPath { get; }

        public string ValueName { get; }

        public object PreviousValueData { get; }

        public object CurrentValueData { get; }

        public RegistryValueChangedEventArgs(string registryKeyPath, string valueName, object currentValueData = null, object previousValueData = null)
        {
            RegistryKeyPath = registryKeyPath;
            ValueName = valueName;
            CurrentValueData = currentValueData;
            PreviousValueData = previousValueData;
        }
    }
}
