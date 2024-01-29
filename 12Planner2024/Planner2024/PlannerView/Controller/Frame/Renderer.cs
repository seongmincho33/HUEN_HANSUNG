using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerView.Controller.Frame
{
    static public class Renderer
    {
        static public Views Views { get; private set; }
        static public MainFrame MainForm { get; set; }

        static Renderer()
        {
            string[] view_namespaces = { "PlannerView.ChildFrame" };
            Views = new Views(view_namespaces);
        }

        static public bool Render(string className)
        {
            try
            {
                var view = Views.GetViewInstance(className);
                if (view != null)
                {
                    MainForm.PublicChildFramePanel.Controls.Clear();
                    view.Dock = DockStyle.Fill;
                    MainForm.PublicChildFramePanel.Controls.Add(view);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
                return false;
            }
        }
    }
}
