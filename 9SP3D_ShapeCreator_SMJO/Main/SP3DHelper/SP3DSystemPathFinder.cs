using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingr.SP3D.Common.Middle.Services;
using System.Windows.Forms;
using Main;
using Main.Model;

namespace Main.SP3DHelper
{
    public static class SP3DSystemPathFinder
    { 
        /// <summary>
        /// Foundation 에 들어가는 Note 이름
        /// </summary>
        public static string PEDAS_TAG = "PEDAS_TAG";

        public static List<SystemPath_Model> GetAllSystemPath() 
        {
            List<SystemPath_Model> returnValue = new List<SystemPath_Model>();

            try
            {
                string objectId = SP3DConnector.site.ActivePlant.PlantModel.DatabaseID;
                returnValue.Add(new SystemPath_Model(objectId, "", SP3DConnector.site.ActivePlant.Name, MainSystemPathType.Root));

                var systemChildren = SP3DConnector.site.ActivePlant.PlantModel.RootSystem.SystemChildren;

                foreach (dynamic system in systemChildren)
                {
                    returnValue.Add(ChangeSystemPathToModel(system, objectId));
                    FindChildren(system, returnValue);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return returnValue;
        }

        private static void FindChildren(dynamic system, List<SystemPath_Model> list)
        {
            try
            {
                if (SP3DConnector.CheckSystems.Contains(system.GetType().Name) == true)
                {
                    if (system.GetType().GetProperty("SystemChildren") != null)
                    {
                        if (system.SystemChildren != null)
                        {
                            foreach (var systemchild in system.SystemChildren)
                            {
                                var tmp = ChangeSystemPathToModel(systemchild, system.ObjectID);
                                if (tmp != null) list.Add(tmp);
                                FindChildren(systemchild, list);
                            }
                        }
                    }
                }               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static SystemPath_Model ChangeSystemPathToModel(dynamic system, string parentID)
        {
            try
            {
                if (SP3DConnector.CheckSystems.Contains(system.GetType().Name) == false) return null;

                if(system is Ingr.SP3D.Systems.Middle.System)
                {
                    Ingr.SP3D.Systems.Middle.System systemData = (Ingr.SP3D.Systems.Middle.System)system;

                    // PEDAS 에서 추가된 Item 제외 
                    if (systemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
                        return new SystemPath_Model(system.ObjectID, parentID, system.ToString(), system.GetType().Name, system);
                }
                else
                {
                    return new SystemPath_Model(system.ObjectID, parentID, system.ToString(), system.GetType().Name, system);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return null;
        }

        //public static List<SystemPath_Model> GetSystemPaths(List<string> findSystemPath, bool isRoot)
        //{
        //    List<SystemPath_Model> list = new List<SystemPath_Model>();

        //    try
        //    {
        //        string projectID = SP3DConnector.site.ActivePlant.PlantModel.DatabaseID;

        //        if (findSystemPath == null)
        //        {
        //            list.Add(new SystemPath_Model(projectID, "", SP3DConnector.site.ActivePlant.Name, MainSystemPathType.Root));

        //            var systemChildren = SP3DConnector.site.ActivePlant.PlantModel.RootSystem.SystemChildren;

        //            foreach (dynamic system in systemChildren)
        //            {
        //                if (SP3DConnector.CheckSystems.Contains(system.GetType().Name) == false) continue;

        //                try
        //                {
        //                    Ingr.SP3D.Systems.Middle.System systemData = (Ingr.SP3D.Systems.Middle.System)system;

        //                    // PEDAS 에서 추가된 Item 제외 
        //                    if (systemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
        //                        list.Add(new SystemPath_Model(system.ObjectID, projectID, system.ToString(), system.GetType().Name));
        //                }
        //                catch (Exception ex) { }
        //            }
        //        }
        //        else
        //        {
        //            if (isRoot)
        //            {
        //                list.Add(new SystemPath_Model(projectID, "", SP3DConnector.site.ActivePlant.Name, MainSystemPathType.Root));

        //                var systemChildren = SP3DConnector.site.ActivePlant.PlantModel.RootSystem.SystemChildren;

        //                foreach (dynamic system in systemChildren)
        //                {
        //                    if (SP3DConnector.CheckSystems.Contains(system.GetType().Name) == false) continue;

        //                    try
        //                    {
        //                        Ingr.SP3D.Systems.Middle.System systemData = (Ingr.SP3D.Systems.Middle.System)system;

        //                        // PEDAS 에서 추가된 Item 제외 
        //                        if (systemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
        //                            list.Add(new SystemPath_Model(system.ObjectID, projectID, system.ToString(), system.GetType().Name));
        //                    }
        //                    catch (Exception ex) { }
        //                }
        //            }

        //            if (findSystemPath.Count > 0)
        //                FindChildItem(SP3DConnector.site.ActivePlant.PlantModel.RootSystem, findSystemPath, isRoot, ref list);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return list;
        //}

        ///// <summary>
        ///// System 하위까지 조회
        ///// </summary>
        //private static void FindChildItem(dynamic system, List<string> findSystemPath, bool isRoot, ref List<SystemPath_Model> list)
        //{
        //    try
        //    {
        //        if (system.SystemChildren == null || system.SystemChildren.Count == 0) return;

        //        foreach (dynamic ch in system.SystemChildren)
        //        {
        //            if (SP3DConnector.CheckSystems.Contains(ch.GetType().Name) == false) continue;

        //            try
        //            {
        //                Ingr.SP3D.Systems.Middle.System systemData = (Ingr.SP3D.Systems.Middle.System)ch;

        //                if (systemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
        //                {
        //                    if (findSystemPath.First() == ch.ObjectID)
        //                    {
        //                        if (isRoot)
        //                        {
        //                            if (SP3DConnector.CheckSystems.Contains(systemData.GetType().Name) == false) continue;

        //                            Ingr.SP3D.Systems.Middle.System tmpsystemData = (Ingr.SP3D.Systems.Middle.System)systemData;

        //                            if (tmpsystemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
        //                            {
        //                                var find = list.FirstOrDefault(p => p.ID == tmpsystemData.ObjectID);

        //                                if (find == null)
        //                                    list.Add(new SystemPath_Model(tmpsystemData.ObjectID, ((Ingr.SP3D.Systems.Middle.System)systemData.SystemParent).ObjectID, tmpsystemData.ToString(), tmpsystemData.GetType().Name));
        //                            }
        //                        }
        //                        else
        //                        {
        //                            foreach (dynamic tmp in systemData.SystemChildren)
        //                            {
        //                                if (SP3DConnector.CheckSystems.Contains(tmp.GetType().Name) == false) continue;

        //                                Ingr.SP3D.Systems.Middle.System tmpsystemData = (Ingr.SP3D.Systems.Middle.System)tmp;

        //                                if (tmpsystemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
        //                                {
        //                                    var find = list.FirstOrDefault(p => p.ID == tmpsystemData.ObjectID);

        //                                    if (find == null)
        //                                        list.Add(new SystemPath_Model(tmpsystemData.ObjectID, systemData.ObjectID, tmpsystemData.ToString(), tmpsystemData.GetType().Name));
        //                                }
        //                            }
        //                        }
        //                    }
        //                    else if (findSystemPath.Contains(ch.ObjectID))
        //                    {
        //                        FindChildItem(ch, findSystemPath, isRoot, ref list);

        //                        if (isRoot)
        //                        {
        //                            if (SP3DConnector.CheckSystems.Contains(systemData.GetType().Name) == false) continue;

        //                            Ingr.SP3D.Systems.Middle.System tmpsystemData = (Ingr.SP3D.Systems.Middle.System)systemData;

        //                            if (tmpsystemData.Notes.Any(x => x.Name.StartsWith(PEDAS_TAG)) == false)
        //                            {
        //                                var find = list.FirstOrDefault(p => p.ID == tmpsystemData.ObjectID);

        //                                if (find == null)
        //                                    list.Add(new SystemPath_Model(tmpsystemData.ObjectID, ((Ingr.SP3D.Systems.Middle.System)systemData.SystemParent).ObjectID, tmpsystemData.ToString(), tmpsystemData.GetType().Name));
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            catch { }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
