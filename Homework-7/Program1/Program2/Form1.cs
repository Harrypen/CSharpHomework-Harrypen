using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program1;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            GetOrders = OrderService.orders;
            InitializeComponent();
        }

        //窗口切换
        public windows1 Windows1;//定义窗口变量
        public windows2 Windows2;
        public windows3 Windows3;
        public windows4 Windows4;

        public static List<Order> GetOrders = new List<Order>();
        public static OrderService OrderService = new OrderService();
        public static List<OrderDetails> Details = new List<OrderDetails>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Windows1 = new windows1();
            Windows2 = new windows2();
            Windows3 = new windows3();
            Windows4 = new windows4();
            //OrderService.Import();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Windows1.Show();
            groupBox2.Controls.Clear();
            groupBox2.Controls.Add(Windows1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Windows2.Show();
            groupBox2.Controls.Clear();
            groupBox2.Controls.Add(Windows2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Windows3.Show();
            groupBox2.Controls.Clear();
            groupBox2.Controls.Add(Windows3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Windows4.Show();
            groupBox2.Controls.Clear();
            groupBox2.Controls.Add(Windows4);
        }
    }
}
