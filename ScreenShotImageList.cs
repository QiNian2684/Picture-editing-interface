using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Screen_Shot_Image_List
{
    class ScreenShotImageList
    {
        public void ScreenShotImageOperation(Image image, ListView listView, PictureBox pictureBox)
        {
            if (listView.View != View.LargeIcon) // 如果ListView的View属性不是LargeIcon，就设置为LargeIcon
            {
                listView.View = View.LargeIcon;
            }

            if (listView.LargeImageList == null) // 如果大图标列表为null，就新建一个LargeImageList对象
            {
                listView.LargeImageList = new ImageList();
            }

            listView.LargeImageList.ImageSize = new Size(230, 130); // 设置ImageList的ImageSize属性

            // 创建带有时间戳的位图
            Bitmap stampedBitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(stampedBitmap);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Font font = new Font(FontFamily.GenericSansSerif, 50, FontStyle.Bold); // 设置字体为粗体
            Brush brush = new SolidBrush(Color.White);

            // 计算时间戳的位置
            SizeF textSize = graphics.MeasureString(timestamp, font);
            float x = (stampedBitmap.Width - textSize.Width) / 2;
            float y = stampedBitmap.Height - textSize.Height - 20; // 将y的值调整为更大的值

            graphics.DrawString(timestamp, font, brush, new PointF(x, y));
            graphics.Save();

            // 将带有时间戳的位图添加到ListView的大图标列表中
            listView.LargeImageList.Images.Add(stampedBitmap);
            ListViewItem item = new ListViewItem(); // 创建ListViewItem对象
            item.ImageIndex = listView.LargeImageList.Images.Count - 1; // 设置该项在大图标列表中的索引
            listView.Items.Add(item); // 将该项添加到ListView中
        }

        // 将原始图片缩放到指定大小
        private Image ResizeImage(Image image, Size size)
        {
            Bitmap result = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, size.Width, size.Height);
            }
            return result;
        }
    }
}
