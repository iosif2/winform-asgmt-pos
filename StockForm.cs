using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace winform_asgmt_pos
{
    public partial class StockForm : Form
    {
        private List<Dictionary<string, string>> menus;
        public StockForm(List<Dictionary<string, string>> menus)
        {
            InitializeComponent();
            this.menus = menus;
            foreach (Dictionary<string, string> menu in menus)
            {
                int index = menus.IndexOf(menu);
                Label label = new Label();
                label.Text = menu["name"];
                label.Location = new Point(12 + (index) / 10 * 240, 10 + (index % 10) * 30);
                label.Size = new Size(150, 16);
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Minimum = 0;
                numericUpDown.Maximum = 1000;
                numericUpDown.Location = new Point(180 + (index) / 10 * 240, 5 + (index % 10) * 30);
                numericUpDown.Size = new Size(60, 16);
                numericUpDown.Tag = index;
                numericUpDown.Value = int.Parse(menu["stock"]);
                numericUpDown.ValueChanged += new EventHandler(numericUpDown_ValueChanged);
                panel1.Controls.Add(label);
                panel1.Controls.Add(numericUpDown);
            }
            StartPosition = FormStartPosition.CenterParent;
            ShowDialog();
        }

        public void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nupdown = (NumericUpDown)sender;
            Dictionary<string, string> menu = menus[int.Parse(nupdown.Tag.ToString())];
            menu["stock"] = nupdown.Value.ToString();
        }
    }
}
