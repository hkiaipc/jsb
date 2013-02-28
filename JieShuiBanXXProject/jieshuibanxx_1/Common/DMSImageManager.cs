using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using jieshuibanxx_1.Properties;

namespace jieshuibanxx_1.Common
{
    public class DMSImageManager
    {
        public static Image GetImage(string key)
        {
            Image img = (Image)Resources.ResourceManager.GetObject(key);
            if (img == null)
                return Resources.ToolButton_ErrorImage;
            return img;
        }
    }
}
