using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageAnalysisTool
{
    public class TheImage
    {
        Image image;
        String name;

        public TheImage()
        { }
        public TheImage(string id, Image image)
        {
            this.name = id;
            this.image = image;
        }

        public String TheImageName()
        {
            return name;
        }

        public Image GetTheImage()
        {
            return image;
        }
    }
}
