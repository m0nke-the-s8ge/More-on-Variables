using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    float SOUND_SPEED;
    int SEC_PER_HOUR;
    float secBetween;
    float timeInHours;
    float distinMiles;
  
   
    //Assign Values
    SOUND_SPEED = 761.207f;
    SEC_PER_HOUR = 3600;
 
    //Get seconds between lightning and thunder
    secBetween = 7.0f;
    timeInHours = secBetween / SEC_PER_HOUR;
    distinMiles = SOUND_SPEED * timeInHours;
  
   
    //Outputting Values
   Console.WriteLine("Miles from lightning strike ");
   Console.WriteLine(Math.Round(distinMiles, 4));
   
   
   
    }
 }
}
