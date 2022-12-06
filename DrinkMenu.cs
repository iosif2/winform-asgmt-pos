namespace winform_asgmt_pos
{

    public class DrinkMenu
    {
        public enum Category
        {
            None = 0,
            Coffee = 1,
            Tea = 2,
            Beverage = 3
        }
        public enum Bean
        {
            None = 0,
            BlackGround = 1,
            Aroma = 2,
            DeCaff = 3
        }
        public string name
        {
            get;
            set;
        }
        private int price
        {
            get;
            set;
        }
        public bool isIced
        {
            get; set;
        }
        public bool sizeup { get; set; }
        public Category category { get; }
        public Bean bean { get; set; }
        public bool toGo { get; set; }
        public int index;

        public DrinkMenu(string name, int price, Category category, int index)
        {
            this.name = name;
            this.price = price;
            sizeup = false;
            this.category = category;
            this.index = index;
            if (this.category == Category.Coffee)
            {
                bean = Bean.BlackGround;
            }
            else
            {
                bean = Bean.None;
            }
            toGo = true;
        }

        public string GetName()
        {
            return ((isIced) ? "아이스 " + name : name) + ((sizeup) ? " L" : " R");
        }
        public int GetPrice()
        {
            return (sizeup) ? price + 500 : price;
        }
    }
}
