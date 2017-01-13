using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuningDroidControls
{
    public static class TuningDroidControlsContext
    {
        public static string ControlsVersion = "1.0.0";
        public static MetroForm MainForm;

        public static void InitializeControlsContext(ref MetroForm mainForm)
        {
            mainForm.Style = MetroFramework.MetroColorStyle.Brown;
            MainForm = mainForm;
            AddControl(new StartPage());
        }

        public static void AddControl(Control control)
        {
            //Searching for panel1
            var mainPanel = MainForm.Controls["panel1"];
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
        }

        public static void ShowAlert(string message)
        {
            new MetroMessageBox()
            {
                Text=message
            }.Show();
        }
    }
}
