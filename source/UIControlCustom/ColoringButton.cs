using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UIControlCustom
{
    public abstract partial class ColoringButton : Button
    {
        public ColoringButton()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SetBackGround();
        }

        protected void SetBackGround()
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

        protected abstract Color SetColor1();
        protected abstract Color SetColor2();
    }

    public class ButtonGradientDark : ColoringButton
    {
        public ButtonGradientDark() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(20, 23, 39);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(58, 65, 111);
        }
    }

    public class ButtonGradientLight : ColoringButton
    {
        public ButtonGradientLight() : base()
        {
            ForeColor = Color.Black;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(206, 212, 218);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(235, 239, 244);
        }
    }

    public class ButtonGradientPrimary : ColoringButton
    {
        public ButtonGradientPrimary() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(121, 40, 202);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(255, 0, 128);
        }
    }

    public class ButtonGradientDanger : ColoringButton
    {
        public ButtonGradientDanger() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(234, 6, 6);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(255, 102, 124);
        }
    }

    public class ButtonGradientSuccess : ColoringButton
    {
        public ButtonGradientSuccess() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(23, 173, 55);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(152, 236, 45);
        }
    }

    public class ButtonGradientWarning : ColoringButton
    {
        public ButtonGradientWarning() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(245, 57, 57);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(251, 207, 51);
        }
    }

    public class ButtonGradientSecondary : ColoringButton
    {
        public ButtonGradientSecondary() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(98, 117, 148);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(168, 184, 216);
        }
    }

    public class ButtonGradientInfo : ColoringButton
    {
        public ButtonGradientInfo() : base()
        {
            ForeColor = Color.White;
        }
        protected override Color SetColor1()
        {
            return Color.FromArgb(33, 82, 255);
        }
        protected override Color SetColor2()
        {
            return Color.FromArgb(33, 212, 253);
        }
    }
}