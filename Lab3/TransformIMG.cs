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
        private Image<Bgr, byte> ResImageCircl;

        public TransformIMG(string FileName)
        {
            SourseImage = new Image<Bgr, byte>(FileName);
            ResImageCircl = new Image<Bgr, byte>(FileName);
        }

        public Image<Bgr, byte> GetImg()
        {
            return SourseImage;
        }

        //Выдает ошибку. "Индекс за пределами массива"
        public Image<Bgr,byte> Scale(double _scaleX, double _scaleY)
        {
            var newImage = new Image<Bgr, byte>((int)(SourseImage.Width * _scaleX),(int)(SourseImage.Height * _scaleY));       
            
            /*--DeafoltScale
             
            for (int y = 0; y < SourseImage.Height; y++)
                for(int x = 0; x < SourseImage.Width; x++)
                {
                    newImage[(int)(y * _scaleY), (int)(x * _scaleX)] = SourseImage[y, x];
                }
            
            */

            for (int y = 0; y < newImage.Height - 1; y++)
                for (int x = 0; x < newImage.Width - 1; x++)
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

                        var res = SourseImage.Data[YinSourse, XinSourse, ch] * (1 - deltaX) * (1 - deltaY)
                                + SourseImage.Data[YinSourse, XinSourse + 1, ch] * deltaX * (1 - deltaY)
                                + SourseImage.Data[YinSourse + 1, XinSourse, ch] * (1 - deltaX) * deltaY
                                + SourseImage.Data[YinSourse + 1, XinSourse + 1, ch] * deltaX * deltaY;

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

        public Image<Bgr,byte> ShiftDeafolt(int shiftX, int shiftY)
        {
            var newImage = new Image<Bgr, byte>(SourseImage.Width, SourseImage.Height);

            for (int y = 0; y < SourseImage.Height - shiftY; y++)
                for (int x = 0; x < SourseImage.Width - shiftX; x++)
                {
                    newImage[y + shiftY, x + shiftX] = SourseImage[y, x];
                }

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
            for (int y = 0; y < SourseImage.Height; y++)
                for(int x = 0; x < SourseImage.Width; x++)
                {
                    double newX = Math.Cos(angle) * x - Math.Sin(angle) * y;
                    double newY = Math.Sin(angle) * x + Math.Cos(angle) * y;
                    if (newX < 0 || newY < 0) continue;

                    if ((int)newX >= SourseImage.Width || (int)newY >= SourseImage.Height) continue;

                    resultImage[(int)newY, (int)newX] = SourseImage[y, x];
                }

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
            CvInvoke.Circle(ResImageCircl, center, radius, color, thickness);

            return ResImageCircl;
        }

    }
}
