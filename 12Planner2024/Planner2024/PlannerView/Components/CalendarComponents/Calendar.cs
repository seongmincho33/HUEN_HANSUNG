using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerView.Components.CalendarComponents
{
    public partial class Calendar : UserControl
    {
        private DateTime CurrentDate { get; set; }

        private int MonthCounter = 0;

        public Calendar(DateTime currentDate)
        {
            InitializeComponent();
            this.CurrentDate = currentDate;
            this.lblDate.Text = currentDate.Year.ToString() + " / " + currentDate.Month;
            this.SetMonthCalendarToLayout(currentDate);

            this.btnAfter.Click += BtnAfter_Click;
            this.btnBefore.Click += BtnBefore_Click;
        }

        private void BtnBefore_Click(object? sender, EventArgs e)
        {
            this.MonthCounter -= 1;
            this.SetNewMonthCalendarToLayout();
        }

        private void BtnAfter_Click(object? sender, EventArgs e)
        {
            this.MonthCounter += 1;
            this.SetNewMonthCalendarToLayout();
        }

        private void SetNewMonthCalendarToLayout()
        {
            DateTime movedDateTime = this.CurrentDate.AddMonths(this.MonthCounter);
            this.lblDate.Text = movedDateTime.Year.ToString() + " / " + movedDateTime.Month;
            this.tableLayoutPanel1.Controls.Clear();
            this.SetMonthCalendarToLayout(movedDateTime);
        }

        private void SetMonthCalendarToLayout(DateTime currentDate)
        {
            for (int i = 0; i < 7; i++)
            {
                var cell = new CalendarCell();

                cell.SetDesign(CalendarCell.CellType.dayOfWeek, ((DayOfWeek)i).ToString());

                this.tableLayoutPanel1.Controls.Add(cell, i, 0);
            }

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            // Find the first Sunday of the month
            while (firstDayOfMonth.DayOfWeek != DayOfWeek.Sunday)
            {
                firstDayOfMonth = firstDayOfMonth.AddDays(-1);
            }

            // Start setting dates from the second row (index 1)
            List<CalendarCell> calendarCells = new List<CalendarCell>();
            CalendarCell tmpcell = null;
            int rowCounter = 1;
            for (int j = 1; j < 7; j++) // Rows
            {
                for (int i = 0; i < 7; i++) // Columns
                {
                    var cell = new CalendarCell();
                    calendarCells.Add(cell);
                    if (tmpcell == null)
                    {
                        tmpcell = cell;
                    }

                    // Set the date for each cell after the first row
                    DateTime currentCellDate = firstDayOfMonth.AddDays((rowCounter - 1) * 7 + i);

                    // Ensure we're not going beyond the current month
                    if (currentCellDate.Month != currentDate.Month)
                    {
                        cell.SetDesign(CalendarCell.CellType.beyondMonth, currentCellDate.Day.ToString());
                    }
                    else
                    {
                        cell.SetDesign(CalendarCell.CellType.withInMonth, currentCellDate.Day.ToString());
                    }

                    // Add the cell to the TableLayoutPanel
                    this.tableLayoutPanel1.Controls.Add(cell, i, j);
                }

                rowCounter++; // Move to the next row
            }

            foreach(CalendarCell cell in calendarCells)
            {
                cell.CalendarCells = calendarCells;
            }

        }
    }
}
