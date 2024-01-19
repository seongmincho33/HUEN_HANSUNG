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
    public partial class CalendarLabel : UserControl
    {
        private bool isDragging = false;
        private Point offset;
        private CalendarLabel draggedLabel;

        public CalendarLabel(List<CalendarCell> cells, CalendarCell sourceCell)
        {
            InitializeComponent();

            foreach (CalendarCell cell in cells)
            {
                cell.AllowDrop = true;
                cell.DragDrop += panel_DragDrop;
                cell.DragEnter += panel_DragEnter;
            }

            sourceCell.AddCalendarLabel(this);

            this.MouseDown += label_MouseDown;
            this.MouseMove += label_MouseMove;
            this.MouseUp += label_MouseUp;
            this.AllowDrop = true;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                draggedLabel = sender as CalendarLabel;
                offset = e.Location;
                draggedLabel.BringToFront();
                //DoDragDrop(draggedLabel, DragDropEffects.Copy);
            }
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                draggedLabel.Left += e.X - offset.X;
                draggedLabel.Top += e.Y - offset.Y;
            }
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                DoDragDrop(draggedLabel, DragDropEffects.Move);
                draggedLabel = null;
            }
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            CalendarCell targetPanel = sender as CalendarCell;
            if (draggedLabel != null)
            {
                Point point = targetPanel.PointToClient(new Point(e.X, e.Y));
                draggedLabel.Location = point;
                targetPanel.AddCalendarLabel(draggedLabel);
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(CalendarLabel)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
