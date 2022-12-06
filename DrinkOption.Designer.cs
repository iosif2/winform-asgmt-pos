namespace winform_asgmt_pos
{
    partial class DrinkOption
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
            this.checkBox_th = new System.Windows.Forms.CheckBox();
            this.checkBox_ti = new System.Windows.Forms.CheckBox();
            this.checkBox_sr = new System.Windows.Forms.CheckBox();
            this.checkBox_sl = new System.Windows.Forms.CheckBox();
            this.checkBox_b1 = new System.Windows.Forms.CheckBox();
            this.checkBox_b2 = new System.Windows.Forms.CheckBox();
            this.checkBox_b3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_c1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_c2 = new System.Windows.Forms.CheckBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "선택된 메뉴 : ";
            // 
            // checkBox_th
            // 
            this.checkBox_th.AutoSize = true;
            this.checkBox_th.Checked = true;
            this.checkBox_th.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_th.Location = new System.Drawing.Point(50, 81);
            this.checkBox_th.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_th.Name = "checkBox_th";
            this.checkBox_th.Size = new System.Drawing.Size(60, 29);
            this.checkBox_th.TabIndex = 1;
            this.checkBox_th.Text = "핫";
            this.checkBox_th.UseVisualStyleBackColor = true;
            this.checkBox_th.CheckedChanged += new System.EventHandler(this.checkBox_th_CheckedChanged);
            // 
            // checkBox_ti
            // 
            this.checkBox_ti.AutoSize = true;
            this.checkBox_ti.Location = new System.Drawing.Point(252, 81);
            this.checkBox_ti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_ti.Name = "checkBox_ti";
            this.checkBox_ti.Size = new System.Drawing.Size(92, 29);
            this.checkBox_ti.TabIndex = 2;
            this.checkBox_ti.Text = "아이스";
            this.checkBox_ti.UseVisualStyleBackColor = true;
            this.checkBox_ti.CheckedChanged += new System.EventHandler(this.checkBox_ti_CheckedChanged);
            // 
            // checkBox_sr
            // 
            this.checkBox_sr.AutoSize = true;
            this.checkBox_sr.Checked = true;
            this.checkBox_sr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sr.Location = new System.Drawing.Point(50, 160);
            this.checkBox_sr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_sr.Name = "checkBox_sr";
            this.checkBox_sr.Size = new System.Drawing.Size(92, 29);
            this.checkBox_sr.TabIndex = 3;
            this.checkBox_sr.Text = "레귤러";
            this.checkBox_sr.UseVisualStyleBackColor = true;
            this.checkBox_sr.CheckedChanged += new System.EventHandler(this.checkBox_sr_CheckedChanged);
            // 
            // checkBox_sl
            // 
            this.checkBox_sl.AutoSize = true;
            this.checkBox_sl.Location = new System.Drawing.Point(252, 160);
            this.checkBox_sl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_sl.Name = "checkBox_sl";
            this.checkBox_sl.Size = new System.Drawing.Size(76, 29);
            this.checkBox_sl.TabIndex = 4;
            this.checkBox_sl.Text = "라지";
            this.checkBox_sl.UseVisualStyleBackColor = true;
            this.checkBox_sl.CheckedChanged += new System.EventHandler(this.checkBox_sl_CheckedChanged);
            // 
            // checkBox_b1
            // 
            this.checkBox_b1.AutoSize = true;
            this.checkBox_b1.Checked = true;
            this.checkBox_b1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_b1.Location = new System.Drawing.Point(50, 237);
            this.checkBox_b1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_b1.Name = "checkBox_b1";
            this.checkBox_b1.Size = new System.Drawing.Size(146, 29);
            this.checkBox_b1.TabIndex = 5;
            this.checkBox_b1.Text = "블랙 그라운드";
            this.checkBox_b1.UseVisualStyleBackColor = true;
            this.checkBox_b1.CheckedChanged += new System.EventHandler(this.checkBox_b1_CheckedChanged);
            // 
            // checkBox_b2
            // 
            this.checkBox_b2.AutoSize = true;
            this.checkBox_b2.Location = new System.Drawing.Point(252, 237);
            this.checkBox_b2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_b2.Name = "checkBox_b2";
            this.checkBox_b2.Size = new System.Drawing.Size(124, 29);
            this.checkBox_b2.TabIndex = 6;
            this.checkBox_b2.Text = "아로마노트";
            this.checkBox_b2.UseVisualStyleBackColor = true;
            this.checkBox_b2.CheckedChanged += new System.EventHandler(this.checkBox_b2_CheckedChanged);
            // 
            // checkBox_b3
            // 
            this.checkBox_b3.AutoSize = true;
            this.checkBox_b3.Location = new System.Drawing.Point(50, 281);
            this.checkBox_b3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_b3.Name = "checkBox_b3";
            this.checkBox_b3.Size = new System.Drawing.Size(108, 29);
            this.checkBox_b3.TabIndex = 7;
            this.checkBox_b3.Text = "디카페인";
            this.checkBox_b3.UseVisualStyleBackColor = true;
            this.checkBox_b3.CheckedChanged += new System.EventHandler(this.checkBox_b3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "온도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "사이즈";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "원두";
            // 
            // checkBox_c1
            // 
            this.checkBox_c1.AutoSize = true;
            this.checkBox_c1.Checked = true;
            this.checkBox_c1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_c1.Location = new System.Drawing.Point(50, 363);
            this.checkBox_c1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_c1.Name = "checkBox_c1";
            this.checkBox_c1.Size = new System.Drawing.Size(114, 29);
            this.checkBox_c1.TabIndex = 11;
            this.checkBox_c1.Text = "일회용 컵";
            this.checkBox_c1.UseVisualStyleBackColor = true;
            this.checkBox_c1.CheckedChanged += new System.EventHandler(this.checkBox_c1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "포장";
            // 
            // checkBox_c2
            // 
            this.checkBox_c2.AutoSize = true;
            this.checkBox_c2.Location = new System.Drawing.Point(252, 363);
            this.checkBox_c2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_c2.Name = "checkBox_c2";
            this.checkBox_c2.Size = new System.Drawing.Size(92, 29);
            this.checkBox_c2.TabIndex = 13;
            this.checkBox_c2.Text = "머그컵";
            this.checkBox_c2.UseVisualStyleBackColor = true;
            this.checkBox_c2.CheckedChanged += new System.EventHandler(this.checkBox_c2_CheckedChanged);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(264, 469);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 44);
            this.button_confirm.TabIndex = 15;
            this.button_confirm.Text = "추가";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(50, 473);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 31);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 479);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "잔";
            // 
            // DrinkOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.checkBox_c2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_c1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_b3);
            this.Controls.Add(this.checkBox_b2);
            this.Controls.Add(this.checkBox_b1);
            this.Controls.Add(this.checkBox_sl);
            this.Controls.Add(this.checkBox_sr);
            this.Controls.Add(this.checkBox_ti);
            this.Controls.Add(this.checkBox_th);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DrinkOption";
            this.Text = "옵션";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_th;
        private System.Windows.Forms.CheckBox checkBox_ti;
        private System.Windows.Forms.CheckBox checkBox_sr;
        private System.Windows.Forms.CheckBox checkBox_sl;
        private System.Windows.Forms.CheckBox checkBox_b1;
        private System.Windows.Forms.CheckBox checkBox_b2;
        private System.Windows.Forms.CheckBox checkBox_b3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_c1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_c2;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}