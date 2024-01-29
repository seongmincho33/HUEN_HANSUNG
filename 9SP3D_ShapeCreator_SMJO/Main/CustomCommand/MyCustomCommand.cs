using Main.SP3DHelper;
using Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.CustomCommand
{
    /// <summary>
    /// CustomCommand가 실행되고 이후에 할 행동은 여기에 작성할것.
    /// </summary>
    public class MyCustomCommand
    {
        public MyCustomCommand()
        {
            try
            {
                AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
                //SP3D에 연결한다.
                SP3DConnector.ConnectToSP3DSite();

                //GetSelection();

                using (MainForm mainForm = new MainForm())
                {
                    mainForm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            if(e.ExceptionObject is Exception)
            {
                Exception ex = (Exception)e.ExceptionObject;
                Console.WriteLine("An unhandled exception occurred: " + ex.Message);
            }
        }

        private void GetSelection()
        {
            try
            {
                if (Ingr.SP3D.Common.Client.Services.ClientServiceProvider.SelectSet != null
                    && Ingr.SP3D.Common.Client.Services.ClientServiceProvider.SelectSet.SelectedObjects != null)
                {
                    foreach (Ingr.SP3D.Common.Middle.BusinessObject selObj in Ingr.SP3D.Common.Client.Services.ClientServiceProvider.SelectSet.SelectedObjects)
                    {

                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
