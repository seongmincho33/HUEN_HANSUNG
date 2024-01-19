using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelViewer
{
    public class ExplorerDoubleClickEventArgs : EventArgs
    {
        public string FILE_PATH { get; set; }

        public Guid KEY { get; set; }

        public Guid PARENT_KEY { get; set; }

        public string NODE_NAME { get; set; }

        public bool IS_SHEET { get; set; }


        private string sheet_name;
        public string SHEET_NAME
        {
            get
            {
                if (IS_SHEET)
                {
                    return sheet_name;
                }

                return null;
            }
            set
            {
                this.sheet_name = value;
            }
        }
    }
}
