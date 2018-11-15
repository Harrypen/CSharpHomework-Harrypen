using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class windows2 : UserControl
    {
        public windows2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("请输入！");
                return;
            }
            if (Form1.OrderService.orders.Exists(a => a.Client.Equals(textBox1.Text)) && comboBox1.Text.Equals("客户名"))
            {
                Form1.OrderService.DeleteByCliend(textBox1.Text);
                MessageBox.Show("删除成功！");
            }
            else if (Form1.OrderService.orders.Exists(a => a.OrderId == (Convert.ToInt32(textBox1.Text))) && comboBox1.Text.Equals("订单号"))
            {
                Form1.OrderService.DeleteById(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("没有此订单！");
                return;
            }
        }
    }
}
