using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuningDroidControls
{
    public partial class AlertWindow : Form
    {
        public AlertWindow(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }
    }
}
