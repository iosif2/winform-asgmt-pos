using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace winform_asgmt_pos
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public List<Dictionary<string, string>> menus;
        public List<Order> order_history = new List<Order>();
        public List<Order> orders = new List<Order>();
        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();
            menus = new List<Dictionary<string, string>>();
            using (StreamReader reader = new StreamReader("menus.csv"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);
                    Dictionary<string, string> dict = new Dictionary<string, string>
                    {
                        { "name", parts[0] },
                        { "price", parts[1] }
                    };
                    if (int.Parse(parts[2]) > 0)
                    {
                        dict.Add("type", parts[2]);
                    }
                    else
                    {
                        dict.Add("type", "Dessert");
                    }
                    dict.Add("stock", parts[3]);
                    menus.Add(dict);
                }
            }
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Size = new Size(716, 681); // Size 고정
        }
        public void RefreshOrderListView()
        {
            listView1.Items.Clear();
            int sum = 0;
            foreach (Order o in orders)
            {
                ListViewItem lvi = new ListViewItem(o.name);
                lvi.SubItems.Add(o.quantity.ToString());
                lvi.SubItems.Add(o.GetPrice().ToString());
                lvi.SubItems.Add(o.options);
                listView1.Items.Add(lvi);
                sum += o.GetPrice();
            }
            textBox_total.Text = sum.ToString();
            textBox_count.Text = orders.Count.ToString();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[1].Width = 40;
        }
        public void AddOrder(string name, int unit_price, int quantity, string options, int index)
        {
            foreach (Order o in orders)
            {
                if (o.name == name && o.options == options)
                {
                    o.quantity += quantity;
                    RefreshOrderListView();
                    return;
                }
            }
            orders.Add(new Order(name, unit_price, quantity, options, index));
            RefreshOrderListView();
        }


        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_cancel2_Click(object sender, EventArgs e)
        {
            orders.Clear();
            RefreshOrderListView();
        }

        private void button_cancel1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                orders.RemoveAt(listView1.SelectedIndices[0]);
                RefreshOrderListView();
            }
        }
        private DrinkMenu GetDrinkMenu(int index)
        {
            Dictionary<string, string> menu = menus[index];
            return new DrinkMenu(menu["name"], int.Parse(menu["price"]), (DrinkMenu.Category)int.Parse(menu["type"]), index);
        }
        private DessertMenu GetDessertMenu(int index)
        {
            Dictionary<string, string> menu = menus[index - 71];
            return new DessertMenu(menu["name"], int.Parse(menu["price"]), index - 71);
        }
        private void button_Drink_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());
            new DrinkOption(GetDrinkMenu(index), this);
        }

        private void button_Dessert_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());
            new DessertOption(GetDessertMenu(index), this);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            new SalesForm(order_history);
        }
        public bool makePayment()
        {
            List<Order> done = new List<Order>();
            foreach (Order order in orders)
            {
                if (order.quantity > int.Parse(menus[order.index]["stock"]))
                    return false;
                order.timestamp = DateTime.Now.ToString("yyyy년 MMMM dd일, dddd, HH:mm:ss");
                done.Add(order);
            }
            foreach (Order order in orders) menus[order.index]["stock"] = (int.Parse(menus[order.index]["stock"]) - order.quantity).ToString();
            order_history.AddRange(done);
            orders.Clear();
            RefreshOrderListView();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            return true;
        }
        private void button_Card_Click(object sender, EventArgs e)
        {
            if (orders.Count == 0) return;
            new PayForm(this, true);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            new StockForm(menus);
        }

        private void button_Cash_Click(object sender, EventArgs e)
        {
            if (orders.Count == 0) return;
            new PayForm(this, false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_dt.Text = DateTime.Now.ToString("yyyy년 MMMM dd일, dddd, HH:mm:ss");
        }
    }
}
