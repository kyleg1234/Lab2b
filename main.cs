using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter a number: "); 
 var num1 = Console.ReadLine();
    Console.Write("Enter another number: ");
 var num2 = Console.ReadLine();
int x1 = Convert.ToInt32(num1);
int y1 = Convert.ToInt32(num2);
Console.Write("Sum = ");
Console.WriteLine(x1+y1);
Console.Write("Diff = ");
Console.WriteLine(x1-y1);
Console.Write("Product = ");
Console.WriteLine(x1*y1);
Console.Write("Quotient = ");
Console.WriteLine(x1/y1);
Console.Write("Remainder = ");
Console.WriteLine(x1%y1);
    
  }
}