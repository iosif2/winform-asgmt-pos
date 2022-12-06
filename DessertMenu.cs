namespace winform_asgmt_pos
{
    public class DessertMenu
    {
        public string name { get; }
        public int price { get; }
        public bool toGo { get; set; }
        public int index;
        public DessertMenu(string name, int price, int index)
        {
            this.name = name;
            this.price = price;
            this.index = index;
            toGo = true;
        }
    }
}
