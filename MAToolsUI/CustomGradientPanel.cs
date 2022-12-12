using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAToolsUI
{
    public class MAToolsUICustomGradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        public MAToolsUICustomGradientPanel()
        {
            this.Size = new Size(150, 40);
            this.ColorBottom = Color.DarkTurquoise;
            this.ColorBottom = Color.MediumTurquoise;
            this.ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90f);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
