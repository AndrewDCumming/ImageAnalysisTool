using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImageAnalysisTool
{
    public class FaceDetection
    {
        public static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        List<Color> colorsList = new List<Color>();
        Bitmap img;

        List<Categories> catToSort = new List<Categories>();


        public FaceDetection()
        {
            this.DetectionImageSelection();
        }




        public void DetectionImageSelection()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = new Bitmap(Image.FromFile(ofd.FileName));


                    //Code taken from FoxLearn Youtube Video: https://youtu.be/zLgIy0o_0Ow
                    Image<Bgr, Byte> originalImage = new Image<Bgr, byte>(ofd.FileName);
                    Image<Gray, Byte> grayImage = originalImage.Convert<Gray, Byte>();
                    //rectangles around any matches
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.35, 0);
                    //End of code from FoxLearn video

                    Debug.WriteLine(rectangles.Length);
                    Debug.WriteLine(rectangles[0].Width);
                    Debug.WriteLine(rectangles[0].Height);

                    //Can take some time to complete
                    for (int i = 0; i < rectangles[0].Width ;i++)
                    { 
                        for (int j = 0; j < rectangles[0].Height; j++)
                        {
                            Color pixel = img.GetPixel(i + rectangles[0].Y, j + rectangles[0].X);

                            if (!colorsList.Contains(pixel))
                            {
                                colorsList.Add(pixel);
                            }


                        }
                    }
                    Debug.WriteLine("Completed adding pixels");
                }

            }

        }


        public bool LookForMatch(Bitmap bmp)
        {
            int threshold = 0;
            int colorlistTotal = colorsList.Count;
            double minmatchthreshold = colorlistTotal * 0.7;

            //Check all the pixels in the image and set a threshold for reporting

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color currentPixel = bmp.GetPixel(i, j);
                    if (colorsList.Contains(currentPixel))
                    {
                        threshold++;
                    }
                    else
                    {
                    }    
                }               
            }

            //Check threshold if above certain value return true else return false.
            if (threshold >= minmatchthreshold)
            {
                Debug.WriteLine("Match threshold met");
                return true;
            }
            else
            {
                Debug.WriteLine("No Match Found");
                return false;
            }

        }



    }
}
