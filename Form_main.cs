using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Get_Screen_Show;
using Screen_Shot_Image_List;
using Picture_Change;
using Draw_Point;
using Draw_Line;
using Draw_Angle;
using Draw_Curve;
using Draw_Rectangle;
using corrected_Parameter_Change;
//using _History;

namespace 界面图片编辑
{
    public partial class Main_Form : Form
    {
        //修正参数
        private double changeParameter = 0.266;
        private double imageParameter = 1;
        private double correctedParameter = 1;

        //对象实例化
        GetScreenShow GSS = new GetScreenShow();
        ScreenShotImageList SSIL = new ScreenShotImageList();
        PictureChange PC = new PictureChange();
        DrawPoint DP = new DrawPoint();
        DrawLine DL = new DrawLine();
        DrawCurve DC = new DrawCurve();
        DrawAngle DA = new DrawAngle();
        DrawRectangle DR = new DrawRectangle();
        correctedParameterChange CPC = new correctedParameterChange();
        //History H = new History();

        //绘图状态
        private bool is_draw_point = false;
        private bool is_draw_line = false;
        private bool is_draw_angle = false;
        private bool is_draw_rectangle = false;
        private bool is_draw_curve = false;
        //
        int Line_times = 0;

        //操作图像
        private Image currentImage;

        public Main_Form()
        {
            InitializeComponent();

            DP.pointAddOperation(Main_PictureBox);
            DL.lineAddOperation(Main_PictureBox, correctedParameter);
            DC.curveAddOperation(Main_PictureBox, correctedParameter);
            DA.angleAddOperation(Main_PictureBox);
            DR.rectangleAddOperation(Main_PictureBox, correctedParameter);
            //H.HistoryAddPicturebox(Main_PictureBox);
            GSS.AddPictureBox(Main_PictureBox);
        }

        //——————————————————————————————————————————————打开图片——————————————————————————————————————————————
        private void OpenDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFile.FileName);
                Main_PictureBox.Image = image;
                //imageParameter = CPC.parameter(image, Main_PictureBox.Width, Main_PictureBox.Height);
            }

            //设置主操作图形
            currentImage = Main_PictureBox.Image;
        }

        //——————————————————————————————————————————————保存图片——————————————————————————————————————————————
        private void Save_Picture_Click(object sender, EventArgs e)
        {
            Image SaveImage = GSS.CaptureScreen();

            // 创建SaveFileDialog实例
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // 设置保存文件对话框的初始目录和文件名过滤器
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";

            // 显示保存文件对话框
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取要保存的图像文件名
                string fileName = saveFileDialog.FileName;

                // 将PictureBox控件中的图像保存到文件中
                SaveImage.Save(fileName);
            }
        }

        //————————————————————————————————————————————退出程序按钮————————————————————————————————————————————
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //————————————————————————————————————————————截取显示图片————————————————————————————————————————————
        private void Screen_Shot_Click(object sender, EventArgs e)
        {
            Image ScreemShotImage = GSS.CaptureScreen();
            SSIL.ScreenShotImageOperation(ScreemShotImage, ScreenShotHistoryList, Main_PictureBox);
        }

        //——————————————————————————————————————————————拖动条操作———————————————————————————————————————————————
        private void LIGHTNESS_MouseUp(object sender, MouseEventArgs e)
        {
            CONTRAST.Value = 50;
            RGB_R.Value = 0;
            RGB_G.Value = 0;
            RGB_B.Value = 0;
            Main_PictureBox.Image = PC.Picture_change_operate(PictureChange.CHANGE_TYPE.LIGHT, LIGHTNESS.Value, currentImage);
        }

        private void CONTRAST_MouseUp(object sender, MouseEventArgs e)
        {
            LIGHTNESS.Value = 0;
            RGB_R.Value = 0;
            RGB_G.Value = 0;
            RGB_B.Value = 0;
            Main_PictureBox.Image = PC.Picture_change_operate(PictureChange.CHANGE_TYPE.CONTRAST, CONTRAST.Value, currentImage);
        }

        private void RGB_R_MouseUp(object sender, MouseEventArgs e)
        {
            LIGHTNESS.Value = 0;
            CONTRAST.Value = 50;
            RGB_G.Value = 0;
            RGB_B.Value = 0;
            Main_PictureBox.Image = PC.Picture_change_operate(PictureChange.CHANGE_TYPE.RED, RGB_R.Value, currentImage);

        }

        private void RGB_G_MouseUp(object sender, MouseEventArgs e)
        {
            LIGHTNESS.Value = 0;
            CONTRAST.Value = 50;
            RGB_R.Value = 0;
            RGB_B.Value = 0;
            Main_PictureBox.Image = PC.Picture_change_operate(PictureChange.CHANGE_TYPE.GREEN, RGB_G.Value, currentImage);

        }

        private void RGB_B_MouseUp(object sender, MouseEventArgs e)
        {
            LIGHTNESS.Value = 0;
            CONTRAST.Value = 50;
            RGB_R.Value = 0;
            RGB_G.Value = 0;
            Main_PictureBox.Image = PC.Picture_change_operate(PictureChange.CHANGE_TYPE.BLUE, RGB_B.Value, currentImage);

        }

        //——————————————————————————————————————————————画图操作———————————————————————————————————————————————
        private void DrawPoint_Click(object sender, EventArgs e)
        {
            DrawPoint.Text = DrawPoint.Text == "" ? "ON" : "";
            DrawAngle.Text = "";
            DrawRectangle.Text = "";
            DrawCurve.Text = "";
            DrawLine.Text = "";

            is_draw_point = is_draw_point ? false : true;
            is_draw_line = false;
            is_draw_rectangle = false;
            is_draw_angle = false;
            is_draw_curve = false;

            DP.AddOrRemoveEvent(false);
            DC.AddOrRemoveEvent(false);
            DL.AddOrRemoveEvent(false);
            DR.AddOrRemoveEvent(false);

            if (is_draw_point)
            {
                DP.AddOrRemoveEvent(true);
            }
            else
            {
                DP.AddOrRemoveEvent(false);
            }
        }

        private void DrawAngle_Click(object sender, EventArgs e)
        {
            DrawAngle.Text = DrawAngle.Text == "" ? "ON" : "";
            DrawPoint.Text = "";
            DrawRectangle.Text = "";
            DrawCurve.Text = "";
            DrawLine.Text = "";

            is_draw_angle = is_draw_angle ? false : true;
            is_draw_point = false;
            is_draw_line = false;
            is_draw_rectangle = false;
            is_draw_curve = false;

            DP.AddOrRemoveEvent(false);
            DC.AddOrRemoveEvent(false);
            DL.AddOrRemoveEvent(false);
            DR.AddOrRemoveEvent(false);

            if (is_draw_angle)
            {
                DA.AddOrRemoveEvent(true);
            }
            else
            {
                DA.AddOrRemoveEvent(false);
            }
        }

        private void DrawRectangle_Click(object sender, EventArgs e)
        {
            DrawRectangle.Text = DrawRectangle.Text == "" ? "ON" : "";
            DrawPoint.Text = "";
            DrawAngle.Text = "";
            DrawCurve.Text = "";
            DrawLine.Text = "";

            is_draw_rectangle = is_draw_rectangle ? false : true;
            is_draw_point = false;
            is_draw_line = false;
            is_draw_angle = false;
            is_draw_curve = false;

            DP.AddOrRemoveEvent(false);
            DL.AddOrRemoveEvent(false);
            DA.AddOrRemoveEvent(false);
            DC.AddOrRemoveEvent(false);

            if (is_draw_rectangle)
            {
                DR.AddOrRemoveEvent(true);
            }
            else
            {
                DR.AddOrRemoveEvent(false);
            }
        }

        private void DrawCurve_Click(object sender, EventArgs e)
        {
            DrawCurve.Text = DrawCurve.Text == "" ? "ON" : "";
            DrawPoint.Text = "";
            DrawAngle.Text = "";
            DrawRectangle.Text = "";
            DrawLine.Text = "";

            is_draw_curve = is_draw_curve ? false : true;
            is_draw_point = false;
            is_draw_line = false;
            is_draw_rectangle = false;
            is_draw_angle = false;

            DP.AddOrRemoveEvent(false);
            DL.AddOrRemoveEvent(false);
            DA.AddOrRemoveEvent(false);
            DR.AddOrRemoveEvent(false);

            if (is_draw_curve)
            {
                DC.AddOrRemoveEvent(true);
            }
            else
            {
                DC.AddOrRemoveEvent(false);
            }
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            DrawLine.Text = DrawLine.Text == "" ? "ON" : "";
            DrawPoint.Text = "";
            DrawAngle.Text = "";
            DrawRectangle.Text = "";
            DrawCurve.Text = "";

            is_draw_line = is_draw_line ? false : true;
            is_draw_point = false;
            is_draw_rectangle = false;
            is_draw_angle = false;
            is_draw_curve = false;

            DP.AddOrRemoveEvent(false);
            DC.AddOrRemoveEvent(false);
            DA.AddOrRemoveEvent(false);
            DR.AddOrRemoveEvent(false);

            if (is_draw_line)
            {
                DL.AddOrRemoveEvent(true);
            }
            else
            {
                DL.AddOrRemoveEvent(false);
            }
        }

        //———————————————————————————————————————————倍率选择——————————————————————————————————————————
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //下拉框的不同选择执行不同代码的框架
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    correctedParameter = imageParameter / 1 * changeParameter;
                    Change();
                    break;
                case 1:
                    correctedParameter = imageParameter / 6 * changeParameter;
                    Change();
                    break;
                case 2:
                    correctedParameter = imageParameter / 16 * changeParameter;
                    Change();
                    break;
                case 3:
                    correctedParameter = imageParameter / 25 * changeParameter;
                    Change();
                    break;
                case 4:
                    correctedParameter = imageParameter / 40 * changeParameter;
                    Change();
                    break;
                default:
                    break;
            }
        }

        //change参数修正
        private void Change()
        {
            DC.change = correctedParameter;
            DL.change = correctedParameter;
            DR.change = correctedParameter;
        }

        //——————————————————————————————————————撤回、前进操作—————————————————————————————————————
        private void History_Back_Click(object sender, EventArgs e)
        {/*
            H.changeImageLast();
            currentImage=Main_PictureBox.Image;*/
        }

        private void History_Forward_Click(object sender, EventArgs e)
        {/*
            H.changeImageNext();
            currentImage = Main_PictureBox.Image;*/
        }

        private void CONTRAST_Scroll(object sender, EventArgs e)
        {

        }
    }
}
