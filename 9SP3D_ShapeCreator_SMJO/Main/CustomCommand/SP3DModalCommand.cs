using System;
using System.Windows.Forms;
using Ingr.SP3D.Common.Client;

namespace Main.CustomCommand
{
    public class SP3DModalCommand : BaseModalCommand
    {
        private MyCustomCommand myCustomCommand;
        public override void OnStart(int instanceId, object argument)
        {
            try
            {
                myCustomCommand = new MyCustomCommand();
                base.WriteStatusBarMsg(argument.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public override void OnStop()
        {
            base.OnStop();
        }
    }
}