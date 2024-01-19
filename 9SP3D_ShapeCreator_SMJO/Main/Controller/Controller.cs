using Ingr.SP3D.Common.Middle.Services.Hidden;
using Ingr.SP3D.ReferenceData.Middle;
using Ingr.SP3D.Systems.Middle;
using Main.Model;
using Main.SP3DHelper;
using SP3DPIA.EquipmentHelpers;
using SP3DPIA.PipeEntities;
using SP3DPIA.SysHlpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    /// <summary>
    /// Controls Facade
    /// </summary>
    public class Controller
    {
        public List<SystemPath_Model> AllSystemPath { get; set; }

        public UserSetting UserSetting { get; set; }

        public Controller()
        {
            try
            {
                this.UserSetting = new UserSetting();
                RefreshAllSystemPath();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region 중요 Public 컨트롤
        /// <summary>
        /// 시스템 생성
        /// </summary>
        public void CreateSystem()
        {
            try
            {
                SystemGenerator generator = new SystemGenerator(this.UserSetting);
                if (UserSetting.IsStructureSystem)
                {
                    generator.CreateStructureSystem();
                }
                else if (UserSetting.IsPipingSystem)
                {
                    generator.CreatePipingSystem();
                }
                else if (UserSetting.IsPipeLineSystem)
                {
                    generator.CreatePipeLineSystem();
                }
                else if (UserSetting.IsPipeRunSystem)
                {
                    generator.CreatePipeRunSystem();
                }

                RefreshAllSystemPath();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 도형 생성 Pipe는 제외
        /// </summary>
        public void CreateShape()
        {
            try
            {
                ShapeGenerator generator = new ShapeGenerator(this.UserSetting);
                if(UserSetting.IsManhole)
                {
                    generator.CreateManhole();
                }
                else if(UserSetting.IsCatchBasin)
                {
                    generator.CreateCatchBasin();
                }
                else if (UserSetting.IsPipe)
                {
                    generator.CreatePipe();
                }
                else if (UserSetting.IsOpenDitch)
                {
                    generator.CreateOpenDitch();
                }

                RefreshAllSystemPath();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 선택한 시스템에서 심볼리스트를 가져오기
        /// </summary>
        /// <returns>심볼 모델. 프로퍼티로 심볼 자신이 있음.</returns>
        public List<SymbolModel> GetSymbolList()
        {
            try
            {
                List<SymbolModel> symbolModels = new List<SymbolModel>();
                SymbolListFinder symbolListFinder = new SymbolListFinder(this.UserSetting);

                var pipeSymbols = symbolListFinder.GetPipeSymbolList();
                var civilSymbols = symbolListFinder.GetCivilSymbolList();
                var equipmentSymbols = symbolListFinder.GetEquipmentSymbolList();

                if (pipeSymbols != null) symbolModels.AddRange(pipeSymbols);
                if (civilSymbols != null) symbolModels.AddRange(civilSymbols);
                if (equipmentSymbols != null) symbolModels.AddRange(equipmentSymbols);

                return symbolModels;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }         
        }

        public void GetCatalogs()
        {
            try
            {
                CatalogHelper catalogHelper = new CatalogHelper(this.UserSetting);
                catalogHelper.GetPartsFromCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        public void RefreshAllSystemPath()
        {
            try
            {
                AllSystemPath = SP3DSystemPathFinder.GetAllSystemPath();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
