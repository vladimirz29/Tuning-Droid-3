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

namespace Tuning_Droid_3
{
    public partial class Form1 : Form
    {
        TuningDroidControlsContext ControlsContext;

        public Form1()
        {
            InitializeComponent();
            ApiContext.CheckUpdates();
            Form form = (Form)this;
            ControlsContext = new TuningDroidControlsContext(ref form);
        }
    }
}
