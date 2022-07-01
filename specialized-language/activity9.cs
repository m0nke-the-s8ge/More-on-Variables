using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    int userMinutes;
    int outHours;
    int outMinutes;
  
   
    //Assign Values
    userMinutes = 367;
    outHours = userMinutes / 60;
    outMinutes = userMinutes % 60;
 
 
    //Outputting Values
   Console.WriteLine(userMinutes + " minutes is " + outHours + " hours and " + outMinutes + " minutes.\n");
   
   
   
    }
 }
}
