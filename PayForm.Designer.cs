namespace winform_asgmt_pos
{
    partial class PayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_paid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "결제 금액";
            // 
            // button_pay
            // 
            this.button_pay.Location = new System.Drawing.Point(195, 45);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(57, 23);
            this.button_pay.TabIndex = 1;
            this.button_pay.Text = "결제";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(77, 19);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(100, 20);
            this.textBox_price.TabIndex = 2;
            // 
            // textBox_paid
            // 
            this.textBox_paid.Location = new System.Drawing.Point(77, 47);
            this.textBox_paid.Name = "textBox_paid";
            this.textBox_paid.ReadOnly = true;
            this.textBox_paid.Size = new System.Drawing.Size(100, 20);
            this.textBox_paid.TabIndex = 4;
            this.textBox_paid.TextChanged += new System.EventHandler(this.textBox_paid_TextChanged);
            this.textBox_paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_paid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "받은 금액";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 86);
            this.Controls.Add(this.textBox_paid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.label1);
            this.Name = "PayForm";
            this.Text = "결제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_paid;
        private System.Windows.Forms.Label label2;
    }
}