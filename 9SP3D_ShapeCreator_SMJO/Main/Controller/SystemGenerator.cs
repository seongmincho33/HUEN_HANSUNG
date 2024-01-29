using Ingr.SP3D.Civil.Middle;
using Ingr.SP3D.Common.Middle;
using Ingr.SP3D.Common.Middle.Services;
using Ingr.SP3D.Route.Middle;
using Ingr.SP3D.Systems.Middle;
using Main.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    public class SystemGenerator
    {
        private UserSetting UserSetting { get; set; }

        public SystemGenerator(UserSetting userSetting)
        {
            this.UserSetting = userSetting;
        }

        public void CreateStructureSystem()
        {
            try
            {
                StructuralSystem structuralSystem = new StructuralSystem(UserSetting.UserSelectedSystemPathModel.System);
                structuralSystem.SetUserDefinedName(UserSetting.NewSystemName);

                Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreatePipingSystem()
        {
            try
            {
                PipingSystem pipingSystem = new PipingSystem(UserSetting.UserSelectedSystemPathModel.System);
                pipingSystem.SetUserDefinedName(UserSetting.NewSystemName);

                Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);

                //Pipeline pipeLine = new Pipeline(pipingSystem);
                //pipeLine.SetUserDefinedName(UserSetting.NewSystemName + " P1");

                //Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit("z");

                //PipeRun p = new PipeRun(pipeLine, 20, "in", "1C0031");
                

                //PipeEndFeature pipeEndFeature = null;


                //Position pos1 = new Position()
                //{
                //    X = -0.330953
                //    ,
                //    Y = -8.38186
                //    ,
                //    Z = -0.533272
                //};
                //Position pos2 = new Position()
                //{
                //    X = 3.50095
                //    ,
                //    Y = -4.8514
                //    ,
                //    Z = -0.00672814
                //};

                //// 위에처럼 값 주고 튕겨버림. 만들어졌는데 Property Set Value 오류 나오면서....
                //// 내일 만들어진거 검토해서 확인해봐야함.


                //p.RouteBetweenPointAndPoint(pos1, pos2, out pipeEndFeature);


                //Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit("z");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreatePipeLineSystem()
        {
            try
            {                
                Pipeline pipeLine = new Pipeline(UserSetting.UserSelectedSystemPathModel.System);
                pipeLine.SetUserDefinedName(UserSetting.NewSystemName);

                Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 테스트용임 신중이 사용해서 실행할것!!!! 
        /// 반드시 Piping -> PipeLine 생성후 PipeLine 선택해서 가져올것!!!!
        /// </summary>
        [Obsolete("XXXX 'ㅁ' 에러나면 절대안됨 XXXX.")]
        public void CreatePipeRunSystem()
        {
            try
            {
                //원 지름
                //NominalDiameter nominalDiameter = new NominalDiameter();
                //nominalDiameter.Size = 10.0;

                PipeRun pipeRun = new PipeRun(UserSetting.UserSelectedSystemPathModel.System, 14.0, "in", "1C0031");//RouteMiddle

                pipeRun.SetUserDefinedName(UserSetting.NewSystemName);

                pipeRun.FlowDirection = 1; // UPSTREAM

                Ingr.SP3D.Common.Middle.Position pos1 = new Ingr.SP3D.Common.Middle.Position()
                {
                    X = UserSetting.PipePosition.Position_1.X
                     ,
                    Y = UserSetting.PipePosition.Position_1.Y
                     ,
                    Z = UserSetting.PipePosition.Position_1.Z
                };

                Ingr.SP3D.Common.Middle.Position pos2 = new Ingr.SP3D.Common.Middle.Position()
                {
                    X = UserSetting.PipePosition.Position_2.X
                    ,
                    Y = UserSetting.PipePosition.Position_2.Y
                    ,
                    Z = UserSetting.PipePosition.Position_2.Z
                };

                PipeEndFeature pipeEndFeature = null;

                pipeRun.RouteBetweenPointAndPoint(pos1, pos2, out pipeEndFeature);

                Ingr.SP3D.Common.Middle.Services.MiddleServiceProvider.TransactionMgr.Commit(UserSetting.NewSystemName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
