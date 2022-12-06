using System;
using System.Windows.Forms;

namespace winform_asgmt_pos
{
    public partial class DrinkOption : Form
    {
        private DrinkMenu menu { get; set; }
        private MainForm mainForm { get; }
        private int max;
        public DrinkOption(DrinkMenu menu, MainForm mainForm)
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
            label1.Text = "선택된 메뉴 : " + this.menu.GetName();
            if (menu.bean == DrinkMenu.Bean.None)
            {
                checkBox_b1.Enabled = false;
                checkBox_b2.Enabled = false;
                checkBox_b3.Enabled = false;
            }
            numericUpDown1.Focus();
            StartPosition = FormStartPosition.CenterParent;
            ShowDialog();
        }
        public void refreshLabel()
        {
            label1.Text = "선택된 메뉴 : " + menu.GetName();
        }

        private void checkBox_th_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_th.Checked)
            {
                checkBox_ti.Checked = false;
                menu.isIced = false;
            }
            refreshLabel();
        }

        private void checkBox_ti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ti.Checked)
            {
                checkBox_th.Checked = false;
                menu.isIced = true;
            }
            refreshLabel();
        }

        private void checkBox_sr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sr.Checked)
            {
                checkBox_sl.Checked = false;
                menu.sizeup = false;
            }
            refreshLabel();
        }

        private void checkBox_sl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sl.Checked)
            {
                checkBox_sr.Checked = false;
                menu.sizeup = true;
            }
            refreshLabel();
        }

        private void checkBox_b1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_b1.Checked)
            {
                checkBox_b2.Checked = false;
                checkBox_b3.Checked = false;
                menu.bean = DrinkMenu.Bean.BlackGround;
            }
        }

        private void checkBox_b2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_b2.Checked)
            {
                checkBox_b1.Checked = false;
                checkBox_b3.Checked = false;
                menu.bean = DrinkMenu.Bean.Aroma;
            }
        }

        private void checkBox_b3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_b3.Checked)
            {
                checkBox_b1.Checked = false;
                checkBox_b2.Checked = false;
                menu.bean = DrinkMenu.Bean.DeCaff;
            }
        }

        private void checkBox_c1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_c1.Checked)
            {
                checkBox_c2.Checked = false;
                menu.toGo = true;
            }
        }

        private void checkBox_c2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_c2.Checked)
            {
                checkBox_c1.Checked = false;
                menu.toGo = false;
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string options = "";
            int quantity = (int)numericUpDown1.Value;
            if (menu.category == DrinkMenu.Category.Coffee)
            {
                options += menu.bean;
            }
            if (menu.toGo) options += " 일회용컵";
            else options += " 머그컵";
            if (quantity > max)
            {
                MessageBox.Show(menu.name + "의 재고가 부족합니다.", "재고 부족", MessageBoxButtons.OK);
                return;
            }
            mainForm.AddOrder(menu.GetName(), menu.GetPrice(), (int)numericUpDown1.Value, options, menu.index);
            Close();
        }
    }
}
