using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiaryClassLibStandart.Class.OverrideControls
{
    class CustomPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.Gray, 6))
            {
                Rectangle rect = e.ClipRectangle;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                //ControlPaint.DrawBorder(pen, this.mainPanel.ClientRectangle, Color.FromArgb(219, 219, 219), ButtonBorderStyle.Solid);
                var g = e.Graphics;
                g.DrawRectangle(pen, rect);
                g.DrawRectangle(pen,0,0,100,30);

            }
        }
    }
}
