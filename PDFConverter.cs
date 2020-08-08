using ImageMagick;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDFConverter
{
    static class PDFConverter
    {        
        static public void AsImagesToFiles(string fileName, MagickFormat imageExtension)
        {
            var settings = new MagickReadSettings();
            settings.Density = new Density(300, 300);

            using (var images = new MagickImageCollection())
            {
                images.Read(fileName, settings);

                int page = 1;
                foreach (var image in images)
                {
                    image.Format = imageExtension;
                    image.Write($"{fileName}.Page{page.ToString()}.{imageExtension.ToString().ToLower()}");
                    page++;
                }
            }

        }
        static public void AsImagesToFilesAs(string srcPath, string dstPath,int pagenumb,MagickFormat imageExtension)
        {
            var settings = new MagickReadSettings();
            settings.Density = new Density(300, 300);

            using (var images = new MagickImageCollection())
            {
                images.Read(srcPath, settings);

                if (dstPath.Contains(imageExtension.ToString().ToLower()))
                    dstPath.Replace(imageExtension.ToString().ToLower(),"");
                images[pagenumb].Format = imageExtension;
                images[pagenumb].Write($"{dstPath}.{imageExtension.ToString().ToLower()}");
                
            }

        }
        static public void AsImagesToJPGFiles(string fileName)
        {
            var settings = new MagickReadSettings();
            settings.Density = new Density(300, 300);

            using (var images = new MagickImageCollection())
            {
                images.Read(fileName, settings);

                int page = 1;
                foreach (var image in images)
                {
                    image.Format = MagickFormat.Jpg;
                    image.Write($"{fileName}.Page{page}.jpg");
                    page++;
                }
            }
        }
        static public void AsImagesToSVGFiles(string fileName)
        {
            var settings = new MagickReadSettings();
            settings.Density = new Density(300, 300);

            using (var images = new MagickImageCollection())
            {
                images.Read(fileName, settings);

                int page = 1;
                foreach (var image in images)
                {
                    image.Format = MagickFormat.Svg;
                    image.Write($"{fileName}.Page{page}.svg");
                    page++;
                }
            }
        }

    }
}
