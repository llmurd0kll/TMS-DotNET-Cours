namespace BaseOfGoods
{
    /// <summary>
    /// Fruits class.
    /// </summary>
    public class Fruits : Goods
    {
        public byte ID;

        /// <summary>
        /// Fruits constructor.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="isInStock">Available in stock</param>
        /// <param name="ID">Id of item</param>
        public Fruits(string name, double price, bool isInStock, byte ID) : base(name, price, isInStock)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
            this.ID = ID;
        }
    }




}
