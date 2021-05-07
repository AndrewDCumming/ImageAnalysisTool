using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageAnalysisTool
{
    public class Categories
    {
        private string catName;
        List<TheImage> imageList = new List<TheImage>();

        public Categories(String catName)
        {
            this.catName = catName;
        }




        public string Name
        {
            get { return catName; }
            set { catName = value; }
        }


        public void AddImageToCategory(String imgName, Image image)
        {
            TheImage theImage = new TheImage(imgName, image);
            imageList.Add(theImage);
        }

        public int ReturnNumberOfImages()
        {
            return imageList.Count;
        }


    }
}
