using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PDFConverter
{
    class PDFFile
    {
        private string filePath;
        private int pagesCount;
        private MagickImageCollection magicImagePages;
        private List<Image> imagePages;

        public string Path { get { return filePath; } }
        public int PagesCount { get { return pagesCount; } }

        public PDFFile(string path)
        {
            this.filePath = path;
            imagePages = new List<Image>();

            magicImagePages = new MagickImageCollection();

            var settings = new MagickReadSettings();
            settings.Density = new Density(300, 300);
            magicImagePages.Read(filePath, settings);

            pagesCount = magicImagePages.Count;

            foreach(var page in magicImagePages)
            {
                Stream imgStream = new MemoryStream();
                page.Format = MagickFormat.Jpg;
                page.Write(imgStream);

                imagePages.Add(Bitmap.FromStream(imgStream));
            }
        }
        public Image this[int index]
        {
            get {                                
                try
                {
                    //Stream imgStream = new MemoryStream();
                    //magicImagePages[index + 1].Write(imgStream);
                    //return Bitmap.FromStream(imgStream);
                    return imagePages[index];
                }
                catch(IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Error: This page doesn`t exist!");
                    return null;
                }
                
            }
        }
        
    }
}
