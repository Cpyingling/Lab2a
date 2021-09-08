/* Author: Charles Yingling  Date: 9/7/2021 Lab2a
The program must take as input the item name, quantity and unit price. 
Then write code to multiple quantity by unit price and display the result as total price
*/
using System;

class Program {

  public static void Main (string[] args) {
    //item name
    Console.WriteLine ("Enter the name of item.");
    var name = Console.ReadLine();
    //item quantity
    Console.WriteLine ("Enter the quantity.");
    double quantity = Convert.ToDouble(Console.ReadLine());
    //item price
    Console.WriteLine ("Enter the price.");
    double price = Convert.ToDouble(Console.ReadLine());
    //multiply quantity by price
    double total = price * quantity;
    //total price
    Console.WriteLine ($"Total price of {name} =$ {total}");
  }
}