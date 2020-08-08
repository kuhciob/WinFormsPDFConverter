using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFConverter
{
    public partial class Form1 : Form
    {
        private PDFFile File;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    string filePath = openFileDialog1.FileName;
                    File = new PDFFile(filePath);

                    PDFViewerpictureBox.BackColor = Color.Empty;
                    //PDFViewerpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    PDFViewerpictureBox.Image = File[0];

                    PagesnumericUpDown.Enabled = true;
                    PagesnumericUpDown.Maximum = File.PagesCount;
                    PagesnumericUpDown.Minimum = 1;

                    Prevbutton.Enabled = true;
                    Nextbutton.Enabled = true;

                    PagesCounttextBox.Text = $"//{File.PagesCount}";

                    JPGExportbutton.Enabled = true;
                    SVGexportbutton.Enabled = true;
                }
                catch (System.Security.SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportAs(ImageMagick.MagickFormat.Svg);

        }

        private void PagesnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            PDFViewerpictureBox.Image = File[Convert.ToInt32(PagesnumericUpDown.Value) - 1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagesnumericUpDown.DownButton();
            //PDFViewerpictureBox.Image = File[Convert.ToInt32(PagesnumericUpDown.Value) - 1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PagesnumericUpDown.UpButton();
            //PDFViewerpictureBox.Image = File[Convert.ToInt32(PagesnumericUpDown.Value) - 1];
        }

        private void PDFViewerpictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ExportAs(ImageMagick.MagickFormat format)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PDFConverter.AsImagesToFilesAs(File.Path, saveFileDialog1.FileName, Convert.ToInt32(PagesnumericUpDown.Value-1),format);
                }
                catch (System.Security.SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void JPGExportbutton_Click(object sender, EventArgs e)
        {
            ExportAs(ImageMagick.MagickFormat.Jpg);
            //PDFConverter.AsImagesToFiles(File.Path, ImageMagick.MagickFormat.Jpg);
        }

        private void SVGexportbutton_Click(object sender, EventArgs e)
        {
            ExportAs(ImageMagick.MagickFormat.Svg);
            //PDFConverter.AsImagesToFiles(File.Path, ImageMagick.MagickFormat.Svg);
        }
    }
}
