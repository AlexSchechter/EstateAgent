using System;
using System.Linq;
using Estates.Business;
using Alex.Common;

namespace Excercise_3C
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            while (userInput != "d")
            {
                userInput = "";
                while (userInput != "a" && userInput != "b" && userInput != "c" & userInput != "d")
                {
                    Console.WriteLine("Please chose one of the options below: ");
                    Console.WriteLine("a: Add listing");
                    Console.WriteLine("b: Remove listing");
                    Console.WriteLine("c: Show all listings");
                    Console.WriteLine("d: Quit");
                    userInput = Console.ReadLine().ToLower();                   
                }

                switch (userInput)
                {
                    case "a":                        
                        createNewEstate();
                        break;
                    case "b":                     
                        int idToRemove = InputChecker.AskCheckAndReAskForIntegerInput
                            ("\nPlease enter the ID of the property you would like to delete: ");
                        if (EstateRepository.ListEstates().Any(x => x.EstateID == idToRemove))
                        {
                            EstateRepository.DeleteEstate(idToRemove);
                            Console.WriteLine("\nThe property with the ID {0} has been removed.", idToRemove);
                        }
                        else
                            Console.WriteLine(idToRemove + 
                                " is not an ID associated with a property in the database and so no property has been removed.");                      
                        break;
                    case "c":
                        EstateRepository.ListEstates().OrderBy(x=>x.EstateID).ToList().ForEach(displayEstate);               
                        break;
                    default:
                        Console.WriteLine("\nThank you for using Estate Management 3000!");
                        break;
                }

                Console.WriteLine("\nPlease press any key to continue");
                Console.ReadKey();               
                Console.Clear();
            }
        }

        public static void createNewEstate()
        {
            const int minimumSqF = 100;
            const int maximumSqF = 100000;
            const int maximumBathroom = 20;
            const int maximuBedroom = 50;

            Console.WriteLine("\nPlease enter the postcode of the new property: ");
            string postcode = Console.ReadLine();

            int sqF = InputChecker.AskCheckAndReAskForIntegerInput("Please enter the square footage of the new property as a positive integer between "
                    + minimumSqF + " and " + maximumSqF + ": ", minimumSqF, maximumSqF);

            int bedrooms = InputChecker.AskCheckAndReAskForIntegerInput("Please enter the number of bedrooms in the new property as a positive integer below "
                        + maximuBedroom + ": ", 1, maximuBedroom);

            int bathrooms = InputChecker.AskCheckAndReAskForIntegerInput("Please enter the number of bathrooms in the new property as a positive integer below: "
                        + maximumBathroom + ": ", 1, maximumBathroom);

            EstateRepository.SaveEstate(bedrooms, bathrooms, postcode, sqF);
        }

        public static void displayEstate(Estate estate)
        {
            Console.WriteLine("\nProperty ID {0}: Postcode {1}, Square Foot {2}, Bedrooms {3}, Bathrooms {4}",
                estate.EstateID, estate.Postcode, estate.SqF, estate.Bedrooms, estate.Bathrooms);
        }       
    }
}