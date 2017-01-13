using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace TuningDroidControls
{
    [ToolboxBitmap(typeof(TransparentLabel), "VerticalLabel.ico")]
    public partial class TransparentLabel : UserControl
    {
        private string _labelText;
        private float _textSize=30;
        private Point _currentPoint = new Point(0, 0);
        private readonly Container _components = new Container();
        /// <summary>
        ///   VerticalLabel constructor
        /// </summary>
        public TransparentLabel()
        {
            CreateControl();
            InitializeComponentNew();
            SetStyle(ControlStyles.Opaque, true);

            Font = new Font("Segoe UI Light", 30);
        }
        /// <summary>
        ///   Dispose override method
        /// </summary>
        /// <param name = "disposing">boolean parameter</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_components != null)
                {
                    _components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        [DebuggerStepThrough]
        private void InitializeComponentNew()
        {
            //Size = new Size(24, 100);
        }
        /// <summary>
        ///   OnPaint override. This is where the text is rendered vertically.
        /// </summary>
        /// <param name = "e">PaintEventArgs</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            
            e.Graphics.DrawString(_labelText, Font, new SolidBrush(ForeColor), _currentPoint);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // Turn on WS_EX_TRANSPARENT
                return cp;
            }
        }
        /// <summary>
        ///   The text to be displayed in the control
        /// </summary>
        [Category("VerticalLabel"), Description("Text is displayed vertically in container.")]
        public override string Text
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                Invalidate();
            }
        }

        public Point ExtLocation
        {
            get { return _currentPoint; }
            set
            {
                _currentPoint = value;
                Invalidate();
            }
        }

        public float SizeInPoints
        {
            get { return _textSize; }
            set
            {
                _textSize = value;
                Invalidate();
            }
        }
    }
}
