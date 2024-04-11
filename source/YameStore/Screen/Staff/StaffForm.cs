using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.Staff
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();

            setupGradientDark(button1);
            setupGradientDark(button2);
            setupGradientPrimary(button3);
        }

        public void setupGradientDark(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(20, 23, 39), Color.FromArgb(58, 65, 111), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientPrimary(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(121, 40, 202), Color.FromArgb(255, 0, 128), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientDanger(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(234, 6, 6), Color.FromArgb(255, 102, 124), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientLight(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(206, 212, 218), Color.FromArgb(235, 239, 244), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientWarning(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(245, 57, 57), Color.FromArgb(251, 207, 51), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientSecondary(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(98, 117, 148), Color.FromArgb(168, 184, 216), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientSuccess(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(23, 173, 55), Color.FromArgb(152, 236, 45), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setupGradientInfo(Button button)
        {
            Bitmap gradientImage = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, button.Size);
                using (Brush brush = new LinearGradientBrush(rect, Color.FromArgb(33, 82, 255), Color.FromArgb(33, 212, 253), 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            button.BackgroundImage = gradientImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CreateStaffDialog().ShowDialog();
        }
    }
}
