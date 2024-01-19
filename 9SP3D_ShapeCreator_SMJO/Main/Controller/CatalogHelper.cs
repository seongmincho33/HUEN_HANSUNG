using Ingr.SP3D.ReferenceData.Middle;
using Main.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    public class CatalogHelper
    {
        private UserSetting UserSetting { get; set; }

        public CatalogHelper(UserSetting userSetting)
        {
            this.UserSetting = userSetting;
        }

        public void GetPartsFromCatalog()
        {
            try
            {
                Ingr.SP3D.ReferenceData.Middle.Services.CatalogEquipmentHelper catalogEquipmentHelper = new Ingr.SP3D.ReferenceData.Middle.Services.CatalogEquipmentHelper();
                
                PartClass partClass = catalogEquipmentHelper.GetPartClass(UserSetting.PartClassName) as PartClass;

                UserSetting.PartList.Clear();

                foreach (Part p in partClass.Parts)
                {
                    //EquipmentPart part = p as EquipmentPart;

                    //var partProperties = part.GetAllProperties();

                    //var ss = part.GetPropertyValue(string sInterfaceName, string sPropertyName);

                    //Ingr.SP3D.Common.Middle.Services.InterfaceInformation interfaceInformation = new Ingr.SP3D.Common.Middle.Services.InterfaceInformation();
                    //part.SetPropertyValue();

                    UserSetting.PartList.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
