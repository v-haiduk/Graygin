using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO;

namespace BarChart
{
    public partial class Workspace : Form
    {

        public Workspace()
        {
            InitializeComponent();
            progressBar.Visible = false;
            panelForBrightness.Visible = false;
            labelForPanelBritness.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog windowForSelectImage = new OpenFileDialog();
                windowForSelectImage.Filter = "Image Files(*.JPEG;*.JPG)|*.JPEG;*.JPG;";    //(desciption of the filter)|filter pattern
                windowForSelectImage.Title = "Select an image ";

                if (windowForSelectImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    pictureBoxForOriginal.Image = Image.FromFile(windowForSelectImage.FileName);

                DrawHistogram(chartForOriginal, pictureBoxForOriginal.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, select an image!\n" + ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog windowForSaveImage = new SaveFileDialog();
                windowForSaveImage.Filter = "Image file (*.JPEG; *JPG)|*JPEG,*.JPG";
                windowForSaveImage.Title = "Save as..";
                windowForSaveImage.DefaultExt = ".jpeg";

                Bitmap pictureToSave = (Bitmap)pictureBoxForNegative.Image;

                if (CheckedImageOnNull(pictureBoxForOriginal.Image) == false)
                    throw new Exception("You don't select the image");

                if (CheckedImageOnNull(pictureBoxForNegative.Image) == false)
                    throw new Exception("You don't create the new image");              

                if (windowForSaveImage.ShowDialog() == DialogResult.OK)
                    pictureToSave.Save(windowForSaveImage.FileName, ImageFormat.Jpeg);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckedImageOnNull (Image imageOnPictureBox)
        {
            bool result = (imageOnPictureBox != null) ? true : false;
            return result;
        }

        private void buttonNegtive_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckedImageOnNull(pictureBoxForOriginal.Image) == false)
                    throw new Exception("You don't select the image for graphic processing.");

                Bitmap negative = new Bitmap(pictureBoxForOriginal.Image);
                Bitmap originalImage = new Bitmap(pictureBoxForOriginal.Image);

                progressBar.Visible = true;
                progressBar.Maximum = negative.Width;

                Color pixelOfOriginalImage = new Color();
                for (int i = 0; i < negative.Width; i++)
                {
                    for (int j = 0; j < negative.Height; j++)
                    {
                        pixelOfOriginalImage = originalImage.GetPixel(i, j);
                        negative.SetPixel(i, j, Color.FromArgb(255 - pixelOfOriginalImage.R, 
                                                            255 - pixelOfOriginalImage.G, 
                                                            255 - pixelOfOriginalImage.B));
                    }
                    progressBar.Value = progressBar.Maximum - i;
                }
                progressBar.Visible = false;

                pictureBoxForNegative.Image = negative;
                DrawHistogram(chartForNegative, negative);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n"+ ex.Message);
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxForOriginal.Image = null;
            chartForOriginal.Series[0].Points.Clear();

            pictureBoxForNegative.Image = null;
            chartForNegative.Series[0].Points.Clear();
        }

        private void DrawHistogram(Chart chartForBrightness, Image imageOnPictureBox)
        {
            int[] brightness = new int[256];

            Bitmap image = (Bitmap)imageOnPictureBox;

            chartForBrightness.Series[0].Points.Clear();

            for (int i=0; i<imageOnPictureBox.Size.Width; i++)
                for (int j=0; j<imageOnPictureBox.Size.Height; j++)
                    brightness[(int)(image.GetPixel(i, j).GetBrightness() * 255)]++;                    

            for (int k = 0; k < 256; k++)
                 chartForBrightness.Series[0].Points.AddXY(k, brightness[k]);
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            labelValueOfBrightness.Text = String.Format("{0}",trackBarBrightness.Value);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(pictureBoxForOriginal.Image);
                if (CheckedImageOnNull(pictureBoxForNegative.Image) == true)
                    image = new Bitmap(pictureBoxForNegative.Image);

                int persentOfBrightness = 100 / trackBarBrightness.Maximum * trackBarBrightness.Value;
                pictureBoxForNegative.Image = Filters.EditBrightness(image, persentOfBrightness);
                DrawHistogram(chartForNegative, pictureBoxForNegative.Image);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            labelForPanelBritness.Visible = true;
            panelForBrightness.Visible = true;
        }

        private void buttonSharpness_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(pictureBoxForOriginal.Image);
                if (CheckedImageOnNull(pictureBoxForNegative.Image) == true)
                    image = new Bitmap(pictureBoxForNegative.Image);

                pictureBoxForNegative.Image = Filters.Sharpness(image);
                DrawHistogram(chartForNegative, pictureBoxForNegative.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdgeDetection_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(pictureBoxForOriginal.Image);
                if (CheckedImageOnNull(pictureBoxForNegative.Image) == true)
                    image = new Bitmap(pictureBoxForNegative.Image);

                pictureBoxForNegative.Image = Filters.EdgeDetection(image);
                DrawHistogram(chartForNegative, pictureBoxForNegative.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(pictureBoxForOriginal.Image);
                if (CheckedImageOnNull(pictureBoxForNegative.Image) == true)
                    image = new Bitmap(pictureBoxForNegative.Image);
                pictureBoxForNegative.Image = Filters.BoxBlur(image);
                DrawHistogram(chartForNegative, pictureBoxForNegative.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
