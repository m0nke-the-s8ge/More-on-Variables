using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    float areaSquare;
    float sideSquare;
   
   
    //Assign Values
    areaSquare = 49.0f;
    sideSquare = (float)Math.Sqrt(areaSquare);
   
   
    //Outputting Values
    Console.WriteLine("Square root of " + areaSquare + " is " + sideSquare);
   
   
    }
 }
}
