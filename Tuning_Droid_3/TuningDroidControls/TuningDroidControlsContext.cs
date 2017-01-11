using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuningDroidControls
{
    public class TuningDroidControlsContext
    {
        public string ControlsVersion = "1.0.0";
        

        public TuningDroidControlsContext(ref Form mainForm)
        {
            
        }

        public void ShowAlert(string message)
        {
            new AlertWindow(message).Show();
        }
    }
}
