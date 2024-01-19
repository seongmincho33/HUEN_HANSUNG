using PlannerView.Components;
using PlannerView.Components.CalendarComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerView.ChildFrame
{
    public partial class Planner : UserControl
    {
        private TabControl PlanTabControl { get; set; }

        public Planner()
        {
            InitializeComponent();
            this.SetTabControl();
            this.btnNewPlan.Click += BtnInsert_Click;
        }

        private void BtnInsert_Click(object? sender, EventArgs e)
        {
            Pop_PlannerCreator pop_PlannerCreator = new Pop_PlannerCreator();            
            pop_PlannerCreator.StartPosition = FormStartPosition.CenterParent;
            if (pop_PlannerCreator.ShowDialog() == DialogResult.OK)
            {
                this.CreatePlanTab(pop_PlannerCreator.Title);
            }
            
        }

        private void SetTabControl()
        {
            this.PlanTabControl = new TabControl();
            this.PlanTabControl.Padding = new Point(10, 10);
            this.PlanTabControl.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(PlanTabControl);
        }        

        private void CreatePlanTab(string tabpageName)
        {
            TabPage tabPage = new TabPage(tabpageName);
            tabPage.Controls.Add(this.CreatePlanDetailTab());
            this.PlanTabControl.TabPages.Add(tabPage);
        }

        private TabControl CreatePlanDetailTab()
        {
            TabControl detailTabControl = new TabControl();
            detailTabControl.Dock = DockStyle.Fill;
            detailTabControl.Padding = new Point(10,  10);

            detailTabControl.TabPages.AddRange(new[] { this.CreatePlanerGrid(), this.CreateCalendar(), this.CreateXXX() });

            return detailTabControl;
        }

        private TabPage CreatePlanerGrid()
        {
            TabPage tabPageGrid = new TabPage("Grid");

            return tabPageGrid;
        }

        private TabPage CreateCalendar()
        {
            TabPage tabPageCalendar = new TabPage("Calendar");
            Calendar calendar = new Calendar(DateTime.Today);
            calendar.Dock = DockStyle.Fill;
            tabPageCalendar.Controls.Add(calendar);

            return tabPageCalendar;
        }

        private TabPage CreateXXX()
        {
            TabPage tabPageXXX = new TabPage("XXX");

            return tabPageXXX;
        }
    }
}
