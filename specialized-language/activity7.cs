
using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    int kidsFamily1;
    int kidsFamily2;
    int numFamilies;
    float avgKidsPerFamily;
  
   
    //Assign Values
    numFamilies = 2;
    kidsFamily1 = 3;
    kidsFamily2 = 4;
   
    avgKidsPerFamily = (1.0f * kidsFamily1 + kidsFamily2) / numFamilies;
 
    //Outputting Values
   Console.WriteLine("Average kids per family is: " + avgKidsPerFamily);
   
   
   
    }
 }
}
