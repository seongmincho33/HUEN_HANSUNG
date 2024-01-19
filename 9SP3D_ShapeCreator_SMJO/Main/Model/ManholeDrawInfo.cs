using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class ManholeDrawInfo
    {
        public ManholeDrawInfo()
        {
            ManholePosition = new Position(0.0, 0.0, 0.0);
            ManholePartName = "";
            BaseHeight = 0.0;
            ConeHeight = 0.0;
            BaseDiameter = 0.0;
            EccentricConeTopDiameter = 0.0;
            BaseBottomToNozzleHeight = 0.0;
        }

        public Position ManholePosition { get; set; }
        public string ManholePartName { get; set; }
        public double BaseHeight { get; set; }
        public double ConeHeight { get; set; }
        public double BaseDiameter { get; set; }
        public double EccentricConeTopDiameter { get; set; }
        public double BaseBottomToNozzleHeight { get; set; }
    }
}
