using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace jieshuibanxx_1.Common
{
    public class ToolStripButtonBuilder
    {
        public static ToolStripButton BuildToolStripButton(ToolBarCommand cmd)
        {
            ToolStripButton btn = new ToolStripButton();
            btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            btn.Text = cmd.CommandName;
            btn.Visible = cmd.IsVisible;
            btn.Enabled = cmd.IsEnable;
            btn.Tag = cmd;

            btn.Image = DMSImageManager.GetImage("ToolButton_" + cmd.Type.ToString());

            return btn;
        }
    }
}
