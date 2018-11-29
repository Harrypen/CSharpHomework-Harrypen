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
    public partial class EditForm : Form
    {
        OrderService orderService = new OrderService();      
        public Order CurrentOrder { get; set; }
        public int DeleteId = 0;
        public EditForm()
        {
            InitializeComponent();                    
        }
        public EditForm(Order order):this()
        {
            if (order == null)
            {
                return;
            }
            else
            {
                CurrentOrder = order;
                DeleteId = order.Id;
            }
            orderBindingSource.DataSource = CurrentOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             orderService.Update(CurrentOrder);
             this.Close();
        }

        private void DeleteDetails_Click(object sender, EventArgs e)
        {
            DeleteId = CurrentOrder.Id;
            if (detailsBindingSource.Current != null)
            {
                OrderDetails details = (OrderDetails)detailsBindingSource.Current;
                CurrentOrder.DeleteDetail(details);              
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
            orderBindingSource.ResetBindings(false);
            detailsBindingSource.ResetBindings(true);
            orderService.Add(CurrentOrder);
            orderService.Delete(DeleteId);
        }

        private void AddDetails_Click(object sender, EventArgs e)
        {
            DeleteId = CurrentOrder.Id;
            DetailAdd detailAdd = new DetailAdd((Order)orderBindingSource.Current);
            detailAdd.ShowDialog();          
            orderBindingSource.ResetBindings(false);
            detailsBindingSource.ResetBindings(true);
            orderService.Add(CurrentOrder);
            orderService.Delete(DeleteId);
        }
    }
}
