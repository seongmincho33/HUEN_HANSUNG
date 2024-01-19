using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PlannerView.Components.CalendarComponents
{
    public partial class CalendarCell : UserControl
    {
        public enum CellType
        {
            beyondMonth, withInMonth, dayOfWeek
        }

        private CellType cellType { get; set; }

        public List<CalendarCell> CalendarCells { get; set; }

        public CalendarCell()
        {
            InitializeComponent();
            this.toolStrip_InsertData.Click += ToolStrip_InsertData_Click;            
            this.panel1.MouseDown += CalendarCell_MouseDown;
            this.flowLayoutPanel1.MouseDown += CalendarCell_MouseDown;
        }

        private void CalendarCell_MouseDown(object? sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        this.contextMenuStrip1.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void ToolStrip_InsertData_Click(object? sender, EventArgs e)
        {
            this.AddCalendarLabel(new CalendarLabel(CalendarCells, this));
        }

        public void SetDesign(CellType cellType, string title)
        {
            switch(cellType)
            {
                case CellType.beyondMonth:
                    this.BackColor = Color.LightGray;
                    this.lblTitle.Text = title;
                    break;
                case CellType.withInMonth:
                    this.BackColor = Color.AliceBlue;
                    this.lblTitle.Text = title;
                    break;
                case CellType.dayOfWeek:
                    this.BackColor = Color.LavenderBlush;
                    this.lblTitle.Text = title;                   
                    break;
            }
            this.Padding = new Padding(1, 1, 1, 1);
        }

        public void AddCalendarLabel(CalendarLabel label)
        {
            this.flowLayoutPanel1.Controls.Add(label);            
        }

    }
}
