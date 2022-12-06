using System.Collections.Generic;
using System.Windows.Forms;

namespace winform_asgmt_pos
{
    public partial class SalesForm : Form
    {
        private List<Order> order_history;
        public SalesForm(List<Order> order_history)
        {
            InitializeComponent();
            this.order_history = order_history;
            int sum = 0;
            foreach (Order order in this.order_history)
            {
                ListViewItem lvi = new ListViewItem(order.timestamp);
                lvi.SubItems.Add(order.name);
                lvi.SubItems.Add(order.quantity.ToString());
                lvi.SubItems.Add(order.GetPrice().ToString());
                lvi.SubItems.Add(order.options);
                listView1.Items.Add(lvi);
                sum += order.GetPrice();
            }
            label1.Text += sum.ToString() + " 원";
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[2].Width = 40;
            StartPosition = FormStartPosition.CenterParent;
            ShowDialog();
        }
    }
}
