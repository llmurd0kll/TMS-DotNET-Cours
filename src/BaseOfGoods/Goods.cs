using System;
using System.Collections.Generic;
using System.Linq;



/*Что нужно для реализации:
 * Добавление нового товара в базу
 * Удаление товара из базы
 * Поиск товара 
 * 
 * 
 * 
 */

namespace BaseOfGoods
{


    public abstract class Goods
    {
        public string name;
        public double price;
        public bool IsInStock;

        protected Goods(string name, double price, bool isInStock)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
        }

       




    }




   
}
