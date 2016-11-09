using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace BarChart
{
    static class Filters
    {
        static int r_canal, g_canal, b_canal;
        public static int R_canal
        {
            get { return r_canal; }
            set
            {
                if (value < 0)
                    r_canal = 0;
                else if (value > 255)
                    r_canal = 255;
                else
                    r_canal = value;
            }
        }
        public static int G_canal
        {
            get { return g_canal; }
            set
            {
                if (value < 0)
                    g_canal = 0;
                else if (value > 255)
                    g_canal = 255;
                else
                    g_canal = value;
            }
        }
        public static int B_canal
        {
            get { return b_canal; }
            set
            {
                if (value < 0)
                    b_canal = 0;
                else if (value > 255)
                    b_canal = 255;
                else
                    b_canal = value;
            }
        }

        /// <summary>
        /// Method changes the brightness of image
        /// </summary>
        public static Bitmap EditBrightness(Bitmap image, int persentOfBrightness)
        {
            int brightness = persentOfBrightness * 128 / 100;
            for (int i=0; i < image.Size.Width; i++)
                for(int j=0; j < image.Size.Height; j++)
                {
                    R_canal = image.GetPixel(i,j).R + brightness;
                    G_canal = image.GetPixel(i,j).G + brightness;
                    B_canal = image.GetPixel(i,j).B + brightness;

                    image.SetPixel(i, j, Color.FromArgb(R_canal, G_canal, B_canal));
                }

            return image;
        }
        /// <summary>
        /// Method gets all R,G,B of image and it places them in a matrix
        /// </summary>
        /// <param name="image"></param>
        private static void GetArraysOfPixels(ref Bitmap image, ref int[,] allPixelsR, ref int[,] allPixelsG, ref int[,] allPixelsB)
        {
            for (int i = 0; i < image.Size.Width; i++)
                for (int j = 0; j < image.Size.Height; j++)
                {
                    allPixelsR[i, j] = image.GetPixel(i, j).R;
                    allPixelsG[i, j] = image.GetPixel(i, j).G;
                    allPixelsB[i, j] = image.GetPixel(i, j).B;
                }
        }

        /// <summary>
        /// Method return a kernel for create "edge detection" effect 
        /// </summary>
        public static Bitmap EdgeDetection(Bitmap image)
        {
            int[,] kernel = { { -1, -1, -1 },
                              { -1, 8, -1 },
                              { -1, -1, -1 } };
            return image = KernelProcessing(image, kernel);
        }

        /// <summary>
        /// Method returns a kernel for create "Box blur" effect
        /// </summary>
        public static Bitmap BoxBlur(Bitmap image)
        {
            int[,] kernel = { { 1, 1, 1 },
                              { 1, 1, 1 },
                              { 1, 1, 1 } };
            return image = KernelProcessing(image, kernel);
        }

        /// <summary>
        /// Methos returns a kernel for create "sharpness" effect
        /// </summary>
        public static Bitmap Sharpness(Bitmap image)
        {
            int[,] kernel = { { -1, -1, -1 },
                              { -1, 9, -1 },
                              { -1, -1, -1 } };
            return image = KernelProcessing(image, kernel);
        }

        /// <summary>
        /// Method works with different kernels
        /// </summary>
        private static Bitmap KernelProcessing(Bitmap image, int[,] kernel)
        {
            int[,] allPixR = new int[image.Size.Width, image.Size.Height];
            int[,] allPixG = new int[image.Size.Width, image.Size.Height];
            int[,] allPixB = new int[image.Size.Width, image.Size.Height];

            GetArraysOfPixels(ref image, ref allPixR, ref allPixG, ref allPixB);

            int sumOfNeighboringR_canal, sumOfNeighboringG_canal, sumOfNeighboringB_canal;

            for(int i=2; i<image.Size.Width-2; i++) //УБРАТЬ 5
                for (int j=2; j<image.Size.Height-2; j++)
                {
                    sumOfNeighboringR_canal = 0;
                    sumOfNeighboringG_canal = 0;
                    sumOfNeighboringB_canal = 0;

                    //m - widght of kernel; n - height of kernel
                    for (int m=0; m<3; m++)
                        for (int n=0; n<3; n++)
                        {
                            R_canal = allPixR[i + n, j + m];
                            sumOfNeighboringR_canal += kernel[m, n] * R_canal;

                            G_canal = allPixG[i + n, j + m];
                            sumOfNeighboringG_canal += kernel[m, n] * G_canal;

                            B_canal = allPixB[i + n, j + m];
                            sumOfNeighboringB_canal += kernel[m, n] * B_canal;
                        }

                    if (kernel[2,2] == 1) //for kernel of blurBox
                    {
                        R_canal = sumOfNeighboringR_canal / 9;
                        G_canal = sumOfNeighboringG_canal / 9;
                        B_canal = sumOfNeighboringB_canal / 9;
                    }
                    else
                    {
                        R_canal = sumOfNeighboringR_canal;
                        G_canal = sumOfNeighboringG_canal;
                        B_canal = sumOfNeighboringB_canal;
                    }
                   
                    image.SetPixel(i, j, Color.FromArgb(R_canal, G_canal, B_canal));
                }
            image.SetResolution(image.Width - 3, image.Height - 3); //edit!
            return image;
        }
    }
}
