using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Model
{
    public class PipePosition
    {
        public PipePosition()
        {
            try
            {
                Position_1 = new Position(0, 0, 0);
                Position_2 = new Position(0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Position Position_1 { get; set; }
        public Position Position_2 { get; set; }
    }
}
