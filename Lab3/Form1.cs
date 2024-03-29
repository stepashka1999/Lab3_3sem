﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Lab3
{
    public partial class Form1 : Form
    {
        PointF[] p = new PointF[4];
        int cb = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private TransformIMG res;

        private void LoadIMG_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();

            if(result==DialogResult.OK)
            {
                res = new TransformIMG(OFD.FileName); 
            }

            ImageBox.Image = res.GetImg().Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);

        }

        private void Scale_bar_X_Scroll(object sender, EventArgs e)
        {
            ScaleX_tb.Text = (((float)Scale_bar_X.Value)/ 10).ToString();
            ImageBox.Image = res.Scale(((float)Scale_bar_X.Value) / 10, ((float)Scale_bar_Y.Value) / 10); //.Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Scale_bar_Y_Scroll(object sender, EventArgs e)
        {
                ScaleY_tb.Text = (Convert.ToDouble(Scale_bar_Y.Value) / 10).ToString();
            ImageBox.Image = res.Scale(Convert.ToDouble(Scale_bar_X.Value) / 10, Convert.ToDouble(Scale_bar_Y.Value) / 10); //.Resize(ImageBox.Width, ImageBox.Height, Inter.Linear); ;
        }

        //Press Enter for SCALE
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Scale_bar_X.Value = (int)(Convert.ToDouble(ScaleX_tb.Text) * 10);
                Scale_bar_Y.Value = (int)(Convert.ToDouble(ScaleY_tb.Text) * 10);
                ImageBox.Image = res.Scale(Convert.ToDouble(Scale_bar_X.Value) / 10, Convert.ToDouble(Scale_bar_Y.Value) / 10);
            }
        }

        //Press Enter fofr Shift
        private void KeyPressedShift(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Shift_bar_X.Value = (int)(Convert.ToDouble(ShiftX_tb.Text) * 10);
                Shift_bar_Y.Value = (int)(Convert.ToDouble(ShiftY_tb.Text) * 10);
                ImageBox.Image = res.Scale(Convert.ToDouble(Shift_bar_X.Value) / 10, Convert.ToDouble(Shift_bar_Y.Value) / 10);
            }
        }

        private void Shift_bar_X_Scroll(object sender, EventArgs e)
        {
            ShiftX_tb.Text = (Convert.ToDouble(Shift_bar_X.Value) / 10).ToString();

            //ImageBox.Image = res.ShiftX((Convert.ToDouble(Shift_bar_X.Value) / 10), (Convert.ToDouble(Shift_bar_Y.Value) / 10)).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
            ImageBox.Image = res.ShiftX((Convert.ToDouble(Shift_bar_X.Value) / 10), (Convert.ToDouble(Shift_bar_Y.Value) / 10)).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Shift_bar_Y_Scroll(object sender, EventArgs e)
        {
            ShiftY_tb.Text = (Convert.ToDouble(Shift_bar_Y.Value) / 10).ToString();
            //ImageBox.Image = res.ShiftY((Convert.ToDouble(Shift_bar_X.Value) / 10), (Convert.ToDouble(Shift_bar_Y.Value) / 10)).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
            ImageBox.Image = res.ShiftY((Convert.ToDouble(Shift_bar_X.Value) / 10), (Convert.ToDouble(Shift_bar_Y.Value) / 10)).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Rotate_bar_Scroll(object sender, EventArgs e)
        {
            ImageBox.Image = res.Rotate(Rotate_bar.Value * (Math.PI / 180)).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
            RotateBar_tb.Text = Rotate_bar.Value.ToString();
        }

        private void Mir1_button_Click(object sender, EventArgs e)
        {
            ImageBox.Image = res.Mirror(1,1).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Mir2_button_Click(object sender, EventArgs e)
        {
            ImageBox.Image = res.Mirror(-1, 1).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Mir3_button_Click(object sender, EventArgs e)
        {
            ImageBox.Image = res.Mirror(1, -1).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Mir4_button_Click(object sender, EventArgs e)
        {
            ImageBox.Image = res.Mirror(-1, -1).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();

            if(SFD.ShowDialog() == DialogResult.OK)
            {
                var result = ImageBox.Image.GetInputArray().GetMat();

                var resIMG = result.ToImage<Bgr, byte>();

                resIMG.Save($@"{SFD.FileName}.jpg");
            }

        }

        private void ImageBox_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int)(e.Location.X / ImageBox.ZoomScale);
            int y = (int)(e.Location.Y / ImageBox.ZoomScale);

            if (cb > 3)
            {
                cb = 0;
                ImageBox.Image = res.ClearCircl();
                Project_button.Enabled = false;
            }

            p[cb].X = x;
            p[cb].Y = y;

            
            switch (cb)
            {
                case 0:
                    p00_cb.Checked = Enabled;
                    Project_button.Enabled = false;
                    break;
                case 1:
                    p01_cb.Checked = true;
                    break;
                case 2:
                    p10_cb.Checked = true;
                    break;
                case 3:
                    p11_cb.Checked = true;
                    Project_button.Enabled = true;
                    break;
            }

            cb++;
            ImageBox.Image = res.DrawCircle(x, y);

        }

        private void Project_button_Click(object sender, EventArgs e)
        {
            res.ClearCircl();
            ImageBox.Image = res.Project(p);
        }

        private void Clear_points_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                p[i].X = 0;
                p[i].Y = 0;
            }

            p00_cb.Checked = false;
            p01_cb.Checked = false;
            p10_cb.Checked = false;
            p11_cb.Checked = false;

            Project_button.Enabled = false;

            cb = 0;
            ImageBox.Image = res.ClearCircl();
        }

        private void RotateBar_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Rotate_bar.Value = Convert.ToInt32(RotateBar_tb.Text);
                ImageBox.Image = res.Rotate(Rotate_bar.Value * (Math.PI / 180)).Resize(ImageBox.Width, ImageBox.Height, Inter.Linear);
            }
        }
    }
}
