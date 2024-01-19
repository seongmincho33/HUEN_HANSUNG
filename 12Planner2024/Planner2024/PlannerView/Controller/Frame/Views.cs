using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlannerView.Controller.Frame
{
    public class Views
    {
        /// <summary>
        /// 모든 뷰(유저컨트롤)의 집합입니다.
        /// </summary>
        public Dictionary<string, object> ViewInstances { get; set; }

        public Views(string[] view_namespaces)
        {
            LoadViewClasses(view_namespaces);
        }

        /// <summary>
        /// 모든 뷰(유저컨트롤)을 딕셔너리 프로퍼티에 넣습니다.
        /// </summary>
        private void LoadViewClasses(string[] view_namespaces)
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in types)
            {
                if (type != typeof(Views))
                {
                    if (view_namespaces.Contains(type.Namespace))
                    {
                        object instance = Activator.CreateInstance(type);
                        if (instance != null)
                        {
                            // Assuming you have a property named 'ViewInstances'
                            PropertyInfo propertyInfo = GetType().GetProperty("ViewInstances");
                            if (propertyInfo != null)
                            {
                                var viewInstances = propertyInfo.GetValue(this) as Dictionary<string, object>;
                                if (viewInstances == null)
                                {
                                    viewInstances = new Dictionary<string, object>();
                                    propertyInfo.SetValue(this, viewInstances);
                                }

                                viewInstances.Add(type.Name, instance);
                            }
                        }
                    }
                }

            }
        }

        /// <summary>
        /// 특정 뷰 화면을 리턴합니다.
        /// </summary>
        /// <param name="className">유저 컨트롤 클래스 이름</param>
        /// <returns>해당 유저 컨트롤</returns>
        public UserControl GetViewInstance(string className)
        {
            if (ViewInstances != null)
            {
                if (ViewInstances.ContainsKey(className))
                {
                    return (UserControl)ViewInstances[className];
                }
            }
            return null;
        }
    }
}
