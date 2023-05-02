namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() !=  typeof(Product)) return false;
            Product p = (Product) obj;
            return this.Name.Equals(p.Name) && this.Price == p.Price;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
