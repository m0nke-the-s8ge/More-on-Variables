using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    int randomValue;
     
    //Outputting Values
   Random rnd = new Random();
 
for (int j = 0; j < 3; j++)
{
   Console.WriteLine(rnd.Next(1,4));//returns random integers >= 1 or < 4
}
   
   
   
    }
 }
}

