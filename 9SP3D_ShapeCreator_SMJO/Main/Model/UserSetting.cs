using Ingr.SP3D.Common.Middle;
using Ingr.SP3D.ReferenceData.Middle;
using Main.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class UserSetting
    {
        #region Shape
        public string NewShapeName { get; set; }
        public bool IsManhole { get; set; }
        public bool IsCatchBasin { get; set; }
        public bool IsPipe { get; set; }
        public bool IsOpenDitch { get; set; }
        #endregion

        #region System
        public string NewSystemName { get; set; }
        public bool IsStructureSystem { get; set; }
        public bool IsPipingSystem { get; set; }
        public bool IsPipeLineSystem { get; set; }
        public bool IsPipeRunSystem { get; set; }
        #endregion

        #region User Selected Item
        /// <summary>
        /// 이 프로그램의 Tree에서 선택한 시스템
        /// </summary>
        public SystemPath_Model UserSelectedSystemPathModel { get; set; }

        /// <summary>
        /// SP3D에서 사용자가 선택한 객체. 이 프로그램의 트리뷰에서 선택한 객체가 아님.
        /// </summary>
        public BusinessObject UserSelectedBusinessObject { get; set; }

        /// <summary>
        /// 이 프로그램에서 카탈로그 메뉴의 트리뷰에서 선택한 파트 객체.
        /// </summary>
        public Part UserSelectedCatalogPart { get; set; }
        #endregion

        #region Pipe
        public PipePosition PipePosition { get; set; }
        #endregion

        #region Manhole
        public ManholeDrawInfo ManholeDrawInfo { get; set; }
        #endregion

        #region Trench
        public DataTable TrenchSketch3DPathTable { get; set; }

        public double TrenchU_EndInvertElevation { get; set; }

        public double TrenchV_Angle_Radian { get; set; }

        public double TrenchBottomWidth { get; set; }

        public double TrenchInsideDepth { get; set; }

        public double TrenchWallThickness { get; set; }

        public double TrenchFootingThickness { get; set; }

        public TrenchDrawType TrenchDrawType { get; set; }
        #endregion

        #region Catalog
        public string PartName { get; set; }
        public string PartClassName { get; set; }
        public List<Part> PartList { get; set; }
        #endregion

        public UserSetting()
        {
            try
            {
                this.SetDefault();
            }
            catch (Exception ex)
            {
            }
        }

        public void SetDefault()
        {
            IsManhole = false;
            IsCatchBasin = false;
            IsPipe = false;
            IsOpenDitch = false;
            IsStructureSystem = false;
            IsPipingSystem = false;
            IsPipeLineSystem = false;
            IsPipeRunSystem = false;
            UserSelectedSystemPathModel = new SystemPath_Model();
            NewSystemName = "";
            NewShapeName = "";

            PipePosition = new PipePosition();

            ManholeDrawInfo = new ManholeDrawInfo();

            PartName = "";
            PartClassName = "";
            PartList = new List<Part>();

            TrenchDrawType = TrenchDrawType.Ditch_U;
            TrenchBottomWidth = 0.0;
            TrenchInsideDepth = 0.0;
            TrenchWallThickness = 0.0;
            TrenchFootingThickness = 0.0;
            TrenchV_Angle_Radian = 0.0;
            TrenchSketch3DPathTable = new DataTable();
            TrenchSketch3DPathTable.Columns.Add("PosX", typeof(double));
            TrenchSketch3DPathTable.Columns.Add("PosY", typeof(double));
            TrenchSketch3DPathTable.Columns.Add("PosZ", typeof(double));

            if(Ingr.SP3D.Common.Client.Services.ClientServiceProvider.SelectSet != null)
            {
                UserSelectedBusinessObject = Ingr.SP3D.Common.Client.Services.ClientServiceProvider.SelectSet.SelectedObjects[0];
            }
            else
            {
                UserSelectedBusinessObject = null;
            }
        }
    }
}
