namespace BaseOfGoods
{
    /// <summary>
    /// Watermelon class.
    /// </summary>
    public class Watermelon : Fruits
    {
        public bool IsFresh;
        /// <summary>
        /// Watermelon contructor.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="isInStock">Available in stock</param>
        /// <param name="IsFresh">Frash param</param>
        /// <param name="ID">Id of item</param>
        public Watermelon(string name, double price, bool isInStock, bool IsFresh, byte ID) : base(name, price, isInStock, ID)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
            this.ID = ID;
            this.IsFresh = IsFresh;
        }
        /// <summary>
        /// Print to console
        /// </summary>
        /// <returns>Watermelon characteristic</returns>
        public override string ToString()
        {
            string a;
            if (IsInStock == true)
            {
                a = "In stock";
            }
            else
            {
                a = "Not in stock";
            }
            string b;
            if (IsFresh == true)
            {
                b = "It's fresh";
            }
            else
            {
                b = "It's not fresh";
            }
            return "Name: " + name + ", Price: " + price + ", " + a + ", " + b;
        }

    }
}