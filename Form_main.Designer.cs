namespace 界面图片编辑
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Main_PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenDocument = new System.Windows.Forms.Button();
            this.Save_Picture = new System.Windows.Forms.Button();
            this.Screen_Shot = new System.Windows.Forms.Button();
            this.History_Back = new System.Windows.Forms.Button();
            this.History_Forward = new System.Windows.Forms.Button();
            this.DrawLine = new System.Windows.Forms.Button();
            this.DrawCurve = new System.Windows.Forms.Button();
            this.DrawRectangle = new System.Windows.Forms.Button();
            this.DrawAngle = new System.Windows.Forms.Button();
            this.DrawPoint = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RGB_R = new System.Windows.Forms.TrackBar();
            this.RGB_G = new System.Windows.Forms.TrackBar();
            this.RGB_B = new System.Windows.Forms.TrackBar();
            this.ScreenShotHistoryList = new System.Windows.Forms.ListView();
            this.Exit = new System.Windows.Forms.Button();
            this.LIGHTNESS = new System.Windows.Forms.TrackBar();
            this.CONTRAST = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIGHTNESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTRAST)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_PictureBox
            // 
            this.Main_PictureBox.BackColor = System.Drawing.Color.White;
            this.Main_PictureBox.Location = new System.Drawing.Point(620, 78);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(2251, 1314);
            this.Main_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Main_PictureBox.TabIndex = 0;
            this.Main_PictureBox.TabStop = false;
            // 
            // OpenDocument
            // 
            this.OpenDocument.BackColor = System.Drawing.Color.White;
            this.OpenDocument.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenDocument.BackgroundImage")));
            this.OpenDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenDocument.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenDocument.Location = new System.Drawing.Point(12, 12);
            this.OpenDocument.Name = "OpenDocument";
            this.OpenDocument.Size = new System.Drawing.Size(60, 60);
            this.OpenDocument.TabIndex = 1;
            this.OpenDocument.UseVisualStyleBackColor = false;
            this.OpenDocument.Click += new System.EventHandler(this.OpenDocument_Click);
            // 
            // Save_Picture
            // 
            this.Save_Picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_Picture.BackgroundImage")));
            this.Save_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Save_Picture.Location = new System.Drawing.Point(74, 12);
            this.Save_Picture.Name = "Save_Picture";
            this.Save_Picture.Size = new System.Drawing.Size(60, 60);
            this.Save_Picture.TabIndex = 2;
            this.Save_Picture.UseVisualStyleBackColor = true;
            this.Save_Picture.Click += new System.EventHandler(this.Save_Picture_Click);
            // 
            // Screen_Shot
            // 
            this.Screen_Shot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Screen_Shot.BackgroundImage")));
            this.Screen_Shot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Screen_Shot.Location = new System.Drawing.Point(136, 12);
            this.Screen_Shot.Name = "Screen_Shot";
            this.Screen_Shot.Size = new System.Drawing.Size(60, 60);
            this.Screen_Shot.TabIndex = 3;
            this.Screen_Shot.UseVisualStyleBackColor = true;
            this.Screen_Shot.Click += new System.EventHandler(this.Screen_Shot_Click);
            // 
            // History_Back
            // 
            this.History_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History_Back.BackgroundImage")));
            this.History_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.History_Back.Location = new System.Drawing.Point(198, 12);
            this.History_Back.Name = "History_Back";
            this.History_Back.Size = new System.Drawing.Size(60, 60);
            this.History_Back.TabIndex = 4;
            this.History_Back.UseVisualStyleBackColor = true;
            this.History_Back.Click += new System.EventHandler(this.History_Back_Click);
            // 
            // History_Forward
            // 
            this.History_Forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History_Forward.BackgroundImage")));
            this.History_Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.History_Forward.Location = new System.Drawing.Point(260, 12);
            this.History_Forward.Name = "History_Forward";
            this.History_Forward.Size = new System.Drawing.Size(60, 60);
            this.History_Forward.TabIndex = 5;
            this.History_Forward.UseVisualStyleBackColor = true;
            this.History_Forward.Click += new System.EventHandler(this.History_Forward_Click);
            // 
            // DrawLine
            // 
            this.DrawLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawLine.BackgroundImage")));
            this.DrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawLine.Location = new System.Drawing.Point(384, 12);
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(60, 60);
            this.DrawLine.TabIndex = 6;
            this.DrawLine.UseVisualStyleBackColor = true;
            this.DrawLine.Click += new System.EventHandler(this.DrawLine_Click);
            // 
            // DrawCurve
            // 
            this.DrawCurve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawCurve.BackgroundImage")));
            this.DrawCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawCurve.Location = new System.Drawing.Point(446, 12);
            this.DrawCurve.Name = "DrawCurve";
            this.DrawCurve.Size = new System.Drawing.Size(60, 60);
            this.DrawCurve.TabIndex = 7;
            this.DrawCurve.UseVisualStyleBackColor = true;
            this.DrawCurve.Click += new System.EventHandler(this.DrawCurve_Click);
            // 
            // DrawRectangle
            // 
            this.DrawRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawRectangle.BackgroundImage")));
            this.DrawRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawRectangle.Location = new System.Drawing.Point(508, 13);
            this.DrawRectangle.Name = "DrawRectangle";
            this.DrawRectangle.Size = new System.Drawing.Size(60, 60);
            this.DrawRectangle.TabIndex = 8;
            this.DrawRectangle.UseVisualStyleBackColor = true;
            this.DrawRectangle.Click += new System.EventHandler(this.DrawRectangle_Click);
            // 
            // DrawAngle
            // 
            this.DrawAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawAngle.BackgroundImage")));
            this.DrawAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawAngle.Location = new System.Drawing.Point(570, 12);
            this.DrawAngle.Name = "DrawAngle";
            this.DrawAngle.Size = new System.Drawing.Size(60, 60);
            this.DrawAngle.TabIndex = 9;
            this.DrawAngle.UseVisualStyleBackColor = true;
            this.DrawAngle.Click += new System.EventHandler(this.DrawAngle_Click);
            // 
            // DrawPoint
            // 
            this.DrawPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawPoint.BackgroundImage")));
            this.DrawPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawPoint.Location = new System.Drawing.Point(322, 13);
            this.DrawPoint.Name = "DrawPoint";
            this.DrawPoint.Size = new System.Drawing.Size(60, 60);
            this.DrawPoint.TabIndex = 10;
            this.DrawPoint.UseVisualStyleBackColor = true;
            this.DrawPoint.Click += new System.EventHandler(this.DrawPoint_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 倍",
            "6 倍",
            "16倍",
            "25倍",
            "40倍"});
            this.comboBox1.Location = new System.Drawing.Point(916, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 45);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(688, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "放大倍数：";
            // 
            // RGB_R
            // 
            this.RGB_R.Location = new System.Drawing.Point(174, 524);
            this.RGB_R.Maximum = 100;
            this.RGB_R.Minimum = -100;
            this.RGB_R.Name = "RGB_R";
            this.RGB_R.Size = new System.Drawing.Size(437, 90);
            this.RGB_R.TabIndex = 13;
            this.RGB_R.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RGB_R_MouseUp);
            // 
            // RGB_G
            // 
            this.RGB_G.Location = new System.Drawing.Point(174, 620);
            this.RGB_G.Maximum = 100;
            this.RGB_G.Minimum = -100;
            this.RGB_G.Name = "RGB_G";
            this.RGB_G.Size = new System.Drawing.Size(437, 90);
            this.RGB_G.TabIndex = 14;
            this.RGB_G.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RGB_G_MouseUp);
            // 
            // RGB_B
            // 
            this.RGB_B.Location = new System.Drawing.Point(174, 716);
            this.RGB_B.Maximum = 100;
            this.RGB_B.Minimum = -100;
            this.RGB_B.Name = "RGB_B";
            this.RGB_B.Size = new System.Drawing.Size(437, 90);
            this.RGB_B.TabIndex = 15;
            this.RGB_B.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RGB_B_MouseUp);
            // 
            // ScreenShotHistoryList
            // 
            this.ScreenShotHistoryList.HideSelection = false;
            this.ScreenShotHistoryList.Location = new System.Drawing.Point(12, 1398);
            this.ScreenShotHistoryList.Name = "ScreenShotHistoryList";
            this.ScreenShotHistoryList.Size = new System.Drawing.Size(2856, 390);
            this.ScreenShotHistoryList.TabIndex = 16;
            this.ScreenShotHistoryList.UseCompatibleStateImageBehavior = false;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(2817, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(60, 60);
            this.Exit.TabIndex = 17;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LIGHTNESS
            // 
            this.LIGHTNESS.Location = new System.Drawing.Point(174, 143);
            this.LIGHTNESS.Maximum = 100;
            this.LIGHTNESS.Minimum = -100;
            this.LIGHTNESS.Name = "LIGHTNESS";
            this.LIGHTNESS.Size = new System.Drawing.Size(437, 90);
            this.LIGHTNESS.TabIndex = 18;
            this.LIGHTNESS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LIGHTNESS_MouseUp);
            // 
            // CONTRAST
            // 
            this.CONTRAST.Location = new System.Drawing.Point(174, 239);
            this.CONTRAST.Maximum = 100;
            this.CONTRAST.Name = "CONTRAST";
            this.CONTRAST.Size = new System.Drawing.Size(437, 90);
            this.CONTRAST.TabIndex = 19;
            this.CONTRAST.Value = 50;
            this.CONTRAST.Scroll += new System.EventHandler(this.CONTRAST_Scroll);
            this.CONTRAST.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CONTRAST_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "红";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "绿";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(53, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "蓝";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 23;
            this.label5.Text = "亮  度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 24;
            this.label6.Text = "对比度";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2880, 1800);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CONTRAST);
            this.Controls.Add(this.LIGHTNESS);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ScreenShotHistoryList);
            this.Controls.Add(this.RGB_B);
            this.Controls.Add(this.RGB_G);
            this.Controls.Add(this.RGB_R);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DrawPoint);
            this.Controls.Add(this.DrawAngle);
            this.Controls.Add(this.DrawRectangle);
            this.Controls.Add(this.DrawCurve);
            this.Controls.Add(this.DrawLine);
            this.Controls.Add(this.History_Forward);
            this.Controls.Add(this.History_Back);
            this.Controls.Add(this.Screen_Shot);
            this.Controls.Add(this.Save_Picture);
            this.Controls.Add(this.OpenDocument);
            this.Controls.Add(this.Main_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIGHTNESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTRAST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Main_PictureBox;
        private System.Windows.Forms.Button OpenDocument;
        private System.Windows.Forms.Button Save_Picture;
        private System.Windows.Forms.Button Screen_Shot;
        private System.Windows.Forms.Button History_Back;
        private System.Windows.Forms.Button History_Forward;
        private System.Windows.Forms.Button DrawLine;
        private System.Windows.Forms.Button DrawCurve;
        private System.Windows.Forms.Button DrawRectangle;
        private System.Windows.Forms.Button DrawAngle;
        private System.Windows.Forms.Button DrawPoint;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar RGB_R;
        private System.Windows.Forms.TrackBar RGB_G;
        private System.Windows.Forms.TrackBar RGB_B;
        private System.Windows.Forms.ListView ScreenShotHistoryList;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TrackBar LIGHTNESS;
        private System.Windows.Forms.TrackBar CONTRAST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

