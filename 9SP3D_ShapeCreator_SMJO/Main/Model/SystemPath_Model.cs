using System;
using System.Linq;
using System.Windows.Forms;

namespace Main.Model
{
    public class SystemPath_Model
    {
        public string ID { get; set; }

        public string ParentID { get; set; }

        public string SystemName { get; set; }

        public dynamic System { get; set; }

        /// <summary>
        /// System Path Type 종류
        /// </summary>
        public MainSystemPathType SystemPathType { get; set; }

        public string Smart3DSystemType { get; set; }

        public SystemPath_Model()
        {
            this.ID = "";
            this.ParentID = "";
            this.SystemName = "";
            this.SystemPathType = MainSystemPathType.System;
            this.System = null;
        }

        public SystemPath_Model(string id, string pid, string caption, MainSystemPathType pathType, dynamic system = null)
        {
            try
            {
                this.ID = id;
                this.ParentID = pid;
                this.SystemName = caption;
                this.SystemPathType = pathType;
                this.System = system;

                if (pathType == MainSystemPathType.Root)
                {
                    this.Smart3DSystemType = "Root";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public SystemPath_Model(string id, string pid, string caption, string smart3DSystemType, dynamic system = null)
        {
            try
            {
                this.ID = id;
                this.ParentID = pid;
                this.SystemName = caption;
                this.Smart3DSystemType = smart3DSystemType;
                this.System = system;

                if (this.Smart3DSystemType == "Root")
                    this.SystemPathType = MainSystemPathType.Root;
                else
                    this.SystemPathType = MainSystemPathType.System;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Clone(SystemPath_Model target)
        {
            try
            {
                target.ID = this.ID;
                target.ParentID = this.ParentID;
                target.SystemName = this.SystemName;
                target.System = this.System;
                target.SystemPathType = this.SystemPathType;
                target.Smart3DSystemType = this.Smart3DSystemType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
