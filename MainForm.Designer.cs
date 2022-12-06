using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform_asgmt_pos
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Coffee = new System.Windows.Forms.TabPage();
            this.button_c1 = new System.Windows.Forms.Button();
            this.button_c10 = new System.Windows.Forms.Button();
            this.button_c9 = new System.Windows.Forms.Button();
            this.button_c8 = new System.Windows.Forms.Button();
            this.button_c7 = new System.Windows.Forms.Button();
            this.button_c6 = new System.Windows.Forms.Button();
            this.button_c5 = new System.Windows.Forms.Button();
            this.button_c4 = new System.Windows.Forms.Button();
            this.button_c3 = new System.Windows.Forms.Button();
            this.button_c2 = new System.Windows.Forms.Button();
            this.tabPage_Beverage = new System.Windows.Forms.TabPage();
            this.button_b10 = new System.Windows.Forms.Button();
            this.button_b9 = new System.Windows.Forms.Button();
            this.button_b8 = new System.Windows.Forms.Button();
            this.button_b7 = new System.Windows.Forms.Button();
            this.button_b6 = new System.Windows.Forms.Button();
            this.button_b5 = new System.Windows.Forms.Button();
            this.button_b4 = new System.Windows.Forms.Button();
            this.button_b3 = new System.Windows.Forms.Button();
            this.button_b2 = new System.Windows.Forms.Button();
            this.button_b1 = new System.Windows.Forms.Button();
            this.tabPage_Dessert = new System.Windows.Forms.TabPage();
            this.button_d10 = new System.Windows.Forms.Button();
            this.button_d9 = new System.Windows.Forms.Button();
            this.button_d8 = new System.Windows.Forms.Button();
            this.button_d7 = new System.Windows.Forms.Button();
            this.button_d6 = new System.Windows.Forms.Button();
            this.button_d5 = new System.Windows.Forms.Button();
            this.button_d4 = new System.Windows.Forms.Button();
            this.button_d3 = new System.Windows.Forms.Button();
            this.button_d2 = new System.Windows.Forms.Button();
            this.button_d1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_cancel1 = new System.Windows.Forms.Button();
            this.button_cancel2 = new System.Windows.Forms.Button();
            this.button_Card = new System.Windows.Forms.Button();
            this.button_Cash = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_dt = new System.Windows.Forms.Label();
            this.button_t1 = new System.Windows.Forms.Button();
            this.button_t2 = new System.Windows.Forms.Button();
            this.button_t3 = new System.Windows.Forms.Button();
            this.button_t4 = new System.Windows.Forms.Button();
            this.button_t5 = new System.Windows.Forms.Button();
            this.button_t6 = new System.Windows.Forms.Button();
            this.button_t7 = new System.Windows.Forms.Button();
            this.button_t8 = new System.Windows.Forms.Button();
            this.button_t9 = new System.Windows.Forms.Button();
            this.button_t10 = new System.Windows.Forms.Button();
            this.tabPage_Tea = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_Coffee.SuspendLayout();
            this.tabPage_Beverage.SuspendLayout();
            this.tabPage_Dessert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_Tea.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Malgun Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_close.Location = new System.Drawing.Point(672, 639);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 36);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "종료";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Malgun Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_stock.Location = new System.Drawing.Point(633, 639);
            this.btn_stock.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(35, 36);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.Text = "재고";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Font = new System.Drawing.Font("Malgun Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_sales.Location = new System.Drawing.Point(594, 639);
            this.btn_sales.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(35, 36);
            this.btn_sales.TabIndex = 3;
            this.btn_sales.Text = "매출";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Coffee);
            this.tabControl1.Controls.Add(this.tabPage_Tea);
            this.tabControl1.Controls.Add(this.tabPage_Beverage);
            this.tabControl1.Controls.Add(this.tabPage_Dessert);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tabControl1.Location = new System.Drawing.Point(12, 436);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 200);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "100";
            // 
            // tabPage_Coffee
            // 
            this.tabPage_Coffee.Controls.Add(this.button_c1);
            this.tabPage_Coffee.Controls.Add(this.button_c10);
            this.tabPage_Coffee.Controls.Add(this.button_c9);
            this.tabPage_Coffee.Controls.Add(this.button_c8);
            this.tabPage_Coffee.Controls.Add(this.button_c7);
            this.tabPage_Coffee.Controls.Add(this.button_c6);
            this.tabPage_Coffee.Controls.Add(this.button_c5);
            this.tabPage_Coffee.Controls.Add(this.button_c4);
            this.tabPage_Coffee.Controls.Add(this.button_c3);
            this.tabPage_Coffee.Controls.Add(this.button_c2);
            this.tabPage_Coffee.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Coffee.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Coffee.Name = "tabPage_Coffee";
            this.tabPage_Coffee.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Coffee.Size = new System.Drawing.Size(434, 172);
            this.tabPage_Coffee.TabIndex = 0;
            this.tabPage_Coffee.Text = "커피";
            this.tabPage_Coffee.UseVisualStyleBackColor = true;
            // 
            // button_c1
            // 
            this.button_c1.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c1.ForeColor = System.Drawing.Color.Black;
            this.button_c1.Location = new System.Drawing.Point(6, 5);
            this.button_c1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c1.Name = "button_c1";
            this.button_c1.Size = new System.Drawing.Size(78, 78);
            this.button_c1.TabIndex = 20;
            this.button_c1.Tag = "0";
            this.button_c1.Text = "아메리카노";
            this.button_c1.UseVisualStyleBackColor = false;
            this.button_c1.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c10
            // 
            this.button_c10.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c10.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c10.ForeColor = System.Drawing.Color.Black;
            this.button_c10.Location = new System.Drawing.Point(350, 89);
            this.button_c10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c10.Name = "button_c10";
            this.button_c10.Size = new System.Drawing.Size(78, 78);
            this.button_c10.TabIndex = 19;
            this.button_c10.Tag = "9";
            this.button_c10.Text = "콜드브루 라떼";
            this.button_c10.UseVisualStyleBackColor = false;
            this.button_c10.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c9
            // 
            this.button_c9.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c9.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c9.ForeColor = System.Drawing.Color.Black;
            this.button_c9.Location = new System.Drawing.Point(264, 89);
            this.button_c9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c9.Name = "button_c9";
            this.button_c9.Size = new System.Drawing.Size(78, 78);
            this.button_c9.TabIndex = 18;
            this.button_c9.Tag = "8";
            this.button_c9.Text = "콜드브루";
            this.button_c9.UseVisualStyleBackColor = false;
            this.button_c9.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c8
            // 
            this.button_c8.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c8.ForeColor = System.Drawing.Color.Black;
            this.button_c8.Location = new System.Drawing.Point(178, 89);
            this.button_c8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c8.Name = "button_c8";
            this.button_c8.Size = new System.Drawing.Size(78, 78);
            this.button_c8.TabIndex = 17;
            this.button_c8.Tag = "7";
            this.button_c8.Text = "아이스크림 카페라떼";
            this.button_c8.UseVisualStyleBackColor = false;
            this.button_c8.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c7
            // 
            this.button_c7.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c7.ForeColor = System.Drawing.Color.Black;
            this.button_c7.Location = new System.Drawing.Point(92, 89);
            this.button_c7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c7.Name = "button_c7";
            this.button_c7.Size = new System.Drawing.Size(78, 78);
            this.button_c7.TabIndex = 16;
            this.button_c7.Tag = "6";
            this.button_c7.Text = "스페니쉬 연유 카페라떼";
            this.button_c7.UseVisualStyleBackColor = false;
            this.button_c7.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c6
            // 
            this.button_c6.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c6.ForeColor = System.Drawing.Color.Black;
            this.button_c6.Location = new System.Drawing.Point(6, 89);
            this.button_c6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c6.Name = "button_c6";
            this.button_c6.Size = new System.Drawing.Size(78, 78);
            this.button_c6.TabIndex = 15;
            this.button_c6.Tag = "5";
            this.button_c6.Text = "에스프레소";
            this.button_c6.UseVisualStyleBackColor = false;
            this.button_c6.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c5
            // 
            this.button_c5.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c5.ForeColor = System.Drawing.Color.Black;
            this.button_c5.Location = new System.Drawing.Point(350, 5);
            this.button_c5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c5.Name = "button_c5";
            this.button_c5.Size = new System.Drawing.Size(78, 78);
            this.button_c5.TabIndex = 14;
            this.button_c5.Tag = "4";
            this.button_c5.Text = "롱 블랙";
            this.button_c5.UseVisualStyleBackColor = false;
            this.button_c5.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c4
            // 
            this.button_c4.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c4.ForeColor = System.Drawing.Color.Black;
            this.button_c4.Location = new System.Drawing.Point(264, 5);
            this.button_c4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c4.Name = "button_c4";
            this.button_c4.Size = new System.Drawing.Size(78, 78);
            this.button_c4.TabIndex = 13;
            this.button_c4.Tag = "3";
            this.button_c4.Text = "숏 카페라떼";
            this.button_c4.UseVisualStyleBackColor = false;
            this.button_c4.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c3
            // 
            this.button_c3.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c3.ForeColor = System.Drawing.Color.Black;
            this.button_c3.Location = new System.Drawing.Point(178, 5);
            this.button_c3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c3.Name = "button_c3";
            this.button_c3.Size = new System.Drawing.Size(78, 78);
            this.button_c3.TabIndex = 12;
            this.button_c3.Tag = "2";
            this.button_c3.Text = "카라멜 마키아또";
            this.button_c3.UseVisualStyleBackColor = false;
            this.button_c3.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_c2
            // 
            this.button_c2.BackColor = System.Drawing.Color.FloralWhite;
            this.button_c2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_c2.ForeColor = System.Drawing.Color.Black;
            this.button_c2.Location = new System.Drawing.Point(92, 5);
            this.button_c2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_c2.Name = "button_c2";
            this.button_c2.Size = new System.Drawing.Size(78, 78);
            this.button_c2.TabIndex = 3;
            this.button_c2.Tag = "1";
            this.button_c2.Text = "바닐라 카페라떼";
            this.button_c2.UseVisualStyleBackColor = false;
            this.button_c2.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // tabPage_Beverage
            // 
            this.tabPage_Beverage.Controls.Add(this.button_b10);
            this.tabPage_Beverage.Controls.Add(this.button_b9);
            this.tabPage_Beverage.Controls.Add(this.button_b8);
            this.tabPage_Beverage.Controls.Add(this.button_b7);
            this.tabPage_Beverage.Controls.Add(this.button_b6);
            this.tabPage_Beverage.Controls.Add(this.button_b5);
            this.tabPage_Beverage.Controls.Add(this.button_b4);
            this.tabPage_Beverage.Controls.Add(this.button_b3);
            this.tabPage_Beverage.Controls.Add(this.button_b2);
            this.tabPage_Beverage.Controls.Add(this.button_b1);
            this.tabPage_Beverage.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Beverage.Name = "tabPage_Beverage";
            this.tabPage_Beverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Beverage.Size = new System.Drawing.Size(434, 172);
            this.tabPage_Beverage.TabIndex = 2;
            this.tabPage_Beverage.Text = "음료";
            this.tabPage_Beverage.UseVisualStyleBackColor = true;
            // 
            // button_b10
            // 
            this.button_b10.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b10.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b10.ForeColor = System.Drawing.Color.Black;
            this.button_b10.Location = new System.Drawing.Point(350, 89);
            this.button_b10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b10.Name = "button_b10";
            this.button_b10.Size = new System.Drawing.Size(78, 78);
            this.button_b10.TabIndex = 41;
            this.button_b10.Tag = "29";
            this.button_b10.Text = "바닐라 아포카토";
            this.button_b10.UseVisualStyleBackColor = false;
            this.button_b10.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b9
            // 
            this.button_b9.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b9.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b9.ForeColor = System.Drawing.Color.Black;
            this.button_b9.Location = new System.Drawing.Point(264, 89);
            this.button_b9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b9.Name = "button_b9";
            this.button_b9.Size = new System.Drawing.Size(78, 78);
            this.button_b9.TabIndex = 40;
            this.button_b9.Tag = "28";
            this.button_b9.Text = "소프트 아이스크림";
            this.button_b9.UseVisualStyleBackColor = false;
            this.button_b9.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b8
            // 
            this.button_b8.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b8.ForeColor = System.Drawing.Color.Black;
            this.button_b8.Location = new System.Drawing.Point(178, 89);
            this.button_b8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b8.Name = "button_b8";
            this.button_b8.Size = new System.Drawing.Size(78, 78);
            this.button_b8.TabIndex = 39;
            this.button_b8.Tag = "27";
            this.button_b8.Text = "고구마 라떼";
            this.button_b8.UseVisualStyleBackColor = false;
            this.button_b8.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b7
            // 
            this.button_b7.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b7.ForeColor = System.Drawing.Color.Black;
            this.button_b7.Location = new System.Drawing.Point(92, 89);
            this.button_b7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b7.Name = "button_b7";
            this.button_b7.Size = new System.Drawing.Size(78, 78);
            this.button_b7.TabIndex = 38;
            this.button_b7.Tag = "26";
            this.button_b7.Text = "쑥 라떼";
            this.button_b7.UseVisualStyleBackColor = false;
            this.button_b7.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b6
            // 
            this.button_b6.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b6.ForeColor = System.Drawing.Color.Black;
            this.button_b6.Location = new System.Drawing.Point(6, 89);
            this.button_b6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b6.Name = "button_b6";
            this.button_b6.Size = new System.Drawing.Size(78, 78);
            this.button_b6.TabIndex = 37;
            this.button_b6.Tag = "25";
            this.button_b6.Text = "달고나 카페라떼";
            this.button_b6.UseVisualStyleBackColor = false;
            this.button_b6.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b5
            // 
            this.button_b5.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b5.ForeColor = System.Drawing.Color.Black;
            this.button_b5.Location = new System.Drawing.Point(350, 5);
            this.button_b5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b5.Name = "button_b5";
            this.button_b5.Size = new System.Drawing.Size(78, 78);
            this.button_b5.TabIndex = 36;
            this.button_b5.Tag = "24";
            this.button_b5.Text = "흑임자 카페라떼";
            this.button_b5.UseVisualStyleBackColor = false;
            this.button_b5.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b4
            // 
            this.button_b4.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b4.ForeColor = System.Drawing.Color.Black;
            this.button_b4.Location = new System.Drawing.Point(264, 5);
            this.button_b4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b4.Name = "button_b4";
            this.button_b4.Size = new System.Drawing.Size(78, 78);
            this.button_b4.TabIndex = 35;
            this.button_b4.Tag = "23";
            this.button_b4.Text = "스트로베리 초콜렛 프라페";
            this.button_b4.UseVisualStyleBackColor = false;
            this.button_b4.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b3
            // 
            this.button_b3.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b3.ForeColor = System.Drawing.Color.Black;
            this.button_b3.Location = new System.Drawing.Point(178, 5);
            this.button_b3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b3.Name = "button_b3";
            this.button_b3.Size = new System.Drawing.Size(78, 78);
            this.button_b3.TabIndex = 34;
            this.button_b3.Tag = "22";
            this.button_b3.Text = "치즈 크럼블 딸기 쉐이크";
            this.button_b3.UseVisualStyleBackColor = false;
            this.button_b3.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b2
            // 
            this.button_b2.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b2.ForeColor = System.Drawing.Color.Black;
            this.button_b2.Location = new System.Drawing.Point(92, 5);
            this.button_b2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b2.Name = "button_b2";
            this.button_b2.Size = new System.Drawing.Size(78, 78);
            this.button_b2.TabIndex = 33;
            this.button_b2.Tag = "21";
            this.button_b2.Text = "스트로베리 라떼";
            this.button_b2.UseVisualStyleBackColor = false;
            this.button_b2.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_b1
            // 
            this.button_b1.BackColor = System.Drawing.Color.FloralWhite;
            this.button_b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_b1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_b1.ForeColor = System.Drawing.Color.Black;
            this.button_b1.Location = new System.Drawing.Point(6, 5);
            this.button_b1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_b1.Name = "button_b1";
            this.button_b1.Size = new System.Drawing.Size(78, 78);
            this.button_b1.TabIndex = 32;
            this.button_b1.Tag = "20";
            this.button_b1.Text = "생딸기 가득주스";
            this.button_b1.UseVisualStyleBackColor = false;
            this.button_b1.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // tabPage_Dessert
            // 
            this.tabPage_Dessert.Controls.Add(this.button_d10);
            this.tabPage_Dessert.Controls.Add(this.button_d9);
            this.tabPage_Dessert.Controls.Add(this.button_d8);
            this.tabPage_Dessert.Controls.Add(this.button_d7);
            this.tabPage_Dessert.Controls.Add(this.button_d6);
            this.tabPage_Dessert.Controls.Add(this.button_d5);
            this.tabPage_Dessert.Controls.Add(this.button_d4);
            this.tabPage_Dessert.Controls.Add(this.button_d3);
            this.tabPage_Dessert.Controls.Add(this.button_d2);
            this.tabPage_Dessert.Controls.Add(this.button_d1);
            this.tabPage_Dessert.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Dessert.Name = "tabPage_Dessert";
            this.tabPage_Dessert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dessert.Size = new System.Drawing.Size(434, 172);
            this.tabPage_Dessert.TabIndex = 3;
            this.tabPage_Dessert.Text = "디저트";
            this.tabPage_Dessert.UseVisualStyleBackColor = true;
            // 
            // button_d10
            // 
            this.button_d10.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d10.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d10.ForeColor = System.Drawing.Color.Black;
            this.button_d10.Location = new System.Drawing.Point(350, 89);
            this.button_d10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d10.Name = "button_d10";
            this.button_d10.Size = new System.Drawing.Size(78, 78);
            this.button_d10.TabIndex = 26;
            this.button_d10.Tag = "110";
            this.button_d10.Text = "딸기 우리쌀 베리무스";
            this.button_d10.UseVisualStyleBackColor = false;
            this.button_d10.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d9
            // 
            this.button_d9.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d9.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d9.ForeColor = System.Drawing.Color.Black;
            this.button_d9.Location = new System.Drawing.Point(264, 89);
            this.button_d9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d9.Name = "button_d9";
            this.button_d9.Size = new System.Drawing.Size(78, 78);
            this.button_d9.TabIndex = 25;
            this.button_d9.Tag = "109";
            this.button_d9.Text = "스트로베리 티라미수";
            this.button_d9.UseVisualStyleBackColor = false;
            this.button_d9.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d8
            // 
            this.button_d8.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d8.ForeColor = System.Drawing.Color.Black;
            this.button_d8.Location = new System.Drawing.Point(178, 89);
            this.button_d8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d8.Name = "button_d8";
            this.button_d8.Size = new System.Drawing.Size(78, 78);
            this.button_d8.TabIndex = 24;
            this.button_d8.Tag = "108";
            this.button_d8.Text = "생딸기 가득 타르트";
            this.button_d8.UseVisualStyleBackColor = false;
            this.button_d8.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d7
            // 
            this.button_d7.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d7.ForeColor = System.Drawing.Color.Black;
            this.button_d7.Location = new System.Drawing.Point(92, 89);
            this.button_d7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d7.Name = "button_d7";
            this.button_d7.Size = new System.Drawing.Size(78, 78);
            this.button_d7.TabIndex = 23;
            this.button_d7.Tag = "107";
            this.button_d7.Text = "딸기 생크림 치즈 수플레";
            this.button_d7.UseVisualStyleBackColor = false;
            this.button_d7.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d6
            // 
            this.button_d6.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d6.ForeColor = System.Drawing.Color.Black;
            this.button_d6.Location = new System.Drawing.Point(6, 89);
            this.button_d6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d6.Name = "button_d6";
            this.button_d6.Size = new System.Drawing.Size(78, 78);
            this.button_d6.TabIndex = 22;
            this.button_d6.Tag = "106";
            this.button_d6.Text = "스트로베리 초콜릿프라페";
            this.button_d6.UseVisualStyleBackColor = false;
            this.button_d6.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d5
            // 
            this.button_d5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d5.ForeColor = System.Drawing.Color.Black;
            this.button_d5.Location = new System.Drawing.Point(350, 5);
            this.button_d5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d5.Name = "button_d5";
            this.button_d5.Size = new System.Drawing.Size(78, 78);
            this.button_d5.TabIndex = 21;
            this.button_d5.Tag = "105";
            this.button_d5.Text = "스트로베리 라떼";
            this.button_d5.UseVisualStyleBackColor = false;
            this.button_d5.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d4
            // 
            this.button_d4.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d4.ForeColor = System.Drawing.Color.Black;
            this.button_d4.Location = new System.Drawing.Point(264, 5);
            this.button_d4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d4.Name = "button_d4";
            this.button_d4.Size = new System.Drawing.Size(78, 78);
            this.button_d4.TabIndex = 20;
            this.button_d4.Tag = "104";
            this.button_d4.Text = "생딸기 가득 주스";
            this.button_d4.UseVisualStyleBackColor = false;
            this.button_d4.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d3
            // 
            this.button_d3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d3.ForeColor = System.Drawing.Color.Black;
            this.button_d3.Location = new System.Drawing.Point(178, 5);
            this.button_d3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d3.Name = "button_d3";
            this.button_d3.Size = new System.Drawing.Size(78, 78);
            this.button_d3.TabIndex = 19;
            this.button_d3.Tag = "103";
            this.button_d3.Text = "치즈크럼블 딸기 쉐이크";
            this.button_d3.UseVisualStyleBackColor = false;
            this.button_d3.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d2
            // 
            this.button_d2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d2.ForeColor = System.Drawing.Color.Black;
            this.button_d2.Location = new System.Drawing.Point(92, 5);
            this.button_d2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d2.Name = "button_d2";
            this.button_d2.Size = new System.Drawing.Size(78, 78);
            this.button_d2.TabIndex = 18;
            this.button_d2.Tag = "102";
            this.button_d2.Text = "치즈크로플";
            this.button_d2.UseVisualStyleBackColor = false;
            this.button_d2.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // button_d1
            // 
            this.button_d1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_d1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_d1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_d1.ForeColor = System.Drawing.Color.Black;
            this.button_d1.Location = new System.Drawing.Point(6, 5);
            this.button_d1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d1.Name = "button_d1";
            this.button_d1.Size = new System.Drawing.Size(78, 78);
            this.button_d1.TabIndex = 17;
            this.button_d1.Tag = "101";
            this.button_d1.Text = "아이스크림 크로플";
            this.button_d1.UseVisualStyleBackColor = false;
            this.button_d1.Click += new System.EventHandler(this.button_Dessert_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(438, 417);
            this.listView1.TabIndex = 6;
            this.listView1.TileSize = new System.Drawing.Size(408, 62);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "메뉴";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수량";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "금액";
            this.columnHeader3.Width = 59;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "옵션";
            this.columnHeader4.Width = 138;
            // 
            // button_cancel1
            // 
            this.button_cancel1.BackColor = System.Drawing.Color.White;
            this.button_cancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_cancel1.ForeColor = System.Drawing.Color.Black;
            this.button_cancel1.Location = new System.Drawing.Point(463, 460);
            this.button_cancel1.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel1.Name = "button_cancel1";
            this.button_cancel1.Size = new System.Drawing.Size(120, 80);
            this.button_cancel1.TabIndex = 32;
            this.button_cancel1.Text = "선택 취소";
            this.button_cancel1.UseVisualStyleBackColor = false;
            this.button_cancel1.Click += new System.EventHandler(this.button_cancel1_Click);
            // 
            // button_cancel2
            // 
            this.button_cancel2.BackColor = System.Drawing.Color.White;
            this.button_cancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_cancel2.ForeColor = System.Drawing.Color.Black;
            this.button_cancel2.Location = new System.Drawing.Point(587, 460);
            this.button_cancel2.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel2.Name = "button_cancel2";
            this.button_cancel2.Size = new System.Drawing.Size(120, 80);
            this.button_cancel2.TabIndex = 31;
            this.button_cancel2.Text = "전체 취소";
            this.button_cancel2.UseVisualStyleBackColor = false;
            this.button_cancel2.Click += new System.EventHandler(this.button_cancel2_Click);
            // 
            // button_Card
            // 
            this.button_Card.BackColor = System.Drawing.Color.White;
            this.button_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Card.ForeColor = System.Drawing.Color.Black;
            this.button_Card.Location = new System.Drawing.Point(463, 552);
            this.button_Card.Margin = new System.Windows.Forms.Padding(2);
            this.button_Card.Name = "button_Card";
            this.button_Card.Size = new System.Drawing.Size(120, 80);
            this.button_Card.TabIndex = 29;
            this.button_Card.Text = "카드 결제";
            this.button_Card.UseVisualStyleBackColor = false;
            this.button_Card.Click += new System.EventHandler(this.button_Card_Click);
            // 
            // button_Cash
            // 
            this.button_Cash.BackColor = System.Drawing.Color.White;
            this.button_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Cash.ForeColor = System.Drawing.Color.Black;
            this.button_Cash.Location = new System.Drawing.Point(587, 552);
            this.button_Cash.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cash.Name = "button_Cash";
            this.button_Cash.Size = new System.Drawing.Size(120, 80);
            this.button_Cash.TabIndex = 30;
            this.button_Cash.Text = "현금 결제";
            this.button_Cash.UseVisualStyleBackColor = false;
            this.button_Cash.Click += new System.EventHandler(this.button_Cash_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(497, 412);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(29, 13);
            this.label_total.TabIndex = 33;
            this.label_total.Text = "합계";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "메뉴 개수";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(532, 409);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(51, 20);
            this.textBox_total.TabIndex = 36;
            this.textBox_total.Text = "0";
            this.textBox_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(532, 383);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.ReadOnly = true;
            this.textBox_count.Size = new System.Drawing.Size(51, 20);
            this.textBox_count.TabIndex = 37;
            this.textBox_count.Text = "0";
            this.textBox_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_dt
            // 
            this.label_dt.Location = new System.Drawing.Point(493, 24);
            this.label_dt.Name = "label_dt";
            this.label_dt.Size = new System.Drawing.Size(181, 68);
            this.label_dt.TabIndex = 49;
            this.label_dt.Text = "0000년 00월 00일, 000, 00:00:00";
            this.label_dt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_t1
            // 
            this.button_t1.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t1.ForeColor = System.Drawing.Color.Black;
            this.button_t1.Location = new System.Drawing.Point(6, 5);
            this.button_t1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t1.Name = "button_t1";
            this.button_t1.Size = new System.Drawing.Size(78, 78);
            this.button_t1.TabIndex = 22;
            this.button_t1.Tag = "10";
            this.button_t1.Text = "잉글리쉬 브렉퍼스트";
            this.button_t1.UseVisualStyleBackColor = false;
            this.button_t1.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t2
            // 
            this.button_t2.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t2.ForeColor = System.Drawing.Color.Black;
            this.button_t2.Location = new System.Drawing.Point(92, 5);
            this.button_t2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t2.Name = "button_t2";
            this.button_t2.Size = new System.Drawing.Size(78, 78);
            this.button_t2.TabIndex = 23;
            this.button_t2.Tag = "11";
            this.button_t2.Text = "얼그레이";
            this.button_t2.UseVisualStyleBackColor = false;
            this.button_t2.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t3
            // 
            this.button_t3.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t3.ForeColor = System.Drawing.Color.Black;
            this.button_t3.Location = new System.Drawing.Point(178, 5);
            this.button_t3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t3.Name = "button_t3";
            this.button_t3.Size = new System.Drawing.Size(78, 78);
            this.button_t3.TabIndex = 24;
            this.button_t3.Tag = "12";
            this.button_t3.Text = "민트";
            this.button_t3.UseVisualStyleBackColor = false;
            this.button_t3.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t4
            // 
            this.button_t4.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t4.ForeColor = System.Drawing.Color.Black;
            this.button_t4.Location = new System.Drawing.Point(264, 5);
            this.button_t4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t4.Name = "button_t4";
            this.button_t4.Size = new System.Drawing.Size(78, 78);
            this.button_t4.TabIndex = 25;
            this.button_t4.Tag = "13";
            this.button_t4.Text = "블랙티";
            this.button_t4.UseVisualStyleBackColor = false;
            this.button_t4.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t5
            // 
            this.button_t5.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t5.ForeColor = System.Drawing.Color.Black;
            this.button_t5.Location = new System.Drawing.Point(350, 5);
            this.button_t5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t5.Name = "button_t5";
            this.button_t5.Size = new System.Drawing.Size(78, 78);
            this.button_t5.TabIndex = 26;
            this.button_t5.Tag = "14";
            this.button_t5.Text = "카모마일";
            this.button_t5.UseVisualStyleBackColor = false;
            this.button_t5.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t6
            // 
            this.button_t6.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t6.ForeColor = System.Drawing.Color.Black;
            this.button_t6.Location = new System.Drawing.Point(6, 89);
            this.button_t6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t6.Name = "button_t6";
            this.button_t6.Size = new System.Drawing.Size(78, 78);
            this.button_t6.TabIndex = 27;
            this.button_t6.Tag = "15";
            this.button_t6.Text = "크림 카라멜";
            this.button_t6.UseVisualStyleBackColor = false;
            this.button_t6.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t7
            // 
            this.button_t7.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t7.ForeColor = System.Drawing.Color.Black;
            this.button_t7.Location = new System.Drawing.Point(92, 89);
            this.button_t7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t7.Name = "button_t7";
            this.button_t7.Size = new System.Drawing.Size(78, 78);
            this.button_t7.TabIndex = 28;
            this.button_t7.Tag = "16";
            this.button_t7.Text = "제주 유기농 녹차";
            this.button_t7.UseVisualStyleBackColor = false;
            this.button_t7.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t8
            // 
            this.button_t8.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t8.ForeColor = System.Drawing.Color.Black;
            this.button_t8.Location = new System.Drawing.Point(178, 89);
            this.button_t8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t8.Name = "button_t8";
            this.button_t8.Size = new System.Drawing.Size(78, 78);
            this.button_t8.TabIndex = 29;
            this.button_t8.Tag = "17";
            this.button_t8.Text = "애플 민트티";
            this.button_t8.UseVisualStyleBackColor = false;
            this.button_t8.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t9
            // 
            this.button_t9.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t9.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t9.ForeColor = System.Drawing.Color.Black;
            this.button_t9.Location = new System.Drawing.Point(264, 89);
            this.button_t9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t9.Name = "button_t9";
            this.button_t9.Size = new System.Drawing.Size(78, 78);
            this.button_t9.TabIndex = 30;
            this.button_t9.Tag = "18";
            this.button_t9.Text = "허니 레몬티";
            this.button_t9.UseVisualStyleBackColor = false;
            this.button_t9.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // button_t10
            // 
            this.button_t10.BackColor = System.Drawing.Color.FloralWhite;
            this.button_t10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_t10.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_t10.ForeColor = System.Drawing.Color.Black;
            this.button_t10.Location = new System.Drawing.Point(350, 89);
            this.button_t10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_t10.Name = "button_t10";
            this.button_t10.Size = new System.Drawing.Size(78, 78);
            this.button_t10.TabIndex = 31;
            this.button_t10.Tag = "19";
            this.button_t10.Text = "버블 밀크티";
            this.button_t10.UseVisualStyleBackColor = false;
            this.button_t10.Click += new System.EventHandler(this.button_Drink_Click);
            // 
            // tabPage_Tea
            // 
            this.tabPage_Tea.Controls.Add(this.button_t10);
            this.tabPage_Tea.Controls.Add(this.button_t9);
            this.tabPage_Tea.Controls.Add(this.button_t8);
            this.tabPage_Tea.Controls.Add(this.button_t7);
            this.tabPage_Tea.Controls.Add(this.button_t6);
            this.tabPage_Tea.Controls.Add(this.button_t5);
            this.tabPage_Tea.Controls.Add(this.button_t4);
            this.tabPage_Tea.Controls.Add(this.button_t3);
            this.tabPage_Tea.Controls.Add(this.button_t2);
            this.tabPage_Tea.Controls.Add(this.button_t1);
            this.tabPage_Tea.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Tea.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Tea.Name = "tabPage_Tea";
            this.tabPage_Tea.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Tea.Size = new System.Drawing.Size(434, 172);
            this.tabPage_Tea.TabIndex = 1;
            this.tabPage_Tea.Text = "차";
            this.tabPage_Tea.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(716, 681);
            this.Controls.Add(this.label_dt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button_cancel1);
            this.Controls.Add(this.button_cancel2);
            this.Controls.Add(this.button_Card);
            this.Controls.Add(this.button_Cash);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "pos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Coffee.ResumeLayout(false);
            this.tabPage_Beverage.ResumeLayout(false);
            this.tabPage_Dessert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_Tea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Coffee;
        private System.Windows.Forms.Button button_c10;
        private System.Windows.Forms.Button button_c9;
        private System.Windows.Forms.Button button_c8;
        private System.Windows.Forms.Button button_c7;
        private System.Windows.Forms.Button button_c6;
        private System.Windows.Forms.Button button_c5;
        private System.Windows.Forms.Button button_c4;
        private System.Windows.Forms.Button button_c3;
        private System.Windows.Forms.Button button_c2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_cancel1;
        private System.Windows.Forms.Button button_cancel2;
        private System.Windows.Forms.Button button_Card;
        private System.Windows.Forms.Button button_Cash;
        private System.Windows.Forms.TabPage tabPage_Beverage;
        private System.Windows.Forms.TabPage tabPage_Dessert;
        private System.Windows.Forms.Button button_d10;
        private System.Windows.Forms.Button button_d9;
        private System.Windows.Forms.Button button_d8;
        private System.Windows.Forms.Button button_d7;
        private System.Windows.Forms.Button button_d6;
        private System.Windows.Forms.Button button_d5;
        private System.Windows.Forms.Button button_d4;
        private System.Windows.Forms.Button button_d3;
        private System.Windows.Forms.Button button_d2;
        private System.Windows.Forms.Button button_d1;
        private System.Windows.Forms.Button button_b10;
        private System.Windows.Forms.Button button_b9;
        private System.Windows.Forms.Button button_b8;
        private System.Windows.Forms.Button button_b7;
        private System.Windows.Forms.Button button_b6;
        private System.Windows.Forms.Button button_b5;
        private System.Windows.Forms.Button button_b4;
        private System.Windows.Forms.Button button_b3;
        private System.Windows.Forms.Button button_b2;
        private System.Windows.Forms.Button button_b1;
        private System.Windows.Forms.Button button_c1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_dt;
        private System.Windows.Forms.TabPage tabPage_Tea;
        private System.Windows.Forms.Button button_t10;
        private System.Windows.Forms.Button button_t9;
        private System.Windows.Forms.Button button_t8;
        private System.Windows.Forms.Button button_t7;
        private System.Windows.Forms.Button button_t6;
        private System.Windows.Forms.Button button_t5;
        private System.Windows.Forms.Button button_t4;
        private System.Windows.Forms.Button button_t3;
        private System.Windows.Forms.Button button_t2;
        private System.Windows.Forms.Button button_t1;
    }
}

