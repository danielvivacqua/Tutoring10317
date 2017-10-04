using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring10317
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pick a number one through five.");
            //Console.WriteLine("Based on your number, I will tell you who the greatest superhero is.");
            //Console.WriteLine("Enter your number now!");

            //int userNumber = int.Parse(Console.ReadLine());
            //string bestHero = "";

            //switch(userNumber)
            //{
            //    case 1:
            //        bestHero = "Wonder Woman";
            //        break;
            //    case 2:
            //        bestHero = "Wolverine";
            //        break;
            //    case 3:
            //        bestHero = "Spider-Man";
            //        break;
            //    case 4:
            //        bestHero = "Batgirl";
            //        break;
            //    case 5:
            //        bestHero = "Batman";
            //        break;
            //    default:
            //        bestHero = "Superman";
            //        break;
            //}

            //Console.WriteLine(bestHero + " is the very best!");

            //Console.WriteLine("What is your favorite CDMRW animal?");
            //Console.WriteLine("If you don't know what CDMRW stands for, type help.");

            //string faveAnimal = Console.ReadLine().ToLower();
            //string snack = "";

            //while(faveAnimal == "help")
            //{
            //    Console.WriteLine("Cat\tDog\tMonkey\tReindeer\tWhale");
            //    Console.WriteLine("Please enter your favorite CDMRW animal.");
            //    faveAnimal = Console.ReadLine().ToLower();
            //}

            //switch(faveAnimal)
            //{
            //    case "cat":
            //        snack = "tuna";
            //        break;
            //    case "dog":
            //        snack = "bacon";
            //        break;
            //    case "monkey":
            //        snack = "banana";
            //        break;
            //    case "reindeer":
            //        snack = "carrot";
            //        break;
            //    case "whale":
            //        snack = "twinkies";
            //        break;
            //    default:
            //       while(faveAnimal != "cat" && faveAnimal != "dog" && faveAnimal != "monkey" && faveAnimal != "reindeer" && faveAnimal != "whale")
            //        {
            //            Console.WriteLine("Please enter a correct animal.");
            //            faveAnimal = Console.ReadLine().ToLower();
            //        }
            //            break;
            //}

            //Console.WriteLine("Enjoy a healthy " + snack);

            Console.WriteLine("Do you like blues or reds?");
            string userPreference = Console.ReadLine().ToLower();
            
            if(userPreference == "reds")
            {
                Console.WriteLine("Do you like maroon or blood red?");
                string userRed = Console.ReadLine().ToLower();
                if (userRed == "maroon")
                {
                    Console.WriteLine("Like the band with the five?");
                }
                else if (userRed == "blood red") ;
                {
                    Console.WriteLine("Do you want to be a doctor?");
                }
                else 
                {
                    Console.WriteLine("That wasn't a choice.");
                }
            }
            else if(userPreference == "blues")
            {
                Console.WriteLine("Do you like navy or baby blue?");

            }









        }
    }
}
