namespace ProductApp.Models
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public double TotalValue
        {
            get { return Price * Quantity; }
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
