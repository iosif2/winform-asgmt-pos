using System.Windows.Forms;

namespace winform_asgmt_pos
{
    public partial class DessertOption : Form
    {
        private MainForm mainForm { get; set; }
        private DessertMenu menu { get; set; }
        private int max;
        public DessertOption(DessertMenu menu, MainForm mainForm)
        {
            InitializeComponent();
            this.menu = menu;
            this.mainForm = mainForm;
            max = int.Parse(mainForm.menus[menu.index]["stock"]);
            foreach (Order order in mainForm.orders) if (order.name.Contains(menu.name)) max -= order.quantity;

            if (max < 1)
            {
                MessageBox.Show(menu.name + "의 재고가 부족합니다.", "재고 부족", MessageBoxButtons.OK);
                Close();
                return;
            }
            numericUpDown1.Maximum = max;
            label1.Text = menu.name;
            numericUpDown1.Focus();
            StartPosition = FormStartPosition.CenterParent;
            ShowDialog();
        }

        private void button_confirm_Click(object sender, System.EventArgs e)
        {
            string options = "";
            int quantity = (int)numericUpDown1.Value;
            if (menu.toGo) options += " 포장";
            if (quantity > max)
            {
                MessageBox.Show(menu.name + " 의 재고가 부족합니다.", "재고 부족", MessageBoxButtons.OK);
                return;
            }
            mainForm.AddOrder(menu.name, menu.price, (int)numericUpDown1.Value, options, menu.index);
            Close();
        }
    }
}
