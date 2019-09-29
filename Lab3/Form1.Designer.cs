namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel_instr = new System.Windows.Forms.Panel();
            this.Save_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.LoadIMG_button = new System.Windows.Forms.Button();
            this.Mir4_button = new System.Windows.Forms.Button();
            this.Mir3_button = new System.Windows.Forms.Button();
            this.Mir2_button = new System.Windows.Forms.Button();
            this.Mir1_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RotateBar_tb = new System.Windows.Forms.TextBox();
            this.Rotate_bar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShiftY_tb = new System.Windows.Forms.TextBox();
            this.ShiftX_tb = new System.Windows.Forms.TextBox();
            this.Shift_bar_Y = new System.Windows.Forms.TrackBar();
            this.Shift_bar_X = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ScaleY_tb = new System.Windows.Forms.TextBox();
            this.ScaleX_tb = new System.Windows.Forms.TextBox();
            this.Scale_bar_Y = new System.Windows.Forms.TrackBar();
            this.Scale_bar_X = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scale_lbl = new System.Windows.Forms.Label();
            this.ImageBox = new Emgu.CV.UI.ImageBox();
            this.Project_button = new System.Windows.Forms.Button();
            this.p00_cb = new System.Windows.Forms.CheckBox();
            this.p01_cb = new System.Windows.Forms.CheckBox();
            this.p10_cb = new System.Windows.Forms.CheckBox();
            this.p11_cb = new System.Windows.Forms.CheckBox();
            this.clear_points = new System.Windows.Forms.Button();
            this.Panel_instr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shift_bar_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shift_bar_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_bar_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_bar_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_instr
            // 
            this.Panel_instr.Controls.Add(this.clear_points);
            this.Panel_instr.Controls.Add(this.p11_cb);
            this.Panel_instr.Controls.Add(this.p10_cb);
            this.Panel_instr.Controls.Add(this.p01_cb);
            this.Panel_instr.Controls.Add(this.p00_cb);
            this.Panel_instr.Controls.Add(this.Project_button);
            this.Panel_instr.Controls.Add(this.Save_button);
            this.Panel_instr.Controls.Add(this.Clear_button);
            this.Panel_instr.Controls.Add(this.LoadIMG_button);
            this.Panel_instr.Controls.Add(this.Mir4_button);
            this.Panel_instr.Controls.Add(this.Mir3_button);
            this.Panel_instr.Controls.Add(this.Mir2_button);
            this.Panel_instr.Controls.Add(this.Mir1_button);
            this.Panel_instr.Controls.Add(this.label6);
            this.Panel_instr.Controls.Add(this.RotateBar_tb);
            this.Panel_instr.Controls.Add(this.Rotate_bar);
            this.Panel_instr.Controls.Add(this.label7);
            this.Panel_instr.Controls.Add(this.label8);
            this.Panel_instr.Controls.Add(this.ShiftY_tb);
            this.Panel_instr.Controls.Add(this.ShiftX_tb);
            this.Panel_instr.Controls.Add(this.Shift_bar_Y);
            this.Panel_instr.Controls.Add(this.Shift_bar_X);
            this.Panel_instr.Controls.Add(this.label3);
            this.Panel_instr.Controls.Add(this.label4);
            this.Panel_instr.Controls.Add(this.label5);
            this.Panel_instr.Controls.Add(this.ScaleY_tb);
            this.Panel_instr.Controls.Add(this.ScaleX_tb);
            this.Panel_instr.Controls.Add(this.Scale_bar_Y);
            this.Panel_instr.Controls.Add(this.Scale_bar_X);
            this.Panel_instr.Controls.Add(this.label2);
            this.Panel_instr.Controls.Add(this.label1);
            this.Panel_instr.Controls.Add(this.Scale_lbl);
            this.Panel_instr.Location = new System.Drawing.Point(676, 12);
            this.Panel_instr.Name = "Panel_instr";
            this.Panel_instr.Size = new System.Drawing.Size(380, 550);
            this.Panel_instr.TabIndex = 1;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(9, 495);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(351, 43);
            this.Save_button.TabIndex = 27;
            this.Save_button.Text = "Save Result";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(188, 14);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(172, 68);
            this.Clear_button.TabIndex = 26;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            // 
            // LoadIMG_button
            // 
            this.LoadIMG_button.Location = new System.Drawing.Point(9, 14);
            this.LoadIMG_button.Name = "LoadIMG_button";
            this.LoadIMG_button.Size = new System.Drawing.Size(172, 68);
            this.LoadIMG_button.TabIndex = 25;
            this.LoadIMG_button.Text = "Load Image";
            this.LoadIMG_button.UseVisualStyleBackColor = true;
            this.LoadIMG_button.Click += new System.EventHandler(this.LoadIMG_button_Click);
            // 
            // Mir4_button
            // 
            this.Mir4_button.Location = new System.Drawing.Point(262, 400);
            this.Mir4_button.Name = "Mir4_button";
            this.Mir4_button.Size = new System.Drawing.Size(68, 23);
            this.Mir4_button.TabIndex = 24;
            this.Mir4_button.Text = "Method 4";
            this.Mir4_button.UseVisualStyleBackColor = true;
            this.Mir4_button.Click += new System.EventHandler(this.Mir4_button_Click);
            // 
            // Mir3_button
            // 
            this.Mir3_button.Location = new System.Drawing.Point(188, 400);
            this.Mir3_button.Name = "Mir3_button";
            this.Mir3_button.Size = new System.Drawing.Size(68, 23);
            this.Mir3_button.TabIndex = 23;
            this.Mir3_button.Text = "Method 3";
            this.Mir3_button.UseVisualStyleBackColor = true;
            this.Mir3_button.Click += new System.EventHandler(this.Mir3_button_Click);
            // 
            // Mir2_button
            // 
            this.Mir2_button.Location = new System.Drawing.Point(113, 400);
            this.Mir2_button.Name = "Mir2_button";
            this.Mir2_button.Size = new System.Drawing.Size(68, 23);
            this.Mir2_button.TabIndex = 22;
            this.Mir2_button.Text = "Method 2";
            this.Mir2_button.UseVisualStyleBackColor = true;
            this.Mir2_button.Click += new System.EventHandler(this.Mir2_button_Click);
            // 
            // Mir1_button
            // 
            this.Mir1_button.Location = new System.Drawing.Point(39, 400);
            this.Mir1_button.Name = "Mir1_button";
            this.Mir1_button.Size = new System.Drawing.Size(68, 23);
            this.Mir1_button.TabIndex = 21;
            this.Mir1_button.Text = "Method 1";
            this.Mir1_button.UseVisualStyleBackColor = true;
            this.Mir1_button.Click += new System.EventHandler(this.Mir1_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mirror";
            // 
            // RotateBar_tb
            // 
            this.RotateBar_tb.Location = new System.Drawing.Point(315, 361);
            this.RotateBar_tb.Name = "RotateBar_tb";
            this.RotateBar_tb.Size = new System.Drawing.Size(45, 20);
            this.RotateBar_tb.TabIndex = 19;
            // 
            // Rotate_bar
            // 
            this.Rotate_bar.LargeChange = 174;
            this.Rotate_bar.Location = new System.Drawing.Point(29, 361);
            this.Rotate_bar.Maximum = 62831;
            this.Rotate_bar.Name = "Rotate_bar";
            this.Rotate_bar.Size = new System.Drawing.Size(290, 45);
            this.Rotate_bar.SmallChange = 174;
            this.Rotate_bar.TabIndex = 17;
            this.Rotate_bar.Scroll += new System.EventHandler(this.Rotate_bar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rotate";
            // 
            // ShiftY_tb
            // 
            this.ShiftY_tb.Location = new System.Drawing.Point(315, 287);
            this.ShiftY_tb.Name = "ShiftY_tb";
            this.ShiftY_tb.Size = new System.Drawing.Size(45, 20);
            this.ShiftY_tb.TabIndex = 13;
            this.ShiftY_tb.Text = "0";
            this.ShiftY_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressedShift);
            // 
            // ShiftX_tb
            // 
            this.ShiftX_tb.Location = new System.Drawing.Point(315, 238);
            this.ShiftX_tb.Name = "ShiftX_tb";
            this.ShiftX_tb.Size = new System.Drawing.Size(45, 20);
            this.ShiftX_tb.TabIndex = 12;
            this.ShiftX_tb.Text = "0";
            this.ShiftX_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressedShift);
            // 
            // Shift_bar_Y
            // 
            this.Shift_bar_Y.LargeChange = 1;
            this.Shift_bar_Y.Location = new System.Drawing.Point(29, 289);
            this.Shift_bar_Y.Maximum = 20;
            this.Shift_bar_Y.Name = "Shift_bar_Y";
            this.Shift_bar_Y.Size = new System.Drawing.Size(290, 45);
            this.Shift_bar_Y.TabIndex = 11;
            this.Shift_bar_Y.Scroll += new System.EventHandler(this.Shift_bar_Y_Scroll);
            // 
            // Shift_bar_X
            // 
            this.Shift_bar_X.LargeChange = 1;
            this.Shift_bar_X.Location = new System.Drawing.Point(29, 238);
            this.Shift_bar_X.Maximum = 20;
            this.Shift_bar_X.Name = "Shift_bar_X";
            this.Shift_bar_X.Size = new System.Drawing.Size(290, 45);
            this.Shift_bar_X.TabIndex = 10;
            this.Shift_bar_X.Scroll += new System.EventHandler(this.Shift_bar_X_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shift";
            // 
            // ScaleY_tb
            // 
            this.ScaleY_tb.Location = new System.Drawing.Point(315, 164);
            this.ScaleY_tb.Name = "ScaleY_tb";
            this.ScaleY_tb.Size = new System.Drawing.Size(45, 20);
            this.ScaleY_tb.TabIndex = 6;
            this.ScaleY_tb.Text = "1";
            this.ScaleY_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // ScaleX_tb
            // 
            this.ScaleX_tb.Location = new System.Drawing.Point(315, 115);
            this.ScaleX_tb.Name = "ScaleX_tb";
            this.ScaleX_tb.Size = new System.Drawing.Size(45, 20);
            this.ScaleX_tb.TabIndex = 5;
            this.ScaleX_tb.Text = "1";
            this.ScaleX_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // Scale_bar_Y
            // 
            this.Scale_bar_Y.LargeChange = 1;
            this.Scale_bar_Y.Location = new System.Drawing.Point(29, 166);
            this.Scale_bar_Y.Maximum = 20;
            this.Scale_bar_Y.Minimum = 1;
            this.Scale_bar_Y.Name = "Scale_bar_Y";
            this.Scale_bar_Y.Size = new System.Drawing.Size(290, 45);
            this.Scale_bar_Y.TabIndex = 4;
            this.Scale_bar_Y.Value = 10;
            this.Scale_bar_Y.Scroll += new System.EventHandler(this.Scale_bar_Y_Scroll);
            // 
            // Scale_bar_X
            // 
            this.Scale_bar_X.LargeChange = 1;
            this.Scale_bar_X.Location = new System.Drawing.Point(29, 115);
            this.Scale_bar_X.Maximum = 20;
            this.Scale_bar_X.Minimum = 1;
            this.Scale_bar_X.Name = "Scale_bar_X";
            this.Scale_bar_X.Size = new System.Drawing.Size(290, 45);
            this.Scale_bar_X.TabIndex = 3;
            this.Scale_bar_X.Value = 10;
            this.Scale_bar_X.Scroll += new System.EventHandler(this.Scale_bar_X_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // Scale_lbl
            // 
            this.Scale_lbl.AutoSize = true;
            this.Scale_lbl.Location = new System.Drawing.Point(6, 99);
            this.Scale_lbl.Name = "Scale_lbl";
            this.Scale_lbl.Size = new System.Drawing.Size(34, 13);
            this.Scale_lbl.TabIndex = 0;
            this.Scale_lbl.Text = "Scale";
            // 
            // ImageBox
            // 
            this.ImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ImageBox.Location = new System.Drawing.Point(12, 26);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(658, 536);
            this.ImageBox.TabIndex = 2;
            this.ImageBox.TabStop = false;
            this.ImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseClick);
            // 
            // Project_button
            // 
            this.Project_button.Enabled = false;
            this.Project_button.Location = new System.Drawing.Point(9, 467);
            this.Project_button.Name = "Project_button";
            this.Project_button.Size = new System.Drawing.Size(351, 22);
            this.Project_button.TabIndex = 28;
            this.Project_button.Text = "Projection";
            this.Project_button.UseVisualStyleBackColor = true;
            this.Project_button.Click += new System.EventHandler(this.Project_button_Click);
            // 
            // p00_cb
            // 
            this.p00_cb.AutoSize = true;
            this.p00_cb.Enabled = false;
            this.p00_cb.Location = new System.Drawing.Point(9, 444);
            this.p00_cb.Name = "p00_cb";
            this.p00_cb.Size = new System.Drawing.Size(44, 17);
            this.p00_cb.TabIndex = 29;
            this.p00_cb.Text = "p00";
            this.p00_cb.UseVisualStyleBackColor = true;
            // 
            // p01_cb
            // 
            this.p01_cb.AutoSize = true;
            this.p01_cb.Enabled = false;
            this.p01_cb.Location = new System.Drawing.Point(52, 444);
            this.p01_cb.Name = "p01_cb";
            this.p01_cb.Size = new System.Drawing.Size(44, 17);
            this.p01_cb.TabIndex = 30;
            this.p01_cb.Text = "p01";
            this.p01_cb.UseVisualStyleBackColor = true;
            // 
            // p10_cb
            // 
            this.p10_cb.AutoSize = true;
            this.p10_cb.Enabled = false;
            this.p10_cb.Location = new System.Drawing.Point(94, 444);
            this.p10_cb.Name = "p10_cb";
            this.p10_cb.Size = new System.Drawing.Size(44, 17);
            this.p10_cb.TabIndex = 31;
            this.p10_cb.Text = "p10";
            this.p10_cb.UseVisualStyleBackColor = true;
            // 
            // p11_cb
            // 
            this.p11_cb.AutoSize = true;
            this.p11_cb.Enabled = false;
            this.p11_cb.Location = new System.Drawing.Point(137, 444);
            this.p11_cb.Name = "p11_cb";
            this.p11_cb.Size = new System.Drawing.Size(44, 17);
            this.p11_cb.TabIndex = 32;
            this.p11_cb.Text = "p11";
            this.p11_cb.UseVisualStyleBackColor = true;
            // 
            // clear_points
            // 
            this.clear_points.Location = new System.Drawing.Point(187, 440);
            this.clear_points.Name = "clear_points";
            this.clear_points.Size = new System.Drawing.Size(172, 22);
            this.clear_points.TabIndex = 33;
            this.clear_points.Text = "Clear Points";
            this.clear_points.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 574);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.Panel_instr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_instr.ResumeLayout(false);
            this.Panel_instr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shift_bar_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shift_bar_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_bar_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_bar_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_instr;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button LoadIMG_button;
        private System.Windows.Forms.Button Mir4_button;
        private System.Windows.Forms.Button Mir3_button;
        private System.Windows.Forms.Button Mir2_button;
        private System.Windows.Forms.Button Mir1_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RotateBar_tb;
        private System.Windows.Forms.TrackBar Rotate_bar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ShiftY_tb;
        private System.Windows.Forms.TextBox ShiftX_tb;
        private System.Windows.Forms.TrackBar Shift_bar_Y;
        private System.Windows.Forms.TrackBar Shift_bar_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ScaleY_tb;
        private System.Windows.Forms.TextBox ScaleX_tb;
        private System.Windows.Forms.TrackBar Scale_bar_Y;
        private System.Windows.Forms.TrackBar Scale_bar_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Scale_lbl;
        private Emgu.CV.UI.ImageBox ImageBox;
        private System.Windows.Forms.Button Project_button;
        private System.Windows.Forms.Button clear_points;
        private System.Windows.Forms.CheckBox p11_cb;
        private System.Windows.Forms.CheckBox p10_cb;
        private System.Windows.Forms.CheckBox p01_cb;
        private System.Windows.Forms.CheckBox p00_cb;
    }
}

