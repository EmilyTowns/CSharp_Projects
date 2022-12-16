using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
         {
            //Console.WriteLine("How old are you?");   //Writes a question to the console
            //int age = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to a variable
            //bool  adult = age == 18;   //Assigns the boolean adult to be true if age is equal to 18

            //while(!adult)   //Starts while loop, while adult is false
            //{
            //    switch(age)   //Starts a switch assessing the integer age
            //    {
            //        case 16:   //Gives a case, for if age is equal to 16
            //            Console.WriteLine("You are close, but try adding another year.");   //Writes a line to the console saying they should try entering a differnt age
            //            Console.WriteLine("How old are you?");   //Writes a line to the console requesting the user try again
            //            age = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
            //            break;   //States the case is over, and the program should move to the next one
            //        case 17:   //Gives a case, for if age is equal to 17
            //            Console.WriteLine("You are almost there, but try adding another year.");   //Writes a line to the console saying they should try entering a differnt age
            //            Console.WriteLine("How old are you?");   //Writes a line to the console requesting the user try again
            //            age = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
            //            break;   //States the case is over, and the program should move to the next one
            //        case 18:   //Gives a case, for if age is equal to 18
            //            Console.WriteLine("You are a new adult. Congrats!");   //Writes a line to congratulate the user on getting the correct age
            //            adult = true;   //Changes the boolean to true, which ends the loop
            //            break;   //States the case is over
            //        case 19:   //Gives a case, for if age is equal to 19
            //            Console.WriteLine("You are too high, but try taking away a year.");   //Writes a line to the console saying they should try entering a differnt age
            //            Console.WriteLine("How old are you?");   //Writes a line to the console requesting the user try again
            //            age = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
            //            break;   //States the case is over, and the program should move to the next one
            //        default:   //Assigns the default if none of the above cases are met
            //            Console.WriteLine("Try a different age.");   //Writes a line to the console saying they should try entering a differnt age
            //            Console.WriteLine("How old are you?");   //Writes a line to the console requesting the user try again
            //            age = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
            //            break;   //States the case is over, and the program should move to the next one
            //    }
            //}
            //Console.Read();   //Allows the console to stay open

            Console.WriteLine("Pick a number between 1 and 100:");   //Writes a question to the console   
            int number = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to a variable
            bool isGuessed = number == 51;   //Assigns the boolean isGuessed to be true if number is equal to 51

            do   //Starts the do part of the do while statement
            {
                switch (number)   //Starts a switch assessing the integer number
                {
                    case 10:   //Gives a case, for if number is equal to 10
                        Console.WriteLine("Too low. Try again!");   //Writes a line to the console saying they should try entering a differnt number
                        Console.WriteLine("Pick a number between 1 and 100:");   //Writes a line to the console requesting the user try again
                        number = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
                        break;   //States the case is over, and the program should move to the next one
                    case 70:   //Gives a case, for if number is equal to 70
                        Console.WriteLine("Too high. Try again!");   //Writes a line to the console saying they should try entering a differnt number
                        Console.WriteLine("Pick a number between 1 and 100:");   //Writes a line to the console requesting the user try again
                        number = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
                        break;   //States the case is over, and the program should move to the next one
                    case 50:   //Gives a case, for if number is equal to 50
                        Console.WriteLine("You are so close! Try again.");    //Writes a line to the console saying they should try entering a differnt number
                        Console.WriteLine("Pick a number between 1 and 100:");   //Writes a line to the console requesting the user try again
                        number = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
                        break;   //States the case is over, and the program should move to the next one
                    case 51:   //Gives a case, for if number is equal to 51
                        Console.WriteLine("You guessed the number correctly. It is 51!");   //States the user got the number correct
                        isGuessed = true;   //Changes the boolean isGuessed to true, ending the loop
                        break;   //States the case is over
                    default:   //Assigns the default if none of the above cases are met
                        Console.WriteLine("That's not the right number, try again!");   //Writes a line to the console saying they should try entering a differnt number
                        Console.WriteLine("Pick a number between 1 and 100:");   //Writes a line to the console requesting the user try again
                        number = Convert.ToInt32(Console.ReadLine());   //Converts user input to an integer and assigns it to variable
                        break;   //States the case is over, and the program should move to the next one
                }
            }

            while (!isGuessed);   //States that the loop should continue to run while isGuessed is false
              
            Console.Read();   //Allows the console to stay open
        }
    }
}
