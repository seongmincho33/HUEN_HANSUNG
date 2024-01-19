using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class SymbolModel
    {
        public dynamic Symbol { get; set; }
        public string Name { get; set; }
        public string ProgID { get; set; }
        public string CodeBase { get; set; }
        public string GeomOption { get; set; }
        public string Version { get; set; }

        public SymbolModel()
        {
            Symbol = "";
            Name = "";
            ProgID = "";
            CodeBase = "";
            GeomOption = "";
            Version = "";
        }
    }
}
