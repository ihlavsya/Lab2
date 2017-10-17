using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    public enum Channel
    {
            Red = 1,
            Green,
            Blue
    }

    public class CalculationClass// в Form1 будут храниться не битмапы, а экземпляры этого класса 
    {
        public Bitmap WorkingImage;//SetPixel(Int32, Int32, Color)
        public int [] RedData;//индексы это от 0 до 255 то есть яркость
        public int[] GreenData;
        public int[] BlueData;
        public CalculationClass()
        {
            RedData = new int[256];
            GreenData = new int[256];
            BlueData = new int[256];
        }

        public CalculationClass(Image a):this()
        {
            WorkingImage = new Bitmap(a);
            FillColourfulData();
        }

        public Bitmap GetBitmapInRed(Channel c)
        {
            //Bitmap redBitmap = new Bitmap(WorkingImage.Height, WorkingImage.Width);
            Bitmap redBitmap = WorkingImage;
            for (int i = 0; i < WorkingImage.Width; i++)
            {
                for (int j = 0; j <WorkingImage.Height; j++)
                {
                    var color= WorkingImage.GetPixel(i, j);
                    Color a = Color.FromArgb(color.A, color.R, 0, 0);
                    redBitmap.SetPixel(i, j, a);
                    //redBitmap.SetPixel(i, j, WorkingImage.GetPixel(i, j).R);
                }
            }
            return redBitmap;
        }

        private void FillColourfulData()
        {
            for (int i=0;i<WorkingImage.Width;i++)
            {
                for (int j=0;j<WorkingImage.Height;j++)
                {
                    RedData[WorkingImage.GetPixel(i, j).R]++;
                    GreenData[WorkingImage.GetPixel(i, j).G]++;
                    BlueData[WorkingImage.GetPixel(i, j).B]++;
                }
            }
        }
    }
}
