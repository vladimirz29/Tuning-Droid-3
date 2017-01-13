using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using TuningDroidAPI;

namespace TuningDroidControls
{
    public partial class StartPage : MetroUserControl
    {
        public StartPage()
        {
            InitializeComponent();
            metroButton1.Location = new Point(ApiContext.CalculateCenterX(this.Size, metroButton1.Size),metroButton1.Location.Y);
            
            transparentLabel1.Text = "Hello";
            transparentLabel1.Font = new Font("Segoe UI Light", 50);
            
            transparentLabel1.Size= transparentLabel1.CreateGraphics().MeasureString(transparentLabel1.Text, transparentLabel1.Font).ToSize();
            transparentLabel1.Location = new Point(ApiContext.CalculateCenterX(this.Size,transparentLabel1.Size), transparentLabel1.Location.Y);

            transparentLabel2.Text = "Tuning Droid 3";
            transparentLabel2.Font = new Font("Segoe UI Light", 16);

            transparentLabel2.Size = transparentLabel2.CreateGraphics().MeasureString(transparentLabel2.Text, transparentLabel2.Font).ToSize();
            transparentLabel2.Location = new Point(ApiContext.CalculateCenterX(this.Size, transparentLabel2.Size)+3, pictureBox1.Height- transparentLabel2.Height-10);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TuningDroidControlsContext.AddControl(new SelectMode());
        }
    }
}
