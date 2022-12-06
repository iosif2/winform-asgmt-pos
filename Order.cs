namespace winform_asgmt_pos
{
    public class Order
    {
        public string timestamp;
        public string name;
        private int unit_price;
        public int quantity;
        public string options;
        public int index;
        public Order(string name, int unit_price, int quantity, string options, int index)
        {
            this.name = name;
            this.unit_price = unit_price;
            this.quantity = quantity;
            this.options = options;
            this.index = index;
        }

        public int GetPrice()
        {
            return unit_price * quantity;
        }
    }
}
