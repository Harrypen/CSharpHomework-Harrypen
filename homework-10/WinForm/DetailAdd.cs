using OrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class DetailAdd : Form
    {
        public Order CurrentOrder { get; set; }
        public DetailAdd()
        {
            InitializeComponent();
        }
        public DetailAdd(Order order):this()
        {
            CurrentOrder = order;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Good Addgood = new Good(comboBox1.Text);
            CurrentOrder.AddDetail(Addgood, Convert.ToInt32(GoodNumber.Text));
            this.Close();
        }
    }
}
