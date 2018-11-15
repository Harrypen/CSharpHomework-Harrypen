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
    public partial class windows3 : UserControl
    {
        public windows3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();
            List<OrderDetails> orderDetails=new List<OrderDetails>();
            if (Form1.GetOrders.Count() == 0)
            {
                MessageBox.Show("没有订单！");
                return;
            }

            if (comboBox1.Text.Equals("客户名"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.Client.Equals(textBox1.Text));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else if (comboBox1.Text.Equals("订单号"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.OrderId == (Convert.ToInt32(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
               foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else if (comboBox1.Text.Equals("最大金额"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.sum < (Convert.ToInt32(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
               foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else if (comboBox1.Text.Equals("最小金额"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.sum > (Convert.ToInt32(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else if (comboBox1.Text.Equals("全部明细"))
            {
                var dataSource = Form1.GetOrders;
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else if(comboBox1.Text.Equals("电话号码"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.Tel == (Convert.ToString(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else
            {
                MessageBox.Show("没有订单！");
            }

            foreach (var order in orders)
            {
                orderDetails.AddRange(order.MyOrder);
            }
            orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(orderDetails);
        }

        private void windows3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }


}
