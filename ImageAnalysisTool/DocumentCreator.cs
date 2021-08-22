
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Image = Xceed.Document.NET.Image;

namespace ImageAnalysisTool
{
    class DocumentCreator
    {
        List<Categories> categoriesToSort = new List<Categories>();


        public void AddCategories(List<Categories> catList)
        {
            categoriesToSort = catList;
        }




        public void GenerateDocumentation()
        {
            string fileName = "Report.docx";

            var doc = DocX.Create(fileName);

            String docTitle = "Output Report";
            Formatting titleFormat = new Formatting();
            titleFormat.Size = 30D;

            Formatting dataText = new Formatting();
            dataText.Size = 12D;

            Paragraph paragraphTitle = doc.InsertParagraph(docTitle, false, titleFormat);

            foreach(var a in categoriesToSort)
            {
                doc.InsertParagraph(a.Name, false, titleFormat);
                List<TheImage> theImages = a.ReturnTheImageList();
                ImageInfoRetrieve retriever = new ImageInfoRetrieve();
                foreach(var b in theImages)
                {
                    System.Drawing.Image testing = b.GetTheImage();
                    testing.Save("Test.jpg");


                    Image img = doc.AddImage("Test.jpg");
                    Picture p = img.CreatePicture();

                    Paragraph par = doc.InsertParagraph();
                    par.AppendPicture(p);

                    String allImageInfo = b.GetAllInfo();
                    doc.InsertParagraph(allImageInfo, false,dataText);


                }



            }
            doc.Save();

        }


    }
}
