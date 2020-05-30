namespace BaseOfGoods
{

    /// <summary>
    /// Goods class.
    /// </summary>
    public abstract class Goods
    {
        public string name;
        public double price;
        public bool IsInStock;
        /// <summary>
        /// Goods constructor.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="isInStock">Available in stock</param>
        public Goods(string name, double price, bool isInStock)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
        }






    }





}
