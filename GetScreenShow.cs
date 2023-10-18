using System.Drawing;
using System.Windows.Forms;

namespace Get_Screen_Show
{
    class GetScreenShow
    {
        private PictureBox pictureBox1;

        public void AddPictureBox(PictureBox pictureBoxIn)
        {
            pictureBox1 = pictureBoxIn;
        }

        //将picturebox1上的所有图层的图像合并到原先在picturebox1中显示的图像里中，并作为返回值返回
        public Image CaptureScreen()
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(image, pictureBox1.ClientRectangle);
            return image;
        }
    }
}