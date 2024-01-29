using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Model
{
    public struct Position
    {
        public double X;
        public double Y;
        public double Z;

        public Position(double x, double y, double z)
        {
            try
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }
            catch (Exception ex)
            {
                this.X = 0.0;
                this.Y = 0.0;
                this.Z = 0.0;
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
