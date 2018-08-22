using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to code later
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favoriteColor;
            string helpMenu;
            int numberOfSiblings;
            string vacationHome;
            string modeOfTransportation;
            decimal amountOfMoney;
            //int retirementAge;
            int retirementAge = 65;
            int yearsUntilRetirement = 0;
            bool isEven;

            //questions to ask have to add "helpMenu" and "ROYGBIV" 

            Console.WriteLine("Greetings! My name is ZOLTAR, answer the questions below to reveal your fortune!");

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born? Please use the numeric value 1-12 that corresponds with your birth month.");
            birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite color? Please choose from ROYGBIV, if you dont know the colors for ROYGBIV, type HELP");
            favoriteColor = Console.ReadLine().ToLower();

            if (favoriteColor == "help")
            {
                Console.WriteLine("ROYGBIV = Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.WriteLine("What is your favorite color? Choose from the list above");
                favoriteColor = Console.ReadLine();
            };

            Console.WriteLine("How many siblings do you have?");
            numberOfSiblings = int.Parse(Console.ReadLine());

            //calculate the years until retirement based on the following: even or odd years
            //use % thing to give me true or false, even or odd
            //use If Else
            //yearsUntilRetirement = retirementAge - age;
            if (yearsUntilRetirement % 2 == 0)
            {
                yearsUntilRetirement = 25;
            }
            else
            {
                yearsUntilRetirement = 30;
            }
                


            //list out vacation homes cities = # of siblings include <=0,0,1,2,3,<3 maybe use If Else If Else
            //make a shitty city for siblings <=0
            //cool city for <3
            //< 0 = Orlando
            //0= Rome
            //1= Sydney
            //2= London
            //3= Manhattan
            //>3= Amalfi Coast

            //Use switches and else ifs etc

            //Console.WriteLine("How many siblings do you have?");
            //numberOfSiblings = int.Parse(Console.ReadLine().ToLower());

            //Logic for where your vacation home is
            if (numberOfSiblings == 0)
            {
                vacationHome = "Rome";
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "Sydney";
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = "London";
            }
            else if (numberOfSiblings == 3)
            {
                vacationHome = "Manhattan";
            }
            else if (numberOfSiblings > 3)
            {
                vacationHome = "Amalfi Coast";
            }
            else 
            {
                vacationHome = "Orlando";
            }

            //Logic for Mode Of Transportation
            // list 7 cars to equal colors maybe use switch case and REMEMBER there is a default at the END
            //Red=Corvet
            //Orange=Charger
            //Yellow=Hummer
            //Green=Mustang
            //Blue=BMW
            //Indigo=Honda CRV
            //Violet=Bugatti

            switch (favoriteColor)
            {
                case "red":
                    modeOfTransportation = "Corvette";
                    break;

                case "orange":
                    modeOfTransportation = "Charger";
                    break;

                case "yellow":
                    modeOfTransportation = "Hummer";
                    break;

                case "green":
                    modeOfTransportation = "Mustang";
                    break;

                case "blue":
                    modeOfTransportation = "BMW M5";
                    break;
                case "indigo":
                    modeOfTransportation = "Honda CRV";
                    break;
                case "violet":
                    modeOfTransportation = "Bugatti";
                    break;
                default:
                    modeOfTransportation = "Big Wheel";
                    break;
            }
            // use ELSE IF IF for birthMonth to amountOfMoney
            //list birth months equal to amount of money include <1,>12= $0.00 m
            //<1=$0.00
            //1-4=$750,000.00
            //5-8=$5,000,000.00
            //9-12=$10,000,000.00
            //>12=$0.0

            if (birthMonth <= 4)
            {
                amountOfMoney = 750000.00M;
            }
            else if (birthMonth <= 8)
            {
                amountOfMoney = 5000000.00M;
            }
            else if (birthMonth <= 12)
            {
                amountOfMoney = 10000000.00M;
            }
            else
            {
                amountOfMoney = 0.00M;
            }

            //concatination 
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");

           // Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetirement + " years with $" + amountOfMoney + " in the bank, a vacation home in " + vacationHome + ", and a " + modeOfTransportation  + ". ");
            Console.WriteLine(" {0} {1} will retire in {2} years with ${3} in the bank, and a vacation home in {4} and a {5}", firstName, lastName, yearsUntilRetirement, amountOfMoney, vacationHome, modeOfTransportation);
        }
    }
}
