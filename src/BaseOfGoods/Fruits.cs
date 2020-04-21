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
    public class Fruits : Goods
    {
        public byte ID;

        public Fruits(string name, double price, bool isInStock, byte ID) : base(name, price, isInStock)
        {
            this.name = name;
            this.price = price;
            IsInStock = isInStock;
            this.ID = ID;
        }
    }



   
}
