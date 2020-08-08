namespace PDFConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.PagesnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SVGexportbutton = new System.Windows.Forms.Button();
            this.PagesCounttextBox = new System.Windows.Forms.TextBox();
            this.Prevbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.PDFViewerpictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.JPGExportbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PagesnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewerpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagesnumericUpDown
            // 
            this.PagesnumericUpDown.Enabled = false;
            this.PagesnumericUpDown.Location = new System.Drawing.Point(193, 23);
            this.PagesnumericUpDown.Name = "PagesnumericUpDown";
            this.PagesnumericUpDown.Size = new System.Drawing.Size(52, 23);
            this.PagesnumericUpDown.TabIndex = 4;
            this.PagesnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PagesnumericUpDown.ValueChanged += new System.EventHandler(this.PagesnumericUpDown_ValueChanged);
            // 
            // SVGexportbutton
            // 
            this.SVGexportbutton.Enabled = false;
            this.SVGexportbutton.Location = new System.Drawing.Point(385, 10);
            this.SVGexportbutton.Name = "SVGexportbutton";
            this.SVGexportbutton.Size = new System.Drawing.Size(196, 23);
            this.SVGexportbutton.TabIndex = 5;
            this.SVGexportbutton.Text = "Export current page as SVG";
            this.SVGexportbutton.UseVisualStyleBackColor = true;
            this.SVGexportbutton.Click += new System.EventHandler(this.SVGexportbutton_Click);
            // 
            // PagesCounttextBox
            // 
            this.PagesCounttextBox.Enabled = false;
            this.PagesCounttextBox.Location = new System.Drawing.Point(251, 24);
            this.PagesCounttextBox.Name = "PagesCounttextBox";
            this.PagesCounttextBox.Size = new System.Drawing.Size(46, 23);
            this.PagesCounttextBox.TabIndex = 6;
            this.PagesCounttextBox.Text = "/ 0";
            // 
            // Prevbutton
            // 
            this.Prevbutton.Enabled = false;
            this.Prevbutton.Location = new System.Drawing.Point(143, 23);
            this.Prevbutton.Name = "Prevbutton";
            this.Prevbutton.Size = new System.Drawing.Size(44, 23);
            this.Prevbutton.TabIndex = 7;
            this.Prevbutton.Text = "<<";
            this.Prevbutton.UseVisualStyleBackColor = true;
            this.Prevbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Enabled = false;
            this.Nextbutton.Location = new System.Drawing.Point(303, 23);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(44, 23);
            this.Nextbutton.TabIndex = 7;
            this.Nextbutton.Text = ">>";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // PDFViewerpictureBox
            // 
            this.PDFViewerpictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.PDFViewerpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PDFViewerpictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PDFViewerpictureBox.Location = new System.Drawing.Point(0, 68);
            this.PDFViewerpictureBox.Name = "PDFViewerpictureBox";
            this.PDFViewerpictureBox.Size = new System.Drawing.Size(624, 604);
            this.PDFViewerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PDFViewerpictureBox.TabIndex = 1;
            this.PDFViewerpictureBox.TabStop = false;
            this.PDFViewerpictureBox.WaitOnLoad = true;
            this.PDFViewerpictureBox.Click += new System.EventHandler(this.PDFViewerpictureBox_Click);
            // 
            // JPGExportbutton
            // 
            this.JPGExportbutton.Enabled = false;
            this.JPGExportbutton.Location = new System.Drawing.Point(385, 39);
            this.JPGExportbutton.Name = "JPGExportbutton";
            this.JPGExportbutton.Size = new System.Drawing.Size(196, 23);
            this.JPGExportbutton.TabIndex = 5;
            this.JPGExportbutton.Text = "Export current page as JPG";
            this.JPGExportbutton.UseVisualStyleBackColor = true;
            this.JPGExportbutton.Click += new System.EventHandler(this.JPGExportbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 672);
            this.Controls.Add(this.JPGExportbutton);
            this.Controls.Add(this.PDFViewerpictureBox);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Prevbutton);
            this.Controls.Add(this.PagesCounttextBox);
            this.Controls.Add(this.SVGexportbutton);
            this.Controls.Add(this.PagesnumericUpDown);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PagesnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewerpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown PagesnumericUpDown;
        private System.Windows.Forms.Button SVGexportbutton;
        private System.Windows.Forms.TextBox PagesCounttextBox;
        private System.Windows.Forms.Button Prevbutton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PDFViewerpictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button JPGExportbutton;
    }
}

