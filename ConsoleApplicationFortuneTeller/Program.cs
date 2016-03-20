using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            string userAge = "";
            string birthMonth = "";
            string numSiblings = "";
            string transportationMode = "";
            string favoriteColor = "";
            int retireYears = 0;
            string homeLocation = "";
            string bankAmount = "";
            string tryAgain = "";
            string tryAgainFallThrough = "";
            //string myQuitter;
            //string myRestarter;
            string firstName = "";
            string lastName = "";
            string decadeDigit;
            string balanceDigit;
            char[] ageArray;
            string tensDigit;
            string singlesDigit;
            char[] siblingsArray;


            do
            {
                string myQuitter = "";
                string myRestarter = "";

                Console.WriteLine();
                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine();
                firstName = firstName.ToLower();
                if (firstName == "quit") break;
                if (firstName == "restart") continue;
                //Console.WriteLine("firstName = " + firstName);
                Console.WriteLine();

                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine();
                //lastName = lastName.ToLower();
                //Console.WriteLine("lastName = " + lastName);
                Console.WriteLine();
                if (lastName == "quit") break;
                if (lastName == "restart") continue;

                do
                {
                    Console.WriteLine("What is your age?");
                    string blankAge = Console.ReadLine();//Blank request
                    if (blankAge == "quit") { myQuitter = "quit"; break; }
                    if (blankAge == "restart") { myRestarter = "restart"; break; }
                    Console.WriteLine();
                    Console.WriteLine("What is your decade digit of your age? (the decade digit of 78 is 7)");
                    decadeDigit = Console.ReadLine();
                    if (decadeDigit == "quit") { myQuitter = "quit"; break; }
                    if (decadeDigit == "restart") { myRestarter = "restart"; break; }
                    Console.WriteLine();
                    Console.WriteLine("What is the balance of your age? (the balance digit of 78 is 8)");
                    balanceDigit = Console.ReadLine();
                    if (balanceDigit == "quit") { myQuitter = "quit"; break; }
                    if (balanceDigit == "restart") { myRestarter = "restart"; break; }
                    Console.WriteLine();

                    userAge = decadeDigit + balanceDigit;

                    //if (userAge == "quit") break;
                    //if (userAge == "restart") break;
                    ageArray = userAge.ToCharArray();
                    userAge = ageArray[0].ToString() + ageArray[1].ToString();
                    //Console.WriteLine("age is " + userAge);
                    //Console.WriteLine();
                }
                while (ageArray[0] != '0' && ageArray[0] != '1' && ageArray[0] != '2' && ageArray[0] != '3' && ageArray[0] != '4' && ageArray[0] != '5' && ageArray[0] != '6' && ageArray[0] != '7' && ageArray[0] != '8' && ageArray[0] != '9' ||
                       ageArray[1] != '0' && ageArray[1] != '1' && ageArray[1] != '2' && ageArray[1] != '3' && ageArray[1] != '4' && ageArray[1] != '5' && ageArray[1] != '6' && ageArray[1] != '7' && ageArray[1] != '8' && ageArray[1] != '9');
                //Console.WriteLine("userAge = " + userAge);              
                Console.WriteLine();

                if (myQuitter == "quit") { break; }
                if (myRestarter == "restart") { continue; }

                do
                {
                    Console.WriteLine("In what month were you born?");
                    Console.WriteLine("(e.g. January, not jan etc.)");
                    birthMonth = Console.ReadLine();
                    if (birthMonth == "quit") { myQuitter = "quit"; break; }
                    if (birthMonth == "restart") { myRestarter = "restart"; break; }
                    birthMonth = birthMonth.ToLower();
                    Console.WriteLine();
                }
                while (birthMonth != "january" && birthMonth != "february" && birthMonth != "march" && birthMonth != "april" && birthMonth != "may" && birthMonth != "june" && birthMonth != "july" && birthMonth != "august" && birthMonth != "september" && birthMonth != "october" && birthMonth != "november" && birthMonth != "december");

                if (myQuitter == "quit") { break; }
                if (myRestarter == "restart") { continue; }

                //Console.WriteLine("birthMonth = " + birthMonth);
                Console.WriteLine();




                do
                {
                    Console.WriteLine("What is your favorite ROYGBIV color?");
                    Console.WriteLine(("Please enter \"Help\" to get a list of the ROYGBIV colors"));
                    favoriteColor = Console.ReadLine().ToLower();
                    if (favoriteColor == "quit") { myQuitter = "quit"; break; }
                    if (favoriteColor == "restart") { myRestarter = "restart"; break; }

                    if (favoriteColor == "help")
                    {
                        Console.WriteLine();
                        Console.WriteLine("The ROYGBIV colors are red, orange, yellow, green, blue, indigo, and violet.");
                        Console.WriteLine("Please push a key to continue");
                        Console.ReadKey();
                        Console.WriteLine();
                    }

                    else favoriteColor = favoriteColor.ToLower();
                    {
                        switch (favoriteColor)
                        {
                            case "red": transportationMode = "helicopter"; break;
                            case "orange": transportationMode = "Winnebago"; break;
                            case "yellow": transportationMode = "Porsche"; break;
                            case "green": transportationMode = "Boeing 747"; break;
                            case "blue": transportationMode = "superyacht"; break;
                            case "indigo": transportationMode = "high speed train"; break;
                            case "violet": transportationMode = "Vespa"; break;
                            default: Console.WriteLine(); break;
                        }
                    }
                }
                while (favoriteColor != "red" && favoriteColor != "orange" && favoriteColor != "yellow" && favoriteColor != "green" && favoriteColor != "blue" && favoriteColor != "indigo" && favoriteColor != "violet");

                if (myQuitter == "quit") { break; }
                if (myRestarter == "restart") { continue; }

                //Console.WriteLine("favoriteColor = " + favoriteColor);
                Console.WriteLine();

                //do
                //{
                //    Console.WriteLine("How many siblings do you have?");
                //    numSiblings = Console.ReadLine();
                //    Console.WriteLine();
                //}
                //while (int.Parse(numSiblings) < 0);
                ////Console.WriteLine("numSiblings = " + numSiblings);
                //Console.WriteLine();


                do
                {
                    Console.WriteLine("How many siblings do you have?");
                    string blankSiblings = Console.ReadLine();//Blank request
                    if (blankSiblings == "quit") { myQuitter = "quit"; break; }
                    if (blankSiblings == "restart") { myRestarter = "restart"; break; }
                    Console.WriteLine();
                    Console.WriteLine("What is the tens digit of your number of siblings? (the tens digit of 03 is 0)");
                    tensDigit = Console.ReadLine();
                    if (tensDigit == "quit") { myQuitter = "quit"; break; }
                    if (tensDigit == "restart") { myRestarter = "restart"; break; }
                    //if (tensDigit == "quit") break;
                    //if (tensDigit == "restart") break;
                    Console.WriteLine();
                    Console.WriteLine("What is the balance of your number of siblings? (the balance digit of 03 is 3)");
                    singlesDigit = Console.ReadLine();
                    if (singlesDigit == "quit") { myQuitter = "quit"; break; }
                    if (singlesDigit == "restart") { myRestarter = "restart"; break; }
                    //if (singlesDigit == "quit") break;
                    //if (singlesDigit == "restart") break;
                    Console.WriteLine();

                    numSiblings = tensDigit + singlesDigit;


                    siblingsArray = numSiblings.ToCharArray();
                    numSiblings = siblingsArray[0].ToString() + siblingsArray[1].ToString();
                    //Console.WriteLine("numSiblings " + numSiblings);
                    Console.WriteLine();
                }
                while (siblingsArray[0] != '0' && siblingsArray[0] != '1' && siblingsArray[0] != '2' && siblingsArray[0] != '3' && siblingsArray[0] != '4' && siblingsArray[0] != '5' && siblingsArray[0] != '6' && siblingsArray[0] != '7' && siblingsArray[0] != '8' && siblingsArray[0] != '9' ||
                       siblingsArray[1] != '0' && siblingsArray[1] != '1' && siblingsArray[1] != '2' && siblingsArray[1] != '3' && siblingsArray[1] != '4' && siblingsArray[1] != '5' && siblingsArray[1] != '6' && siblingsArray[1] != '7' && siblingsArray[1] != '8' && siblingsArray[1] != '9');
                //Console.WriteLine("userAge = " + userAge);
                if (myQuitter == "quit") { break; }
                if (myRestarter == "restart") { continue; }

                Console.WriteLine();


                //-------------------------------------------------------------------------------


                if (int.Parse(userAge) % 2 != 0)
                {
                    retireYears = 21;
                }
                else
                {
                    retireYears = 20;
                }

                switch (int.Parse(numSiblings))
                {
                    case 0: homeLocation = "Siberia"; break;
                    case 1: homeLocation = "Tunisia"; break;
                    case 2: homeLocation = "Madagascar"; break;
                    case 3: homeLocation = "Zimbabwe"; break;
                    default: homeLocation = "Iceland"; break;
                }

                char[] monthCharArray = birthMonth.ToCharArray();

                //Console.WriteLine(firstName.IndexOf(monthCharArray[0]));
                //Console.WriteLine(firstName.IndexOf(monthCharArray[1]));
                //Console.WriteLine(firstName.IndexOf(monthCharArray[2]));

                //Console.WriteLine(lastName.IndexOf(monthCharArray[0]));
                //Console.WriteLine(lastName.IndexOf(monthCharArray[1]));
                //Console.WriteLine(lastName.IndexOf(monthCharArray[2]));

                if (firstName.ToLower().IndexOf(monthCharArray[0]) != -1 || lastName.ToLower().IndexOf(monthCharArray[0]) != -1) { bankAmount = "1 million"; }
                else if (firstName.ToLower().IndexOf(monthCharArray[1]) != -1 || lastName.ToLower().IndexOf(monthCharArray[1]) != -1) { bankAmount = "2 billion"; }
                else if (firstName.ToLower().IndexOf(monthCharArray[2]) != -1 || lastName.ToLower().IndexOf(monthCharArray[2]) != -1) { bankAmount = "3 trillion"; }
                else { bankAmount = "zero"; }

                Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears + " years with " + bankAmount + " dollars in the bank, ");
                Console.WriteLine("a vacation home in " + homeLocation + " and a " + transportationMode + ".");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                do
                {
                    Console.WriteLine("Try again?");
                    tryAgain = Console.ReadLine().ToLower();

                    switch (tryAgain)
                    {
                        case "yes":
                            tryAgainFallThrough = tryAgain;
                            //Console.WriteLine("tryAgain = " + tryAgain);
                            //Console.WriteLine("tryAgainFallThrough = " + tryAgainFallThrough);
                            Console.WriteLine();
                            break;

                        case "no":
                            tryAgainFallThrough = tryAgain;
                            //Console.WriteLine("tryAgain = " + tryAgain);
                            //Console.WriteLine("tryAgainFallThrough = " + tryAgainFallThrough);
                            Console.WriteLine();
                            break;

                        default:
                            tryAgainFallThrough = tryAgain;
                            //Console.WriteLine("tryAgain = " + tryAgain);
                            //Console.WriteLine("tryAgainFallThrough = " + tryAgainFallThrough);
                            Console.WriteLine();
                            Console.WriteLine("Please enter \"yes\" or \"no\".");
                            Console.WriteLine();
                            break;
                    }

                } while (tryAgainFallThrough != "yes" && tryAgainFallThrough != "no");

            }
            while (tryAgain != "no");
            Console.WriteLine();
            Console.WriteLine("Nobody likes a quitter");
            Console.WriteLine();

        }
    }
}
