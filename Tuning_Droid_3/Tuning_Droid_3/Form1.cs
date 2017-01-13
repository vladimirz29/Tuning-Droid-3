using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuningDroidAPI;
using TuningDroidControls;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Tuning_Droid_3
{
    public partial class Form1 : MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            
            ApiContext.CheckUpdates();
            MetroForm form = this;
            TuningDroidControlsContext.InitializeControlsContext(ref form);
        }
    }
}
