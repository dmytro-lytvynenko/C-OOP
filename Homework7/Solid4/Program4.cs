using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IDiscount
{
    void ApplyDiscount(String discount);
}

interface IPromocode
{
    void ApplyPromocode(String promocode);
}
interface IColor
{
    void SetColor(byte color);
}
interface ISize
{
    void SetSize(byte size);
}
interface IPrice
{
    void SetPrice(double price);
}

class Book : IPrice, IDiscount
{
    public double Price;
    public String Discount;
    public void SetPrice(double price){
        Price=price;
    }
    public void ApplyDiscount(String discount){
        Discount=discount;
    }
}

class Outwear : IColor, ISize, IPrice, IDiscount
{
    public byte Color, Size;
    public double Price;
    public String Discount;
    public void SetColor(byte color){
        Color=color;
    }
    public void SetSize(byte size){
        Size=size;
    }
    public void SetPrice(double price){
        Price=price;
    }
    public void ApplyDiscount(String discount){
        Discount=discount;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.SetPrice(500);
        book.ApplyDiscount("5%");
        Console.WriteLine("Book price is {0}, discount is {1}", book.Price, book.Discount);

        Outwear hat = new Outwear();
        hat.SetColor(15);
        hat.SetSize(52);
        hat.SetPrice(700);
        hat.ApplyDiscount("10%");
        Console.WriteLine("Hat color is {0}, size is {1}, price is {2}, discount is {3}",
        hat.Color, hat.Size, hat.Price, hat.Discount);

        Console.ReadKey();
    }
}