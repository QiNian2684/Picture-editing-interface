using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Get_Screen_Show;
using System.Windows.Forms;

namespace _History
{
    internal class History
    {
        private GetScreenShow GSS = new GetScreenShow();
        private List<Image> historyImage = new List<Image>();
        private PictureBox pictureBox1;
        private int pointer = 0;

        public void HistoryAddPicturebox(PictureBox pictureBoxIn)
        {
            pictureBox1 = pictureBoxIn;
        }

        //截取屏幕，并添加进列表中
        public void AddHistoryImage()
        {
            pointer++;
            Image image = GSS.CaptureScreen();
            historyImage.Add(image);
        }

        //删除列表中historyImage[pointer]之后的元素
        public void RemoveHistoryImage()
        {
            historyImage.RemoveRange(pointer, historyImage.Count - pointer);
        }

        //执行此函数，显示图像变为pointer上一张
        public void changeImageLast()
        {
            pointer--;
            pictureBox1.Image = historyImage[pointer];
        }

        //执行此函数，显示图像变为pointer下一张
        public void changeImageNext() 
        {
            pointer++;
            pictureBox1.Image = historyImage[pointer];
        }
    }
}
