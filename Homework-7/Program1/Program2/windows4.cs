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
    public partial class windows4 : UserControl
    {
        public static int OrderID;
        public windows4()
        {
            InitializeComponent();
        }

        private void windows4_Load(object sender, EventArgs e)
        {
            if (Form1.OrderService.orders.Count != 0)
            {
                orderBindingSource.DataSource = new BindingList<Order>(Form1.OrderService.orders);
            }
        }

        private void 订单明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(Form1.OrderService.orders[windows4.OrderID].MyOrder);
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.GetOrders = Form1.OrderService.orders;
            List<Order> orders = new List<Order>();
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
                orderBindingSource.DataSource = dataSource;
                foreach (Order a in dataSource)
                    orders.Add(a);
                orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(orders[0].MyOrder);

            }
            else if (comboBox1.Text.Equals("订单号"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.OrderId == (Convert.ToInt32(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                orderBindingSource.DataSource = dataSource;
                foreach (Order a in dataSource)
                    orders.Add(a);
                orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(orders[0].MyOrder);

            }
            else if (comboBox1.Text.Equals("最大金额"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.sum < (Convert.ToInt32(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                orderBindingSource.DataSource = dataSource;
                foreach (Order a in dataSource)
                    orders.Add(a);
                orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(orders[0].MyOrder);
            }
            else if (comboBox1.Text.Equals("最小金额"))
            {
                var dataSource = Form1.GetOrders.Where(a => a.sum > (Convert.ToInt32(textBox1.Text)));
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                orderBindingSource.DataSource = dataSource;
                foreach (Order a in dataSource)
                    orders.Add(a);
                orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(orders[0].MyOrder);
            }
            else
            {
                MessageBox.Show("没有订单！");
            }

        }
    }
}
