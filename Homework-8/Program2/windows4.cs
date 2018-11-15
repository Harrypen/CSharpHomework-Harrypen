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
       
        public windows4()
        {
            InitializeComponent();
        }

        private void windows4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
            if (Form1.OrderService.orders.Count != 0)
            {
                orderBindingSource.DataSource = new BindingList<Order>(Form1.OrderService.orders);
            }
        }

        private void windows4_Enter(object sender, EventArgs e)
        {
            if (Form1.OrderService.orders.Count != 0)
            {
                orderBindingSource.DataSource = new BindingList<Order>(Form1.OrderService.orders);
            }
        }

        //OrderID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.OrderService.orders.Count != 0)
            {
                orderBindingSource.DataSource = new BindingList<Order>(Form1.OrderService.orders);
            }

            //Form1.GetOrders = Form1.OrderService.orders;
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
            }
            else if (comboBox1.Text.Equals("全部订单"))
            {
                var dataSource = Form1.GetOrders;
                if (dataSource.Count() == 0)
                {
                    MessageBox.Show("没有订单！");
                    return;
                }
                orderBindingSource.DataSource = dataSource;
                foreach (Order a in dataSource)
                    orders.Add(a);
            }
            else if (comboBox1.Text.Equals("电话号码"))
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
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        
    }
}
