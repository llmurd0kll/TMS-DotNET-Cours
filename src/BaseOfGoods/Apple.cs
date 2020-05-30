namespace BaseOfGoods
{
    /// <summary>
    /// Apple class.
    /// </summary>
    public class Apple : Fruits
    {
        public bool IsFresh;
        /// <summary>
        /// Apple constructor.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="isInStock">Available in stock</param>
        /// <param name="IsFresh">Fresh param</param>
        /// <param name="ID">Id of item</param>
        public Apple(string name, double price, bool isInStock, bool IsFresh, byte ID) : base(name, price, isInStock, ID)
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
        /// <returns>Apple characteristic</returns>
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
