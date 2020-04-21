using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseOfGoods
{

    /// <summary>
    /// Товары
    /// </summary>
    public abstract class Goods
    {
        public string name;
        public double price;
        public bool IsInStock;

        public  Goods(string name, double price, bool isInStock)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
        }

       




    }




   
}
