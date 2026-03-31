using ProductApp.Models;

// ex. 1 & 2 - test if object is created successfully

var product1 = new Product("HP laptop", 600.00, 20);

Console.WriteLine(product1.Name);

// ex. 3 - test TotalValue property

var product2 = new Product("Speakers", 80.00, 4);

Console.WriteLine(product1.TotalValue);
Console.WriteLine(product2.TotalValue);
