using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    int rowNumLeft;
    int colNumLeft;
    int rowNumRight;
    int colNumRight;
   
   
    //Outputting Values
   Console.WriteLine("Move row ");
   
    Random rnd = new Random();
 
for (int j = 0; j < 1; j++)
{
   Console.WriteLine(rnd.Next(1,20));//returns random integers >= 1 and < 20
}
    Console.WriteLine(" column ");
   
 
for (int j = 0; j < 1; j++)
{
   Console.WriteLine(rnd.Next(1,15));//returns random integers >= 1 and < 15
} 
    Console.WriteLine(" to row ");
 
for (int j = 0; j < 1; j++)
{
   Console.WriteLine(rnd.Next(1, 20));//returns random integers >= 1 or < 20
} 
   Console.WriteLine(" column ");
  
 
for (int j = 0; j < 1; j++)
{
   Console.WriteLine(rnd.Next(15,30));//returns random integers >= 15 or < 30
}
    
   
   
    }
 }
}
