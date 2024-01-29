using Ingr.SP3D.Common.Middle.Services.Hidden;
using Main.Model;
using SP3DPIA.EquipmentHelpers;
using SP3DPIA.PipeEntities;
using SP3DPIA.SysHlpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    public class SymbolListFinder
    {
        UserSetting UserSetting { get; set; }

        public SymbolListFinder(UserSetting userSetting)
        {
            UserSetting = userSetting;
        }

        public List<SymbolModel> GetPipeSymbolList()
        {
            try
            {
                if (UserSetting.UserSelectedSystemPathModel.System != null)
                {
                    List<SymbolModel> symbolModels = new List<SymbolModel>();

                    var selectedSystem = UserSetting.UserSelectedSystemPathModel.System;

                    var val = COMConverters.ConvertBOToCOMBO(selectedSystem);

                    if (val is IJAllowableSpecs)
                    {
                        IJAllowableSpecs val2 = val as IJAllowableSpecs;

                        #region Pipe
                        SP3DPIA.PipeEntities.IJDTargetObjectCol allowableSpecsPipes = (SP3DPIA.PipeEntities.IJDTargetObjectCol)val2.GetAllowableSpecs();
                        for (int i = 1; i <= allowableSpecsPipes.Count; i++)
                        {
                            IJDPipeSpec val3 = null;
                            try
                            {
                                val3 = (IJDPipeSpec)allowableSpecsPipes.Item[i];
                                Array NPD;
                                Array NPDUnitType;
                                Array ppadEquivalentNPD;
                                Array ppastrEquivalentNPDUnits;
                                val3.GetAllowableNPDs(out NPD, out NPDUnitType, out ppadEquivalentNPD, out ppastrEquivalentNPDUnits);
                            }
                            catch
                            {
                            }

                            if (val3 != null)
                            {
                                symbolModels.Add(
                                     new SymbolModel()
                                     {
                                         Symbol = val3
                                          ,
                                         Name = val3.SpecName
                                     }
                                );


                                //if (val2 is GSCADRouteUtils.IJDSymbol)
                                //{
                                //    GSCADRouteUtils.IJDSymbol symbol = val2 as GSCADRouteUtils.IJDSymbol;
                                //    symbolModels.Add(
                                //        new SymbolModel()
                                //        {
                                //            Symbol = symbol
                                //       ,
                                //            Name = symbol.IJDSymbolDefinition[0].Name
                                //       ,
                                //            ProgID = symbol.IJDSymbolDefinition[0].ProgID
                                //       ,
                                //            CodeBase = symbol.IJDSymbolDefinition[0].CodeBase
                                //       ,
                                //            Version = symbol.IJDSymbolDefinition[0].Version
                                //        }
                                //    );
                                //}
                            }
                        }
                        #endregion

                        return symbolModels;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public List<SymbolModel> GetCivilSymbolList()
        {
            try
            {
                if (UserSetting.UserSelectedSystemPathModel.System != null)
                {
                    List<SymbolModel> symbolModels = new List<SymbolModel>();

                    var selectedSystem = UserSetting.UserSelectedSystemPathModel.System;

                    var val = COMConverters.ConvertBOToCOMBO(selectedSystem);

                    if (val is IJAllowableSpecs)
                    {
                        IJAllowableSpecs val2 = val as IJAllowableSpecs;

                        #region Civil
                        SP3DPIA.CivilEntities.IJDTargetObjectCol allowableSpecsCivil = (SP3DPIA.CivilEntities.IJDTargetObjectCol)val2.GetAllowableSpecs();
                        for (int i = 1; i <= allowableSpecsCivil.Count; i++)
                        {
                            IJEquipment val3 = null;
                            try
                            {
                                val3 = (IJEquipment)allowableSpecsCivil.Item[i];
                            }
                            catch
                            {
                            }

                            if (val3 != null)
                            {
                                symbolModels.Add(
                                     new SymbolModel()
                                     {
                                         Symbol = val3
                                          ,
                                         Name = val3.Description
                                     }
                                );
                            }
                        }
                        #endregion

                        return symbolModels;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public List<SymbolModel> GetEquipmentSymbolList()
        {
            try
            {
                if (UserSetting.UserSelectedSystemPathModel.System != null)
                {
                    List<SymbolModel> symbolModels = new List<SymbolModel>();

                    var selectedSystem = UserSetting.UserSelectedSystemPathModel.System;

                    var val = COMConverters.ConvertBOToCOMBO(selectedSystem);

                    if (val is IJAllowableSpecs)
                    {
                        IJAllowableSpecs val2 = val as IJAllowableSpecs;

                        #region Equipment
                        SP3DPIA.EquipmentHelpers.IJDTargetObjectCol allowableSpecsEquipment = (SP3DPIA.EquipmentHelpers.IJDTargetObjectCol)val2.GetAllowableSpecs();
                        for (int i = 1; i <= allowableSpecsEquipment.Count; i++)
                        {
                            IJEquipment val3 = null;
                            try
                            {
                                val3 = (IJEquipment)allowableSpecsEquipment.Item[i];
                            }
                            catch
                            {
                            }

                            if (val3 != null)
                            {
                                symbolModels.Add(
                                     new SymbolModel()
                                     {
                                         Symbol = val3
                                          ,
                                         Name = val3.Description
                                     }
                                );
                            }
                        }
                        #endregion

                        return symbolModels;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
