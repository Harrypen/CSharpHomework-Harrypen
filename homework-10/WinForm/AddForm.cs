using OrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class AddForm : Form
    {
        //判断电话号码
        public bool IsPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"[1]+\d{10}");
        }
        public AddForm()
        {
            InitializeComponent();
        }
        private static int m = 0;
        Good good_1 = new Good("香蕉");
        Good good_2 = new Good("苹果");
        Good good_3 = new Good("酸奶");
        public Order CurrentOrder { set; get; }
        private void AddOrderButton_Click(object sender, EventArgs e)
        {          
            
            Order CurrentOrder = new Order();
            int B = 0;
            if (MainForm.IsNumber(XJTB.Text) && XJTB.Text != null && XJCB.Checked)
            {
                CurrentOrder.AddDetail(good_1, Convert.ToInt32(XJTB.Text));
                B++;
            }
            if (MainForm.IsNumber(PGTB.Text) && PGTB.Text != null && PGCB.Checked)
            {
                CurrentOrder.AddDetail(good_2, Convert.ToInt32(PGTB.Text));
                B++;
            }
            if (MainForm.IsNumber(SNTB.Text) && SNTB.Text != null && SNCB.Checked)
            {
                CurrentOrder.AddDetail(good_3, Convert.ToInt32(SNTB.Text));
                B++;
            }          
            //判断电话
            if (!IsPhoneNumber(ClientPhoneTB.Text))
            {
                MessageBox.Show("抱歉！请正确输入电话号码！");
                return;
            }
            else
            {
                CurrentOrder.Phone = ClientPhoneTB.Text;
            }

            if (B == 0)
            {
                MessageBox.Show("抱歉！您添加的订单数量为空！请检查您输入的数字！");
                return;
            }
            else
                MessageBox.Show("添加成功！");
            CurrentOrder.Customer= ClientTB.Text;           
            MainForm.os.Add(CurrentOrder);
            this.Close();
        }
    }
}
