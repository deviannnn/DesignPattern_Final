using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ColoringButton
{
    public abstract class ButtonDecorated : Button
    {
        public void SetBackGround()
        {
            var color1 = SetColor1();
            var color2 = SetColor2();

            Bitmap gradientImage = new Bitmap(Width, Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                Rectangle rect = new Rectangle(Point.Empty, Size);
                using (Brush brush = new LinearGradientBrush(rect, color1, color2, 310))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            BackgroundImage = gradientImage;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        public abstract Color SetColor1();
        public abstract Color SetColor2();
    }

    public class ButtonGradientLight : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(206, 212, 218);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(235, 239, 244);
        }
    }

    public class ButtonGradientDark : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(20, 23, 39);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(58, 65, 111);
        }
    }

    public class ButtonGradientPrimary : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(121, 40, 202);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(255, 0, 128);
        }
    }

    public class ButtonGradientDanger : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(234, 6, 6);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(255, 102, 124);
        }
    }

    public class ButtonGradientSuccess : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(23, 173, 55);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(152, 236, 45);
        }
    }
    public class ButtonGradientWarning : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(245, 57, 57);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(251, 207, 51);
        }
    }

    public class ButtonGradientSecondary : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(98, 117, 148);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(168, 184, 216);
        }
    }

    public class ButtonGradientInfo : ButtonDecorated
    {
        public override Color SetColor1()
        {
            return Color.FromArgb(33, 82, 255);
        }

        public override Color SetColor2()
        {
            return Color.FromArgb(33, 212, 253);
        }
    }
}