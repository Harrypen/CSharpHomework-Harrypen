using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
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
        public static windows1 Windows1 = new windows1();//定义窗口变量
        public static windows2 Windows2 = new windows2();
        public static windows3 Windows3 = new windows3();
        public static windows4 Windows4 = new windows4();

        public static List<Order> GetOrders = new List<Order>();
        public static OrderService OrderService = new OrderService();
        public static List<OrderDetails> Details = new List<OrderDetails>();

       

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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService.Export();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"Order.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"../../../Order.xslt");

                FileStream outFileStream = File.OpenWrite(@"../../../Order.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, writer);
                MessageBox.Show("成功！");
            }
            catch (XmlException ea)
            {
                Console.WriteLine("XML Exception:" + ea.ToString());
            }
            catch (XsltException ea)
            {
                Console.WriteLine("XSLT Exception:" + ea.ToString());
            }
        }
    }
}
