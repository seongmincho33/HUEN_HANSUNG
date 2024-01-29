using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryViewer2023
{
    public class RegistryModel
    {
        public bool Red { get; set; }
        public bool Yellow { get; set; }
        public bool Green { get; set; }
        public bool Blue { get; set; }
        public string ValueName { get; set; }
        public string DataType { get; set; }
        public object Data { get; set; }
        public RegistryKey RegistryKey { get; set; }
        public string RegistryKeyPath { get; set; }
    }
}
