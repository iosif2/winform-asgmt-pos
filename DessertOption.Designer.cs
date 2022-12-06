namespace winform_asgmt_pos
{
    partial class DessertOption
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
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_confirm = new System.Windows.Forms.Button();
            this.checkBox_ToGo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "개";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(162, 33);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 32;
            this.button_confirm.Text = "추가";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // checkBox_ToGo
            // 
            this.checkBox_ToGo.AutoSize = true;
            this.checkBox_ToGo.Checked = true;
            this.checkBox_ToGo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ToGo.Location = new System.Drawing.Point(14, 36);
            this.checkBox_ToGo.Name = "checkBox_ToGo";
            this.checkBox_ToGo.Size = new System.Drawing.Size(48, 17);
            this.checkBox_ToGo.TabIndex = 29;
            this.checkBox_ToGo.Text = "포장";
            this.checkBox_ToGo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "선택된 메뉴 : ";
            // 
            // DessertOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 66);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.checkBox_ToGo);
            this.Controls.Add(this.label1);
            this.Name = "DessertOption";
            this.Text = "옵션";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.CheckBox checkBox_ToGo;
        private System.Windows.Forms.Label label1;
    }
}