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

        private void windows3_Load(object sender, EventArgs e)
        {
            try
            {
                orderDetailsBindingSource.DataSource = new BindingList<OrderDetails>(Form1.OrderService.orders[windows4.OrderID].MyOrder);
            }
            catch  { }
        }
    }
}
