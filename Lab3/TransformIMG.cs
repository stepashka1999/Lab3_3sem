using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;
using System.Drawing;

namespace Lab3
{
    class TransformIMG
    {
        private Image<Bgr, byte> SourseImage;

        private string FileName;

        public TransformIMG(string FileName)
        {
            this.FileName = FileName;
            SourseImage = new Image<Bgr, byte>(FileName);
        }

        public Image<Bgr, byte> GetImg()
        {
            return SourseImage;
        }

        public Image<Bgr,byte> Scale(double _scaleX, double _scaleY)
        {
            var newImage = new Image<Bgr, byte>((int)(SourseImage.Width * _scaleX), (int)(SourseImage.Height * _scaleY));

            /*
             * --DeafoltScale-- *
             
            for (int y = 0; y < SourseImage.Height; y++)
                for(int x = 0; x < SourseImage.Width; x++)
                {
                    newImage[(int)(y * _scaleY), (int)(x * _scaleX)] = SourseImage[y, x];
                }
            
            */

            for (int y = 0; y < newImage.Height - 2; y++)
                for (int x = 0; x < newImage.Width - 2; x++)
                {
                    /*---Искомая точка---*/
                    double X = x / _scaleX;
                    double Y = y / _scaleY;     

                    /*---Округление искомой точки, до ближайшего значения координат---*/
                    int XinSourse = (int)Math.Floor(X);
                    int YinSourse = (int)Math.Floor(Y);

                    /*---Дистанция от искомой, до ближайшей точки---*/
                    double deltaX = X - XinSourse;
                    double deltaY = Y - YinSourse;

                    for(int ch = 0; ch < 3; ch++)
                    {

                        var res = SourseImage.Data[(int)Y, (int)X, ch] * (1 - deltaX) * (1 - deltaY)
                                + SourseImage.Data[(int)Y, (int)(X + 1), ch] * deltaX * (1 - deltaY)
                                + SourseImage.Data[(int)(Y + 1), (int)X, ch] * (1 - deltaX) * deltaY
                                + SourseImage.Data[(int)(Y + 1), (int)(X + 1), ch] * deltaX * deltaY;

                        if (res > 255) res = 255;
                        else if (res < 0) res = 0;

                        newImage.Data[y, x, ch] = Convert.ToByte(res);

                    }
                }

            /*--My Method
             
            for (int y = 0; y < newImage.Height; y++)
                for (int x = 0; x < newImage.Width; x++)
                {
                    newImage[y, x] = SourseImage[(int)(y / _scaleY), (int)(x / _scaleX)];
                }
           
            */

            return newImage;
        }

        public Image<Bgr,byte> ShiftX(double shiftX, double shiftY)
        {
            var newImage = new Image<Bgr, byte>(SourseImage.Width, SourseImage.Height);

            for (int y = 0; y < SourseImage.Height; y++)
            {
                for (int x = 0; x < (int)(SourseImage.Width - ((1 - (double)y / SourseImage.Height) * (SourseImage.Width * shiftX))); x++)
                {
                    var midX = ((1 - ((double)y / SourseImage.Height)) * (SourseImage.Width * shiftX));
                    var newX = Convert.ToInt32(midX + x);

                    newImage[y, newX] = SourseImage[y, x];
                }

            }
         

            return newImage;
        }

        public Image<Bgr, byte> ShiftY(double shiftX, double shiftY)
        {
            var newImage = new Image<Bgr, byte>(SourseImage.Width, SourseImage.Height);

            for (int x = 0; x < SourseImage.Width; x++)
            {
                for (int y = 0; y < (int)(SourseImage.Height - ((double)x / SourseImage.Width) * (SourseImage.Height * shiftY)); y++)
                {
                    var midY = (((double)x / SourseImage.Width) * (SourseImage.Height * shiftY));
                    var newY = Convert.ToInt32(midY + y);

                    newImage[newY, x] = SourseImage[y, x];
                }
            }
            return newImage;
        }

        public Image<Bgr,byte> Rotate(double angle)
        {
            var resultImage = new Image<Bgr, byte>(SourseImage.Width, SourseImage.Height);

            /*--Исходный код поворота*/

            for (int y = 0; y < SourseImage.Height-1; y++)
                for (int x = 0; x < SourseImage.Width-1; x++)
                {
                    double newX = Math.Cos(angle) * x - Math.Sin(angle) * y;
                    double newY = Math.Sin(angle) * x + Math.Cos(angle) * y;
                    if (newX < 0 || newY < 0) continue;

                    if ((int)newX >= SourseImage.Width-1 || (int)newY >= SourseImage.Height-1) continue;

                    resultImage[(int)newY, (int)newX] = SourseImage[y, x];

                }

            for (int y = 0; y < resultImage.Height - 1; y++)
                for (int x = 0; x < resultImage.Width - 1; x++)
                {
                    /*---Искомые точки---*/
                    double newX = Math.Cos(-angle) * x - Math.Sin(-angle) * y;
                    double newY = Math.Sin(-angle) * x + Math.Cos(-angle) * y;

                    if (newX < 0 || newY < 0) continue;

                    if ((int)newX >= SourseImage.Width-1 || (int)newY >= SourseImage.Height-1) continue;


                    /*---Floor dots---*/
                    int XinSourse = (int)Math.Floor(newX);
                    int YinSourse = (int)Math.Floor(newY);

                    /*---Дистанция от искомой, до ближайшей точки---*/
                    double deltaX = newX - XinSourse;
                    double deltaY = newY - YinSourse;

                    for (int ch = 0; ch < 3; ch++)
                    {
                        var res = SourseImage.Data[(int)newY, (int)newX, ch] * (1 - deltaX) * (1 - deltaY)
                                 + SourseImage.Data[(int)newY, (int)(newX + 1), ch] * deltaX * (1 - deltaY)
                                 + SourseImage.Data[(int)(newY + 1), (int)newX, ch] * (1 - deltaX) * deltaY
                                 + SourseImage.Data[(int)(newY + 1), (int)(newX + 1), ch] * deltaX * deltaY;

                        if (res > 255) res = 255;
                        else if (res < 0) res = 0;

                        resultImage.Data[y, x, ch] = Convert.ToByte(res);
                    }
                }


            //for (int y = 0; y < SourseImage.Height-2; y++)
            //    for (int x = 0; x < SourseImage.Width-2; x++)
            //    {
            //        double newX = Math.Cos(angle) * x - Math.Sin(angle) * y;
            //        double newY = Math.Sin(angle) * x + Math.Cos(angle) * y;

            //        if (newX < 0 || newY < 0) continue;

            //        if ((int)newX >= SourseImage.Width || (int)newY >= SourseImage.Height) continue;

            //        /*---Дистанция от искомой, до ближайшей точки---*/
            //        double deltaX = x - (2*Math.Sin(angle/2));
            //        double deltaY = y - (2 * Math.Sin(angle / 2));

            //        for (int ch = 0; ch < 3; ch++)
            //        {

            //            var res = SourseImage.Data[y, x, ch] * (1 - deltaX) * (1 - deltaY)
            //                    + SourseImage.Data[y, x + 1, ch] * deltaX * (1 - deltaY)
            //                    + SourseImage.Data[y + 1, x, ch] * (1 - deltaX) * deltaY
            //                    + SourseImage.Data[y + 1, x + 1, ch] * deltaX * deltaY;

            //            if (res > 255) res = 255;
            //            else if (res < 0) res = 0;

            //            resultImage.Data[(int)newY, (int)newX, ch] = Convert.ToByte(res);

            //        }
            //    }


            return resultImage;
        }

        public Image<Bgr,byte> Mirror(int qX, int qY)
        {
            var newImage = new Image<Bgr, byte>(SourseImage.Width, SourseImage.Height);
            for (int y = 0; y < SourseImage.Height; y++)
                for (int x = 0; x < SourseImage.Width; x++)
                {

                    int newX;
                    if (qX > 0) newX = x;
                    else newX = x * qX + SourseImage.Width - 1;

                    int newY;
                    if (qY > 0) newY = y;
                    else newY = y * qY + SourseImage.Height - 1;

                    newImage[newY, newX] = SourseImage[y, x];
                }

            return newImage;
        }

        public Image<Bgr, byte> Project(PointF[] p)
        {
            var srcPoints = p;
            
            var destPoints = new PointF[]
            {
                new PointF(0,0),
                new PointF(0,SourseImage.Height - 1),
                new PointF(SourseImage.Width - 1, SourseImage.Height - 1),
                new PointF(SourseImage.Width - 1, 0)
            };

            var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);

            var destImage = new Image<Bgr, byte>(SourseImage.Size);

            CvInvoke.WarpPerspective(SourseImage, destImage, homographyMatrix, destImage.Size);

            return destImage;
        }

        public Image<Bgr, byte> DrawCircle(int x, int y)
        {
            Point center =new Point(x, y);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Red).MCvScalar;
            CvInvoke.Circle(SourseImage, center, radius, color, thickness);

            return SourseImage;
        }

        public Image<Bgr,byte> ClearCircl()
        {
            SourseImage = new Image<Bgr, byte>(FileName);
            return SourseImage;
        }

    }
}
