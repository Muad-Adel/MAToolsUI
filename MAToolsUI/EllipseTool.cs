using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAToolsUI
{
    public class MAToolsUIEllipseTool : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllips
            );
        private Control _Cntrl;
        private int _CornerRadius = 30;

        public Control TargetControl
        {
            get { return _Cntrl; }
            set
            {
                _Cntrl = value;
                _Cntrl.SizeChanged += (sender, eventArgs) => _Cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _Cntrl.Width, _Cntrl.Height, _CornerRadius, _CornerRadius));
            }
        }
        public int CornerRadius
        {
            get { return _CornerRadius; }
            set
            {
                _CornerRadius = value;
                if(_Cntrl != null)
                    _Cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _Cntrl.Width, _Cntrl.Height, _CornerRadius, _CornerRadius));
            }
        }
    }
}
