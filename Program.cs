using ConsoleApp2;

var creditCard = CreditCard.FromValue(2);
var creditCard2 = CreditCard2.FromName("Standard");


Console.WriteLine($"Discount for {creditCard} is {creditCard.Discount:P}");

Console.ReadKey();