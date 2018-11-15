using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program1;

namespace Program2
{
    public partial class windows1 : UserControl
    {
        public windows1()
        {
            InitializeComponent();
        }

        private static int ordinal;
        private void button1_Click(object sender, EventArgs e)
        {
            Goods goods1 = null, goods2 = null, goods3 = null;
            ordinal++;
            Order order = new Order();
            int orderDetailsDetailsNumber = 0;
            if (checkBox1.Checked && textBox1.Text != "")
            {
                goods1 = new Goods("water");
                OrderDetails orderDetails = new OrderDetails(goods1, Convert.ToInt32(textBox1.Text));
                orderDetailsDetailsNumber++;
                orderDetails.DetailsNumber = orderDetailsDetailsNumber;
                order.MyOrder.Add(orderDetails);
            }
            if (checkBox2.Checked && textBox2.Text != "")
            {
                goods2 = new Goods("bread");
                OrderDetails orderDetails = new OrderDetails(goods2, Convert.ToInt32(textBox2.Text));
                orderDetailsDetailsNumber++;
                orderDetails.DetailsNumber = orderDetailsDetailsNumber;
                order.MyOrder.Add(orderDetails);
            }
            if (checkBox3.Checked && textBox3.Text != "")
            {
                goods3 = new Goods("book");
                OrderDetails orderDetails = new OrderDetails(goods3, Convert.ToInt32(textBox3.Text));
                orderDetailsDetailsNumber++;
                orderDetails.DetailsNumber = orderDetailsDetailsNumber;
                order.MyOrder.Add(orderDetails);
            }

            if (!textBox4.Text.Equals(""))
                order.Client = textBox4.Text;
            else
            {
                MessageBox.Show("请输入客户名！");
                return;
            }

            if (!textBox5.Text.Equals(""))
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[1]+[3,4,5,8]+\d{9}"))
                    order.Tel = textBox5.Text;
                else
                {
                    MessageBox.Show("请输入正确的手机号码 !");
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入电话！");
                return;
            }

            if (orderDetailsDetailsNumber == 0)
            {
                MessageBox.Show("空订单！");
                return;
            }
            else
            {
                MessageBox.Show("添加成功！");
            }
            
            order.OrderId = ordinal + DateTime.Now.Year*1000000 + DateTime.Now.Month * 10000 + DateTime.Now.Day * 100;
            order.Sum();
            Form1.OrderService.AddOrder(order);
        }
    }
}
