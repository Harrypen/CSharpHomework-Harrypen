using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_graphics == null)
                _graphics = this.CreateGraphics();

            this._graphics.Clear(Color.White);

            DrawCayleyTree(8, 180, 300, Convert.ToDouble(textBox1.Text), -Math.PI / 2);
        }

        private Graphics _graphics;
        readonly double per1 = 0.6;
        readonly double per2 = 0.7;

        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            //（x1,x2）;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            //（x2,y2）
            double x2 = x0 + (leng * Math.Cos(th)) / 2;
            double y2 = y0 + (leng * Math.Sin(th)) / 2;

            //连线
            DrawLine(x0, y0, x1, y1);

            double th1 = Convert.ToDouble(textBox4.Text) * Math.PI / 180;
            double th2 = Convert.ToDouble(textBox3.Text) * Math.PI / 180;

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }
        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            Random random = new Random();
            // 随机色
            System.Drawing.Color myColor = System.Drawing.Color.FromArgb(
                random.Next(0, 255), 
                random.Next(0, 255), 
                random.Next(0, 255) );
            Pen pen = new Pen(checkBox1.Checked ? myColor : Color.Black, Convert.ToSingle(textBox2.Text));
           
            _graphics.DrawLine(pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

    }
}
