using System;

namespace BaseOfGoods
{
    /// <summary>
    /// Яблоки
    /// </summary>
    public class Apple : Fruits
    {
        public bool IsFresh;

        public Apple(string name, double price, bool isInStock, bool IsFresh, byte ID) : base(name, price, isInStock, ID)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
            this.ID = ID;
            this.IsFresh = IsFresh;
        }
       
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
