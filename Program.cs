// Этот код демонстрирует проблему дублирования кода при подсчете суммы корзины покупок.
// using System;
// using System.Collections.Generic;
// class Program
// {
//     static void Main()
//     {
//         List<Product> cart1 = new List<Product>
//         {
//             new Product { Name = "Laptop", Price = 1000 },
//             new Product { Name = "Mouse", Price = 50 }
//         };

//         List<Product> cart2 = new List<Product>
//         {
//             new Product { Name = "Keyboard", Price = 100 },
//             new Product { Name = "Monitor", Price = 300 }
//         };

//         // Повторяющийся код для подсчета суммы корзины cart1
//         double total1 = 0;
//         foreach (var product in cart1)
//         {
//             total1 += product.Price;
//         }
//         Console.WriteLine($"Total for cart1: {total1}");

//         // Повторяющийся код для подсчета суммы корзины cart2
//         double total2 = 0;
//         foreach (var product in cart2)
//         {
//             total2 += product.Price;
//         }
//         Console.WriteLine($"Total for cart2: {total2}");
//     }
// }

// class Product
// {
//     public string Name { get; set; }
//     public double Price { get; set; }
// }
// Этот код демонстрирует использование паттерна Стратегия для подсчета суммы корзины покупок с разными стратегиями расчета.
using System;
using ShoppingCart;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Cart cart1 = new Cart(new SimpleTotalStrategy());
        cart1.Products.Add(new Product { Name = "Футболка", Price = 5000 });
        cart1.Products.Add(new Product { Name = "Шапка", Price = 2550 });

        
        Cart cart2 = new Cart(new DiscountTotalStrategy(10)); 
        cart2.Products.Add(new Product { Name = "Кроссовки", Price = 23000 });
        cart2.Products.Add(new Product { Name = "Ботинки", Price = 30000 });

        Console.WriteLine($"Total for cart1: {cart1.GetTotal()}");
        Console.WriteLine($"Total for cart2: {cart2.GetTotal()}");
    }
}
