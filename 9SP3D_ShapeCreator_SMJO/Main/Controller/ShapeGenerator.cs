using Ingr.SP3D.Civil.Middle;
using Ingr.SP3D.Common.Middle;
using Ingr.SP3D.Common.Middle.Services;
using Ingr.SP3D.Common.Middle.Services.Hidden;
using Ingr.SP3D.ReferenceData.Middle;
using Ingr.SP3D.ReferenceData.Middle.Services;
using Ingr.SP3D.Systems.Middle;
using Main.Model;
using Main.SP3DHelper;
using SP3DPIA.CivilEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    public class ShapeGenerator
    {
        private UserSetting UserSetting { get; set; }

        public ShapeGenerator(UserSetting userSetting)
        {
            this.UserSetting = userSetting;
        }

        /// <summary>
        /// 개발중
        /// </summary>
        [Obsolete("This method is under development.")]
        public void CreateManhole()
        {
            try
            {
                Ingr.SP3D.ReferenceData.Middle.Services.CatalogEquipmentHelper catalogEquipmentHelper = new Ingr.SP3D.ReferenceData.Middle.Services.CatalogEquipmentHelper();

                Part p = (Part)catalogEquipmentHelper.GetPart(UserSetting.ManholeDrawInfo.ManholePartName);

                EquipmentPart part = p as EquipmentPart;
                var partProperties = part.GetAllProperties();
                foreach (var partProperty in partProperties)
                {
                    _ = partProperty.PropertyInfo.InterfaceInfo.Name;
                    _ = partProperty.PropertyInfo.Name;
                    switch (partProperty.PropertyInfo.DisplayName)
                    {
                        case "Base Height":
                            part.SetPropertyValue(UserSetting.ManholeDrawInfo.BaseHeight, partProperty.PropertyInfo);                          
                            break;
                        case "Cone Height":
                            part.SetPropertyValue(UserSetting.ManholeDrawInfo.ConeHeight, partProperty.PropertyInfo);
                            break;
                        case "Base Diameter":
                            part.SetPropertyValue(UserSetting.ManholeDrawInfo.BaseDiameter, partProperty.PropertyInfo);
                            break;
                        case "Eccentric Cone Top Diameter":
                            part.SetPropertyValue(UserSetting.ManholeDrawInfo.EccentricConeTopDiameter, partProperty.PropertyInfo);
                            break;
                        case "Base Bottom to Nozzle Height":
                            part.SetPropertyValue(UserSetting.ManholeDrawInfo.BaseBottomToNozzleHeight, partProperty.PropertyInfo);
                            break;
                    }                  
                }

                Ingr.SP3D.Equipment.Middle.Equipment equipment = new Ingr.SP3D.Equipment.Middle.Equipment(part, UserSetting.UserSelectedSystemPathModel.System);
                equipment.SetUserDefinedName(UserSetting.NewSystemName);
                equipment.Origin = new Ingr.SP3D.Common.Middle.Position()
                {
                    X = UserSetting.ManholeDrawInfo.ManholePosition.X
                 ,
                    Y = UserSetting.ManholeDrawInfo.ManholePosition.Y
                 ,
                    Z = UserSetting.ManholeDrawInfo.ManholePosition.Z
                };
                equipment.SetUserDefinedName(UserSetting.NewSystemName);
                Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);

                //PartClass partClass = catalogEquipmentHelper.GetPartClass(UserSetting.PartClassName) as PartClass;

                //foreach (Part p in partClass.Parts)
                //{
                //    EquipmentPart part = p as EquipmentPart;

                //    var partProperties = part.GetAllProperties();

                //    //var ss = part.GetPropertyValue(string sInterfaceName, string sPropertyName);

                //    //Ingr.SP3D.Common.Middle.Services.InterfaceInformation interfaceInformation = new Ingr.SP3D.Common.Middle.Services.InterfaceInformation();
                //    //part.SetPropertyValue();
                //    Ingr.SP3D.Equipment.Middle.Equipment equipment = new Ingr.SP3D.Equipment.Middle.Equipment(part, UserSetting.UserSelectedSystemPathModel.System);
                //    equipment.SetUserDefinedName(UserSetting.NewSystemName);
                //    equipment.Origin = new Ingr.SP3D.Common.Middle.Position()
                //    {
                //        X = UserSetting.ManholePosition.X
                //     ,
                //        Y = UserSetting.ManholePosition.Y
                //     ,
                //        Z = UserSetting.ManholePosition.Z
                //    };

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 개발중
        /// </summary>
        [Obsolete("This method is under development.")]
        public void CreateCatchBasin()
        {
            try
            {
                

                //Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 개발중
        /// </summary>
        [Obsolete("This method is under development.")]
        public void CreatePipe()
        {
            try
            {
                //Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void CreateOpenDitch()
        {
            try
            {
                #region Trench Path
                Sketch3D sk3d = new Sketch3D(SP3DConnector.model);

                Collection<SketchPoint> DrawSketchPoints = new Collection<SketchPoint>();

                List<SketchPoint> tmpList = new List<SketchPoint>();


                for (int i = 0; i < UserSetting.TrenchSketch3DPathTable.Rows.Count; i++)
                {
                    tmpList.Add(new SketchPoint(
                        (double)UserSetting.TrenchSketch3DPathTable.Rows[i]["PosX"]
                        , (double)UserSetting.TrenchSketch3DPathTable.Rows[i]["PosY"]
                        , (double)UserSetting.TrenchSketch3DPathTable.Rows[i]["PosZ"])
                    );
                }

                for (int i = 0; i < tmpList.Count - 1; i++)
                {
                    tmpList[i].CreateLineFeature(tmpList[i + 1]);
                }

                //if (tmpList.Count > 2)
                //{
                //    for (int i = 1; i < tmpList.Count - 1; i++)
                //    {
                //        tmpList[i].CreateChamferFeature(100.0);
                //        tmpList[i].CreateBendFeature(100.0);
                //    }
                //}

                foreach (var item in tmpList)
                {
                    DrawSketchPoints.Add(item);
                }

                sk3d.SetSketchPoints(DrawSketchPoints);
                #endregion

                #region Trench Parameter
                CatalogStructHelper catalogStructHelper = new CatalogStructHelper();

                string str_crossSection = "";
                string str_trenchRunType = "";
                if (UserSetting.TrenchDrawType == TrenchDrawType.Ditch_U)
                {
                    str_crossSection = "U";
                    str_trenchRunType = "Ditch_U";
                }
                else if (UserSetting.TrenchDrawType == TrenchDrawType.Ditch_V)
                {
                    str_crossSection = "V";
                    str_trenchRunType = "Ditch_V";
                }

                CrossSection crossSection = catalogStructHelper.GetCrossSectionStandard("TrenchCrossSections").GetCrossSections(str_crossSection)[0];
                var crossSectionProperties = crossSection.GetAllProperties();

                if (UserSetting.TrenchDrawType == TrenchDrawType.Ditch_U)
                {
                    foreach (var crossSectionProperty in crossSectionProperties)
                    {                                               
                        switch (crossSectionProperty.PropertyInfo.DisplayName)
                        {
                            case "Wall Thickness":
                                crossSection.SetPropertyValue(UserSetting.TrenchWallThickness, crossSectionProperty.PropertyInfo);
                                break;
                            case "Footing Thickness":
                                crossSection.SetPropertyValue(UserSetting.TrenchFootingThickness, crossSectionProperty.PropertyInfo);
                                break;
                        }
                    }
                }
                else if (UserSetting.TrenchDrawType == TrenchDrawType.Ditch_V)
                {
                    foreach (var crossSectionProperty in crossSectionProperties)
                    {
                        switch (crossSectionProperty.PropertyInfo.DisplayName)
                        {
                            case "Wall Thickness":
                                crossSection.SetPropertyValue(UserSetting.TrenchWallThickness, crossSectionProperty.PropertyInfo);
                                break;
                            case "Footing Thickness":
                                crossSection.SetPropertyValue(UserSetting.TrenchFootingThickness, crossSectionProperty.PropertyInfo);
                                break;
                            case "Inside Angle":
                                crossSection.SetPropertyValue(UserSetting.TrenchV_Angle_Radian, crossSectionProperty.PropertyInfo);
                                break;
                        }
                    }
                }

                TrenchRunType trenchRunType = catalogStructHelper.GetTrenchRunType(str_trenchRunType);
                TrenchRunPlacementInputs trenchRunPlacementInputs = new TrenchRunPlacementInputs(trenchRunType, crossSection, (int)TrenchRunCardinalPoints.Top_Center, (int)PlacementMethods.Define_Start_Depth_Bottom_Slope_is_Parallel_to_Top_Slope);
                #endregion

                #region Trench Create (Run)
                Ingr.SP3D.Civil.Middle.TrenchRun trenchRun = new Ingr.SP3D.Civil.Middle.TrenchRun((ISystem)UserSetting.UserSelectedSystemPathModel.System, sk3d, trenchRunPlacementInputs);

                trenchRun.SetInsideLeftWidth(UserSetting.TrenchBottomWidth / 2, true);
                trenchRun.SetInsideRightWidth(UserSetting.TrenchBottomWidth / 2, true);
                trenchRun.InsideDepth = UserSetting.TrenchInsideDepth;                

                if (UserSetting.TrenchDrawType == TrenchDrawType.Ditch_U)
                {
                    trenchRun.PlacementMethod = (int)PlacementMethods.Define_Start_Depth_and_End_Invert_Elevation;
                    trenchRun.EndInvertElevation = UserSetting.TrenchU_EndInvertElevation;
                }               

                Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);

                UserSetting.TrenchSketch3DPathTable.Clear();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
