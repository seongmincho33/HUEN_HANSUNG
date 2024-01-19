using Ingr.SP3D.Common.Middle;
using Ingr.SP3D.Common.Middle.Services.Hidden;
using Ingr.SP3D.Content.Structure;
using Ingr.SP3D.ReferenceData.Middle;
using Ingr.SP3D.ReferenceData.Middle.Services;
using Ingr.SP3D.Route.Exceptions;
using Ingr.SP3D.Route.Middle;
using Ingr.SP3D.Support.Middle;
using Main.Controller;
using Main.Model;
using Main.SP3DHelper;
using SP3DPIA.PipeEntities;
using SP3DPIA.SysHlpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main.View
{
    public partial class MainForm : Form
    {
        private Controller.Controller Controller { get; set; }

        public MainForm()
        {
            InitializeComponent();

            try
            {
                this.Controller = new Controller.Controller();

                this.btn_CreateShape.Click += Btn_CreateShape_Click;
                this.btn_CreateSystem.Click += Btn_CreateSystem_Click;

                this.txt_NewSystemName.TextChanged += Txt_NewSystemName_TextChanged;
                this.txt_NewShapeName.TextChanged += Txt_NewShapeName_TextChanged;

                this.radio_StructureSystem.CheckedChanged += SystemCheckedCheckedChanged;
                this.radio_PipingSystem.CheckedChanged += SystemCheckedCheckedChanged;
                this.radio_PipeLineSystem.CheckedChanged += SystemCheckedCheckedChanged;
                this.radio_PipeRunSystem.CheckedChanged += SystemCheckedCheckedChanged;

                this.radio_CatchBasin.CheckedChanged += ShapeCheckedChanged;
                this.radio_Manhole.CheckedChanged += ShapeCheckedChanged;
                this.radio_Pipe.CheckedChanged += ShapeCheckedChanged;
                this.radio_OpenDitch.CheckedChanged += ShapeCheckedChanged;

                this.radio_DitchV.CheckedChanged += Radio_Ditch_CheckedChanged;
                this.radio_DitchU.CheckedChanged += Radio_Ditch_CheckedChanged;

                PopulateTreeView();
                this.treeView_SystemPath.AfterSelect += TreeView_SystemPath_AfterSelect;

                this.txt_PipePos1X.TextChanged += Txt_PipePos_TextChanged;
                this.txt_PipePos1Y.TextChanged += Txt_PipePos_TextChanged;
                this.txt_PipePos1Z.TextChanged += Txt_PipePos_TextChanged;
                this.txt_PipePos2X.TextChanged += Txt_PipePos_TextChanged;
                this.txt_PipePos2Y.TextChanged += Txt_PipePos_TextChanged;
                this.txt_PipePos2Z.TextChanged += Txt_PipePos_TextChanged;

                this.txt_ManholePosX.TextChanged += Txt_ManholePos_TextChanged;
                this.txt_ManholePosY.TextChanged += Txt_ManholePos_TextChanged;
                this.txt_ManholePosZ.TextChanged += Txt_ManholePos_TextChanged;
                this.txt_ManholePartName.TextChanged += Txt_ManholePartClassName_TextChanged;
                this.txt_ManholeBaseHeight.TextChanged += Txt_ManholeParameter_TextChanged;
                this.txt_ManholeConeHeight.TextChanged += Txt_ManholeParameter_TextChanged;
                this.txt_ManholeBaseDiameter.TextChanged += Txt_ManholeParameter_TextChanged;
                this.txt_ManholeEccentricConeTopDiameter.TextChanged += Txt_ManholeParameter_TextChanged;
                this.txt_BaseBottomToNozzleHeight.TextChanged += Txt_ManholeParameter_TextChanged;

                this.btn_SymbolList.Click += Btn_SymbolList_Click;

                this.btn_AddOpenDichPosToList.Click += Btn_AddOpenDichPostoList_Click;
                this.btn_ResetGridOpenDictch.Click += Btn_ResetGridOpenDictch_Click;
                this.Grid_OpenDitchPos.DataSource = Controller.UserSetting.TrenchSketch3DPathTable;

                this.btn_InspectSelectedBO.Click += SelectedBussinessObejctInspect;
                this.btn_TestCode.Click += Btn_TestCode_Click;

                this.txt_TrenchEndInvertElevation.TextChanged += Txt_EndInvertElevation_TextChanged;
                this.txt_TrenchAngleV.TextChanged += Txt_AngleV_TextChanged;
                this.txt_TrenchBottomWidth.TextChanged += Txt_TrenchBottomWidth_TextChanged;
                this.txt_TrenchInsedDepth.TextChanged += Txt_TrenchInsedDepth_TextChanged;
                this.txt_TrenchWallThickness.TextChanged += Txt_TrenchWallThickness_TextChanged;
                this.txt_TrenchFootingThickness.TextChanged += Txt_TrenchFootingThickness_TextChanged;

                this.txt_CatalogPartClassName.TextChanged += Txt_CatalogPartClassName_TextChanged;
                this.txt_CatalogPartClassName.TextChanged += Txt_CatalogPartClassName_TextChanged1;
                this.btn_CatalogPartClassSearch.Click += Btn_CatalogPartClassSearch_Click;
                this.treeView_Catalog.AfterSelect += TreeView_Catalog_AfterSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       



        #region TextBox Events
        private void Txt_PipePos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_PipePos1X.Text;
                if (!double.TryParse(inputText, out double pos1X))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText2 = txt_PipePos1Y.Text;
                if (!double.TryParse(inputText2, out double pos1Y))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText3 = txt_PipePos1Z.Text;
                if (!double.TryParse(inputText3, out double pos1Z))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText4 = txt_PipePos2X.Text;
                if (!double.TryParse(inputText4, out double pos2X))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText5 = txt_PipePos2Y.Text;
                if (!double.TryParse(inputText5, out double pos2Y))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText6 = txt_PipePos2Z.Text;
                if (!double.TryParse(inputText6, out double pos2Z))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                PipePosition pipePosition = new PipePosition();
                Model.Position pos1XYZ = new Model.Position(pos1X, pos1Y, pos1Z);
                Model.Position pos2XYZ = new Model.Position(pos2X, pos2Y, pos2Z);
                pipePosition.Position_1 = pos1XYZ;
                pipePosition.Position_2 = pos2XYZ;

                Controller.UserSetting.PipePosition = pipePosition;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        
        }

        private void Txt_NewShapeName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Controller.UserSetting.NewShapeName = this.txt_NewShapeName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_NewSystemName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Controller.UserSetting.NewSystemName = this.txt_NewSystemName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_TrenchBottomWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_TrenchBottomWidth.Text;
                if (!double.TryParse(inputText, out double bottomWidth))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                Controller.UserSetting.TrenchBottomWidth = bottomWidth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_TrenchInsedDepth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_TrenchInsedDepth.Text;
                if (!double.TryParse(inputText, out double insideDepth))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                Controller.UserSetting.TrenchInsideDepth = insideDepth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_TrenchWallThickness_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_TrenchWallThickness.Text;
                if (!double.TryParse(inputText, out double wallThk))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                Controller.UserSetting.TrenchWallThickness = wallThk;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_TrenchFootingThickness_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_TrenchFootingThickness.Text;
                if (!double.TryParse(inputText, out double footingThk))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                Controller.UserSetting.TrenchFootingThickness = footingThk;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_AngleV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_TrenchAngleV.Text;
                if (!double.TryParse(inputText, out double angle))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                
                Controller.UserSetting.TrenchV_Angle_Radian = angle * Math.PI / 180.0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_EndInvertElevation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_TrenchEndInvertElevation.Text;
                if (!double.TryParse(inputText, out double elevation))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                Controller.UserSetting.TrenchU_EndInvertElevation = elevation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_ManholePartClassName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Controller.UserSetting.ManholeDrawInfo.ManholePartName = this.txt_ManholePartName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_ManholePos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_ManholePosX.Text;
                if (!double.TryParse(inputText, out double pos1X))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }
                string inputText2 = txt_ManholePosY.Text;
                if (!double.TryParse(inputText2, out double pos1Y))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText3 = txt_ManholePosZ.Text;
                if (!double.TryParse(inputText3, out double pos1Z))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                Controller.UserSetting.ManholeDrawInfo.ManholePosition = new Model.Position(pos1X, pos1Y, pos1Z);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_ManholeParameter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_ManholeBaseHeight.Text;
                if (!double.TryParse(inputText, out double BH))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText2 = txt_ManholeConeHeight.Text;
                if (!double.TryParse(inputText2, out double CH))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText3 = txt_ManholeBaseDiameter.Text;
                if (!double.TryParse(inputText3, out double BD))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText4 = txt_ManholeEccentricConeTopDiameter.Text;
                if (!double.TryParse(inputText4, out double ECTD))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                string inputText5 = txt_BaseBottomToNozzleHeight.Text;
                if (!double.TryParse(inputText5, out double BBNH))
                {
                    MessageBox.Show("Conversion failed. Please enter a valid number.");
                    return;
                }

                ManholeDrawInfo drawInfo = new ManholeDrawInfo();
                drawInfo.BaseHeight = BH;
                drawInfo.ConeHeight = CH;
                drawInfo.BaseDiameter = BD;
                drawInfo.EccentricConeTopDiameter = ECTD;
                drawInfo.BaseBottomToNozzleHeight = BBNH;
                Controller.UserSetting.ManholeDrawInfo = drawInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_CatalogPartClassName_TextChanged1(object sender, EventArgs e)
        {
            try
            {
                Controller.UserSetting.PartName = this.txt_CatalogPartName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Txt_CatalogPartClassName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Controller.UserSetting.PartClassName = this.txt_CatalogPartClassName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Button Events
        private void Btn_TestCode_Click(object sender, EventArgs e)
        {
            try
            {
                #region 테스트용 변수 (수정 X)
                //"SP3D Tree" 에서 클릭한 BusinessObject
                var businessObject = Controller.UserSetting.UserSelectedBusinessObject;

                //"테스트 프로그램 Tree" 에서 클릭한 System
                var selectedSystem = Controller.UserSetting.UserSelectedSystemPathModel.System;
                #endregion

                #region 테스트 코드 1
                Ingr.SP3D.ReferenceData.Middle.Services.CatalogEquipmentHelper catalogEquipmentHelper = new Ingr.SP3D.ReferenceData.Middle.Services.CatalogEquipmentHelper();

                var pipeSpecs = catalogEquipmentHelper.GetSpecifications(SpecTypes.Piping);

                DataTable dtPipeSpecs = new DataTable();
                dtPipeSpecs.Columns.Add("SPEC_NAME", typeof(string));
                dtPipeSpecs.Columns.Add("DIAMETER", typeof(double));
                dtPipeSpecs.Columns.Add("UNIT", typeof(string));

                foreach (var pipeSpec in pipeSpecs)
                {
                    var comPipe = COMConverters.ConvertBOToCOMBO(pipeSpec);
                    if (comPipe is SP3DPIA.PipeEntities.IJDPipeSpec)
                    {
                        SP3DPIA.PipeEntities.IJDPipeSpec pipe = (SP3DPIA.PipeEntities.IJDPipeSpec)comPipe;

                        try
                        {                            
                            Array NPD;
                            Array NPDUnitType;
                            Array ppadEquivalentNPD;
                            Array ppastrEquivalentNPDUnits;
                            pipe.GetAllowableNPDs(out NPD, out NPDUnitType, out ppadEquivalentNPD, out ppastrEquivalentNPDUnits);

                            for (int i = 0; i<NPD.Length; i++)
                            {
                                dtPipeSpecs.Rows.Add(pipeSpec.DisplayName, NPD.GetValue(i), NPDUnitType.GetValue(i));
                            }

                        }
                        catch
                        {
                        }
                    }
                }

                //Part p = (Part)catalogEquipmentHelper.GetPart(UserSetting.ManholeDrawInfo.ManholePartName);

                //EquipmentPart part = p as EquipmentPart;
                #endregion

                #region 테스트 코드 2
                try
                {
                    if (selectedSystem != null)
                    {
                        List<SymbolModel> symbolModels = new List<SymbolModel>();                       

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

                                }
                            }
                            #endregion
                        }
                      
                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
              
                }
                #endregion

                #region 테스트 코드 3
                
                #endregion

                #region 테스트 코드 4

                #endregion

                #region 테스트 코드 5

                #endregion

                #region 테스트 코드 6

                #endregion

                #region 테스트 코드 7

                #endregion

                #region 테스트 코드 8

                #endregion

                #region 테스트 코드 9

                #endregion

                #region 테스트 코드 10

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_CreateSystem_Click(object sender, EventArgs e)
        {
            try
            {
                AppendToLastSentence(this.richText_Comment, $"\n[Create System] : Start\n");
                this.Controller.CreateSystem();
                this.PopulateTreeView();
                AppendToLastSentence(this.richText_Comment, $"\n[Create System] : End\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_CreateShape_Click(object sender, EventArgs e)
        {
            try
            {
                AppendToLastSentence(this.richText_Comment, $"\n[Create Shape] : Start\n");
                this.Controller.CreateShape();
                this.PopulateTreeView();
                AppendToLastSentence(this.richText_Comment, $"\n[Create Shape] : End\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_SymbolList_Click(object sender, EventArgs e)
        {
            try
            {
                List<SymbolModel> symbolModelList = Controller.GetSymbolList();

                foreach(var symbolModel in symbolModelList)
                {
                    if (symbolModel != null)
                    {
                        AppendToLastSentence(this.richText_Comment, $"\n[Name] : {symbolModel.Name}\n");
                        //AppendToLastSentence(this.richText_Comment, $"\n[ProgID] : {symbolModel.ProgID}\n");
                        //AppendToLastSentence(this.richText_Comment, $"\n[CodeBase] : {symbolModel.CodeBase}\n");
                        //AppendToLastSentence(this.richText_Comment, $"\n[GeomOption] : {symbolModel.GeomOption}\n");
                        //AppendToLastSentence(this.richText_Comment, $"\n[Version] : {symbolModel.Version}\n");
                    }
                    else
                    {
                        MessageBox.Show("No Symbols");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectedBussinessObejctInspect(object sender, EventArgs e)
        {
            try
            {
                CatalogBaseHelper baseHelper = new CatalogBaseHelper();
                baseHelper.GetInsulationMaterials(InsulationMaterialTypes.Piping);

                CatalogStructHelper catalog = new CatalogStructHelper();
                catalog.GetInsulationMaterials(InsulationMaterialTypes.Piping);

                // 아님
                //var ab = catalog.GetRuleDefinition("NPD");
                //var ac = catalog.GetRuleDefinitionNames("NPD");
                //var  a = catalog.GetRuleDefinitions("NPD");
                //foreach (var pipeSpec in catalog.GetSpecifications(SpecTypes.Piping))
                //{
                //    foreach (Ingr.SP3D.Common.Middle.PropertyValue prop in pipeSpec.GetAllProperties())
                //    {

                //    }
                //}

                var businessObject = Controller.UserSetting.UserSelectedBusinessObject;
                //Ingr.SP3D.Route.Middle.PipeRun p = businessObject as Ingr.SP3D.Route.Middle.PipeRun;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_ResetGridOpenDictch_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.UserSetting.TrenchSketch3DPathTable.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_AddOpenDichPostoList_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_PosOpenDitchX.Text;
                if (!double.TryParse(inputText, out double posX))
                {
                    MessageBox.Show("Please enter a valid number.");
                    return;
                }

                string inputText2 = txt_PosOpenDitchY.Text;
                if (!double.TryParse(inputText2, out double posY))
                {
                    MessageBox.Show("Please enter a valid number.");
                    return;
                }

                string inputText3 = txt_PosOpenDitchZ.Text;
                if (!double.TryParse(inputText3, out double posZ))
                {
                    MessageBox.Show("Please enter a valid number.");
                    return;
                }

                DataRow newRow = Controller.UserSetting.TrenchSketch3DPathTable.NewRow();
                newRow["PosX"] = posX;
                newRow["PosY"] = posY;
                newRow["PosZ"] = posZ;
                Controller.UserSetting.TrenchSketch3DPathTable.Rows.Add(newRow);
                Controller.UserSetting.TrenchSketch3DPathTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_CatalogPartClassSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView_Catalog.Nodes != null)
                    treeView_Catalog.Nodes.Clear();
                Controller.GetCatalogs();

                Dictionary<string, TreeNode> nodeDictionary = new Dictionary<string, TreeNode>();

                foreach (var item in Controller.UserSetting.PartList)
                {
                    if (item != null)
                    {
                        TreeNode node = new TreeNode(item.ClassInfo.Name);
                        node.Tag = item;
                        treeView_Catalog.Nodes.Add(node);
                        //if (!nodeDictionary.ContainsKey(item.ID))
                        //{
                        //    nodeDictionary.Add(item.ID, node);

                        //    if (item.ParentID == null || item.ParentID == "0" || item.ParentID == "")
                        //    {
                        //        treeView_SystemPath.Nodes.Add(node);
                        //    }
                        //    else
                        //    {
                        //        if (nodeDictionary.ContainsKey(item.ParentID))
                        //        {
                        //            nodeDictionary[item.ParentID].Nodes.Add(node);
                        //        }
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Radio Events
        private void SystemCheckedCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.radio_StructureSystem.Checked)
                {
                    Controller.UserSetting.IsStructureSystem = true;
                }
                else if (this.radio_PipingSystem.Checked)
                {
                    Controller.UserSetting.IsPipingSystem = true;
                }
                else if (this.radio_PipeLineSystem.Checked)
                {
                    Controller.UserSetting.IsPipeLineSystem = true;
                }
                else if (this.radio_PipeRunSystem.Checked)
                {
                    Controller.UserSetting.IsPipeRunSystem = true;
                }

                if (!this.radio_StructureSystem.Checked)
                {
                    Controller.UserSetting.IsStructureSystem = false;
                }
                if (!this.radio_PipingSystem.Checked)
                {
                    Controller.UserSetting.IsPipingSystem = false;
                }
                if (!this.radio_PipeLineSystem.Checked)
                {
                    Controller.UserSetting.IsPipeLineSystem = false;
                }
                if (!this.radio_PipeRunSystem.Checked)
                {
                    Controller.UserSetting.IsPipeRunSystem = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShapeCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.radio_CatchBasin.Checked)
                {
                    Controller.UserSetting.IsCatchBasin = true;
                }
                else if (this.radio_Manhole.Checked)
                {
                    Controller.UserSetting.IsManhole = true;
                }
                else if (this.radio_Pipe.Checked)
                {
                    Controller.UserSetting.IsPipe = true;
                }
                else if (this.radio_OpenDitch.Checked)
                {
                    Controller.UserSetting.IsOpenDitch = true;
                }

                if (!this.radio_CatchBasin.Checked)
                {
                    Controller.UserSetting.IsCatchBasin = false;
                }
                if (!this.radio_Manhole.Checked)
                {
                    Controller.UserSetting.IsManhole = false;
                }
                if (!this.radio_Pipe.Checked)
                {
                    Controller.UserSetting.IsPipe = false;
                }
                if (!this.radio_OpenDitch.Checked)
                {
                    Controller.UserSetting.IsOpenDitch = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Radio_Ditch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.radio_DitchU.Checked)
                {
                    Controller.UserSetting.TrenchDrawType = TrenchDrawType.Ditch_U;
                }
                else if (this.radio_DitchV.Checked)
                {
                    Controller.UserSetting.TrenchDrawType = TrenchDrawType.Ditch_V;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Tree Events
        private void PopulateTreeView()
        {
            try
            {
                if (treeView_SystemPath.Nodes != null)
                    treeView_SystemPath.Nodes.Clear();

                Dictionary<string, TreeNode> nodeDictionary = new Dictionary<string, TreeNode>();

                foreach (var item in this.Controller.AllSystemPath)
                {
                    if (item != null)
                    {
                        TreeNode node = new TreeNode(item.SystemName);
                        node.Tag = item;

                        if (!nodeDictionary.ContainsKey(item.ID))
                        {
                            nodeDictionary.Add(item.ID, node);

                            if (item.ParentID == null || item.ParentID == "0" || item.ParentID == "")
                            {
                                treeView_SystemPath.Nodes.Add(node);
                            }
                            else
                            {
                                if (nodeDictionary.ContainsKey(item.ParentID))
                                {
                                    nodeDictionary[item.ParentID].Nodes.Add(node);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TreeView_SystemPath_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Tag != null)
                {
                    SystemPath_Model selectedData = (SystemPath_Model)e.Node.Tag;
                    selectedData.Clone(Controller.UserSetting.UserSelectedSystemPathModel);
                }

                AppendToLastSentence(this.richText_Comment, $"\n[Selected Node] : {Controller.UserSetting.UserSelectedSystemPathModel.SystemName}\n");

                if(Controller.UserSetting.UserSelectedSystemPathModel.System is PipeRun)
                {
                    var pipeRun = Controller.UserSetting.UserSelectedSystemPathModel.System as PipeRun;
                    AppendToLastSentence(this.richText_Comment, $"\n[Nominal Diameter Size] : {pipeRun.NPD.Size}\n");
                    AppendToLastSentence(this.richText_Comment, $"\n[Nominal Diameter Units] : {pipeRun.NPD.Units}\n");
                    foreach (var part in pipeRun.Parts)
                    {
                        foreach (var feature in part.Features)
                        {
                            if (feature is PipeStraightFeature)
                            {   
                                AppendToLastSentence(this.richText_Comment, $"\n[StartLocation X] : {feature.StartLocation.X}\n");
                                AppendToLastSentence(this.richText_Comment, $"\n[StartLocation Y] : {feature.StartLocation.Y}\n");
                                AppendToLastSentence(this.richText_Comment, $"\n[StartLocation Z] : {feature.StartLocation.Z}\n");
                                AppendToLastSentence(this.richText_Comment, $"\n[EndLocation X] : {feature.EndLocation.X}\n");
                                AppendToLastSentence(this.richText_Comment, $"\n[EndLocation Y] : {feature.EndLocation.Y}\n");
                                AppendToLastSentence(this.richText_Comment, $"\n[EndLocation Z] : {feature.EndLocation.Z}\n");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TreeView_Catalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Tag != null)
                {
                    Part selectedData = (Part)e.Node.Tag;
                    Controller.UserSetting.UserSelectedCatalogPart = selectedData;
                }

                AppendToLastSentence(this.richText_Comment, $"\n[Selected Part] : {Controller.UserSetting.UserSelectedCatalogPart.ClassInfo.Name}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void AppendToLastSentence(System.Windows.Forms.RichTextBox richTextBox, string newText)
        {
            try
            {
                // Get the current text from the RichTextBox
                string currentText = richTextBox.Text;

                // Find the position of the last sentence
                int lastSentenceIndex = richTextBox.TextLength - 1;

                // If there's no sentence ending (e.g., no '.', or text is empty), append to the whole text
                if (lastSentenceIndex <= 0)
                {
                    richTextBox.AppendText(newText);
                }
                else
                {
                    // Append the new text to the last sentence
                    string modifiedText = currentText.Substring(0, lastSentenceIndex) + "\n\n" + newText;

                    // Update the RichTextBox with the modified text
                    richTextBox.Text = modifiedText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
