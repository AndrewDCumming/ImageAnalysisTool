using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;



namespace ImageAnalysisTool
{
    class ImageInfoRetrieve
    {
        PropertyItem propItem;

        public string GetTimeAndDate(Image image)
        {
            propItem = image.GetPropertyItem(36867);
            return Encoding.UTF8.GetString(propItem.Value);
        }

        public string GetDeviceManufacturer(Image image)
        {
            propItem = image.GetPropertyItem(271);
            return Encoding.UTF8.GetString(propItem.Value);
        }

        public string GetDeviceModel(Image image)
        {
            propItem = image.GetPropertyItem(272);
            return Encoding.UTF8.GetString(propItem.Value);
        }


        public String GetAllInformation(Image image)
        {
            String dateAndTime;
            String manufacturer;
            String model;
            String allInfo;
            dateAndTime = this.GetTimeAndDate(image);
            manufacturer = this.GetDeviceManufacturer(image);
            model = this.GetDeviceModel(image);
            allInfo = ("Date and Time: " + dateAndTime.TrimEnd('\0') + "\n" + "Manufacturer: " + manufacturer.TrimEnd('\0') + "\n" + "Model: " + model.TrimEnd('\0'));

            return allInfo;

        }
    }
}
