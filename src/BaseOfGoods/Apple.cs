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
    }
      


   
}
