using System;
using System.Windows.Forms;

namespace winform_asgmt_pos
{
    public partial class PayForm : Form
    {
        private MainForm mainForm;
        private int price;
        private bool card;
        public PayForm(MainForm mainForm, bool card)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            price = int.Parse(mainForm.textBox_total.Text);
            this.card = card;
            textBox_price.Text = price.ToString();
            if (this.card)
            {
                textBox_paid.Text = price.ToString();
                textBox_paid.ReadOnly = true;
                button_pay.Enabled = true;
                button_pay.Focus();
            }
            else
            {
                textBox_paid.ReadOnly = false;
                button_pay.Enabled = false;
            }
            StartPosition = FormStartPosition.CenterParent;
            ShowDialog();
        }


        private void textBox_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox_paid_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(textBox_paid.Text, out value)) return;
            if (value >= price) button_pay.Enabled = true;
            else button_pay.Enabled = false;
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            if (card)
            {
                string message = "결제 완료";
                string title = "카드 결제";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    if (!mainForm.makePayment())
                    {
                        MessageBox.Show("재고가 없습니다", "오류", buttons);
                    }
                    Close();
                }
            }
            else
            {
                string message = "Change : " + (int.Parse(textBox_paid.Text) - price).ToString();
                string title = "현금 결제";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    if (!mainForm.makePayment())
                    {
                        MessageBox.Show("재고가 없습니다", "오류", buttons);

                    }
                    Close();
                }
            }
        }
    }
}
