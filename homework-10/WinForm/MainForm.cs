using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using OrderSystem;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace WinForm
{
    public partial class MainForm : Form
    {
        //判断输入的为数字
        public static bool IsNumber(string number)
        {
            if (number.Equals(""))
                return false;
            return Regex.IsMatch(number, @"^[0-9]*$");
        }
        public static OrderService os = new OrderService();

        public MainForm()
        {
            InitializeComponent();
            orderBindingSource.DataSource = os.GetAllOrders();
            
            this.dataGridView2.DataError += delegate (object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e) { };//加上否则报错
            this.dataGridView1.DataError += delegate (object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e) { };//加上否则报错
        }
        //查询显示订单
        private void Show_Click(object sender, EventArgs e)
        {
            ShowOrder();
        }
        //添加订单
        private void Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }
        //修改订单
        private void Update_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                EditForm editForm = new EditForm((Order)orderBindingSource.Current);
                editForm.ShowDialog();
                ShowOrder();
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                Order order = (Order)orderBindingSource.Current;
                os.Delete(order.Id);
                ShowOrder();
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }
        private void ShowOrder()
        {
            switch (comboBox1.SelectedIndex)
            {            
                case 1:
                    orderBindingSource.DataSource =
                      os.GetOrder(textBox1.Text);
                    break;
                case 2:
                    orderBindingSource.DataSource =
                      os.ShowByCustormer(textBox1.Text);
                    break;
                case 3:
                    orderBindingSource.DataSource =
                      os.ShowByGoods(textBox1.Text);
                    break;
                case 4:
                    orderBindingSource.DataSource =
                        os.ShowBySum0(textBox1.Text);
                    break;
                case 5:
                    orderBindingSource.DataSource =
                        os.ShowBySum1(textBox1.Text);
                    break;
                default:
                    orderBindingSource.DataSource = os.GetAllOrders();
                    break;
            }
            orderBindingSource.ResetBindings(false);
            detailsBindingSource.ResetBindings(false);
        }

        
    }
}
