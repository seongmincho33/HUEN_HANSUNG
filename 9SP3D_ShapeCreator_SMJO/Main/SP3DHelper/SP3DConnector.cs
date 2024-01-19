using Ingr.SP3D.Common.Middle.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.SP3DHelper
{
    /// <summary>
    /// S3D와 연결해주는 클래스
    /// </summary>
    public static class SP3DConnector
    {
        public static SiteManager siteMgr { get; set; }
        public static Site site { get; set; }
        public static Plant plant { get; set; }
        public static Ingr.SP3D.Common.Middle.Services.Model model { get; set; }
        public static SP3DConnection conn { get; set; }

        public static List<string> CheckSystems = new List<string>();

        public static bool ConnectToSP3DSite()
        {
            try
            {
                //-----------------------------------------------------------------------------------------------
                // Get Site Manager
                //-----------------------------------------------------------------------------------------------
                siteMgr = MiddleServiceProvider.SiteMgr;
                plant = MiddleServiceProvider.SiteMgr.ActiveSite.ActivePlant;

                //-----------------------------------------------------------------------------------------------
                // 연결정보를 생성할 수 없으면 오류 발생,
                // ex) Site 연결 정보 없음.
                //     SP3D 라이센스 정보 없음.
                //-----------------------------------------------------------------------------------------------
                try { MiddleServiceProvider.SiteMgr.ConnectSite(); /* connect to site*/ }
                catch (Exception ex) { MessageBox.Show("SP3D Middle Service Site Manager Connection Site Error.\n\n" + ex.Message); }

                //-----------------------------------------------------------------------------------------------
                // Get the first site (which is the only site)
                //-----------------------------------------------------------------------------------------------
                site = siteMgr.Sites[0];

                model = plant.PlantModel;
                conn = MiddleServiceProvider.SiteMgr.ActiveSite.ActivePlant.PlantModel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConnectionHelper Error");
            }

            return true;
        }


        static SP3DConnector()
        {
            CheckSystems.Clear();
            CheckSystems.Add(S3DSystemType.GenericSystem.ToString());
            CheckSystems.Add(S3DSystemType.AreaSystem.ToString());
            CheckSystems.Add(S3DSystemType.ConduitSystem.ToString());
            CheckSystems.Add(S3DSystemType.ElectricalSystem.ToString());
            CheckSystems.Add(S3DSystemType.EquipmentSystem.ToString());
            CheckSystems.Add(S3DSystemType.DuctingSystem.ToString());
            CheckSystems.Add(S3DSystemType.Pipeline.ToString());
            CheckSystems.Add(S3DSystemType.PipeRun.ToString());
            CheckSystems.Add(S3DSystemType.PipingSystem.ToString());
            CheckSystems.Add(S3DSystemType.StructuralSystem.ToString());
            CheckSystems.Add(S3DSystemType.UnitSystem.ToString());
        }
        
        public enum S3DSystemType
        {
            AreaSystem,
            ConduitSystem,
            ElectricalSystem,
            EquipmentSystem,
            GenericSystem,
            DuctingSystem,
            Pipeline,
            PipeRun,
            PipingSystem,
            StructuralSystem,
            UnitSystem
        }
    } 
}
