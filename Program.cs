using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndProjectDueJan17th
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please tell us, what is your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please tell us, what is your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Greetings " + firstName + " " + lastName + ". I will tell your fortune!");

             //why is it + firstName + "" +lastName? Why do I need the "" btwn the 2 +signs? that took a while to understand and need to know why for next time
            //instead of just ("Hello" firstName + lastName) which seemed intuitive and logical but so did not work. WHats the diff/why?
            //mmmkay now we have to greet user...so now remove hello and follow the guide.
            
            string userNameInput = Console.ReadLine();
            //Part 2

            /*Here we're asked to create a method that will determine when an individual will retire. It will have an int as the parameter. 
            and we are asked to return it as an int.
            If the age of the user is odd, they will retire in certain number of years; this time frame will differ if the user's age is an even number. 


            if user has 0 siblings,  user has vacation home in Versaille
            
            else 
            user has 1 siblings,  user has vacation home in Bermuda

            else 
            user has 2 siblings,  user has vacation home in the Cebu City

            else
            user has 3 siblings,  user has vacation home in Mzuzu

            else
            user types an interger other than 0, 1, 2, or 3, they will have string that will be printed on the console 
            stating that they will receive a bad vacation home.

            this method will take int's in order to take the user's age, which is a number, but will return a string because we need to print text in this case for us to be able to print 
            words/characters that are decipherable to the user when it appears on the console.

            Now we're about to create a method that'll determine the user's future in regards to their specific modes of transportation 
            Depending on what their favorite color is, they will have a certain mode of transportation.

            if usersFavColor is red they'll be driving a maserati

            else
            if usersFavColor is orange they'll be driving a bus

            else
            if usersFavColor is yellow they'll be aboard a steamship

            else 
            if usersFavColor is green they'll be riding a moped

            else
            if usersFavColor is blue they'll be driving a unicycle

            else
            if usersFavColor is indigo they'll be walking

            else
            if usersFavColor is violet they'll be driving a heloicopter

            else
            user has not entered a roygbiv color they'll be getting around via a squeaky shopping cart
             
             */


        }
    }

}

