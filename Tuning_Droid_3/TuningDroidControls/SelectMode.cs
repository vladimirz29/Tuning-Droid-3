using System;
using System.Drawing;
using System.Windows.Forms;
using TuningDroidAPI;

namespace TuningDroidControls
{
    public partial class SelectMode : UserControl
    {
        public SelectMode()
        {
            InitializeComponent();
            transparentLabel1.Text = "Выбор режима";
            transparentLabel1.Font = new Font("Segoe UI Light", 30);
            var result=ApiContext.SetTransparentLabelInTheMiddle(new SizeLocationModel()
            {
                ParentSize=this.Size
            },
            transparentLabel1.Text,
            transparentLabel1.Font,
            this.Size,
            new PictureBox().CreateGraphics());
            transparentLabel1.Size = result.Size;
            transparentLabel1.Location = result.Point;
        }
    }
}
