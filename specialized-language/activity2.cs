using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    float initMass;
    float growthRate;
    float yearsGrow;
    float finalMass;
   
    //Assign Values
    initMass = 10000.0f;
   
    //Get growthRate. Ex. 0.05 is 5%/year
    growthRate = 0.40f;
    yearsGrow = 10.0f;
   
    //Ex. Rate of 0.05 yields intMass * 1.05 * yearsGrow
    finalMass = initMass * (float)Math.Pow(1.0f + growthRate, yearsGrow);
 
   
    //Outputting Values
    Console.WriteLine("Final mass after " + yearsGrow + " years is " + finalMass);
   
   
   
    }
 }
}
