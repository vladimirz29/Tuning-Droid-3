using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateService;

namespace TuningDroidAPI
{
    public static class ApiContext
    {

        public static bool CheckUpdates()
        {
            return UpdateService.TuningDroidUpdater.CheckForUpdates();
        }

        public static Point CalculateCenterPoint(Size parentSize, Size childSize)
        {
            return new Point(parentSize.Width/2-childSize.Width/2, parentSize.Height / 2 - childSize.Height / 2);
        }

        public static int CalculateCenterX(Size parentSize, Size childSize)
        {
            return parentSize.Width / 2 - childSize.Width / 2;
        }

        public static SizeLocationModel SetTransparentLabelInTheMiddle(SizeLocationModel control,string text, Font font, Size workingArea, Graphics graphicsUnit)
        {
            control.Size = graphicsUnit.MeasureString(text, font).ToSize();
            control.Point = new Point(CalculateCenterX(control.ParentSize, control.Size) + 3, workingArea.Height - workingArea.Height - 10);
            return new SizeLocationModel()
            {
                Size = control.Size,
                Point = control.Point
            };
        }
    }
}
