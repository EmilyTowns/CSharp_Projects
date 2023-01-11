using System;
using System.Collections.Generic;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        ////Assignment Part 1
        //Console.WriteLine("Did you know, if you add \"ish\" to the end of words that usually mean positive things, they will become negative?");   //Writes to console
        //Console.WriteLine("Let's try. Write the three letters \"ish\" below to add them to some words:");   //Writes to console asking for user input
        //string userInput = Console.ReadLine();   //Assigns user input to string variable

        //string[] stringArray = { "Fresh", "Young", "Sweet", "Kind", "Great" };   //Creates a string array

        //Console.WriteLine("Okay, here's the original words: ");   //Writes to console

        //for (int i = 0; i < stringArray.Length; i++)   //A loop that lists each word from the array, one at a time
        //{
        //    Console.WriteLine(stringArray[i]);
        //}

        //for (int i = 0;i < stringArray.Length; i++)   //A loop that appends the user input to the end of each string in the array
        //{
        //    stringArray[i] += userInput;   
        //}

        //Console.WriteLine("And here's the words with the letters added: ");   //A loop that lists each word from the appended array, one at a time

        //for (int i = 0;i < stringArray.Length; i++)
        //{
        //    Console.WriteLine(stringArray[i]);
        //}
        //Console.ReadLine();   //Keeps the console open


        ////Assignment Part 2
        //Console.WriteLine("Here is an example of an infinite loop that has been fixed: ");

        ////for (int j = 0; j < 11; j--)   //This loop will never end because it will never reach the value of 10 with 1 being taken away each time the loop executes
        //for (int j = 0; j < 11; j++)   //This loop will stop executing at 10 because we are adding one each time the loop executes
        //{
        //    Console.WriteLine(j);
        //}
        //Console.ReadLine();


        ////Assignment Part 3
        //Console.WriteLine("Here is an example of a loop using the less than operator to determine its exit point: ");

        //for (int k = 10; k < 21; k++)   //This loop starts at 10 and executes as long as the value of k is less than 21, increasing by increments of 1   
        //{
        //    Console.WriteLine(k);
        //}

        //Console.WriteLine("Here is an example of a loop using the less than or equal to operator to determine its exit point: ");

        //for (int l = 20; l <= 30; l++)   //This loop starts at 20 and executes as long as the value of l is less than or equal to 30, increasing by increments of 1
        //{
        //    Console.WriteLine(l);
        //}
        //Console.ReadLine();   //Keeps console open


        ////Assignment Part 4
        //List<string> stringList = new List<string>()   //Creates a new string list with colours
        //{
        //    "blue", "yellow", "red", "orange", "purple", "green"
        //};

        //Console.WriteLine("Please enter the name of your favourite colour (don't use any capital letters): ");   //Writes to console asking for user input
        //string colourInput = Console.ReadLine();   //Stores user input as a string variable

        //foreach (string colour in stringList)   //Starts foreach loop to go through each item in the list and compare it to the user input
        //{
        //    if (colour == colourInput)   //If the item is the same as the user input, indicates the index at which that colour is located on the list
        //    {
        //        Console.WriteLine("That colour is at index " + stringList.IndexOf(colour) + " on the list.");
        //        break;   //Exits the loop once the colour input has been identified on the list
        //    }

        //    else (colour != colourInput)   //If the user input does not match the item on the list, indicates that the colour is not on the list
        //    {
        //        Console.WriteLine("That colour is not on the list.");
        //    }
        //}
        //Console.ReadLine();   //Keeps the console open


        ////Assignment Part 5
        //List<string> stringList2 = new List<string>()   //Starts a new string list with car manufacturer names
        //{
        //    "Ford", "Chevrolet", "Nissan", "Dodge", "Ford", "Mitsubishi", "Nissan"
        //};

        //Console.WriteLine("Please enter the name of your favourite vehicle manufacturer (make sure to include a capital letter): ");   //Writes to the console promtping for user input
        //string makeInput = Console.ReadLine();   //Stores user input as string variable

        //for (int m = 0; m <= stringList2.Count; m++)   //Starts a for loop where m starts at 0, loop runs while m is less than or equal to the length of the list, adding one to m each loop  
        //{
        //    if (stringList2[m] == makeInput)   //If the value at index is equal to the user input, write the index of that item to the console
        //    {
        //        Console.WriteLine("That vehicle make is at index " + stringList2.IndexOf(stringList2[m], m) + " on the list.");   //Indicates that the index count should start at m so that the index number is not listed twice
        //    }

        //    else   //If the values are not equal, states it is not on the list
        //    {
        //        Console.WriteLine("That make is not on the list.");
        //    }
        //}
        //Console.ReadLine();   //Keeps the console open


        //Assignment Part 6
        List<string> stringList3 = new List<string>()   //Starts a new string list with car manufacturer names
        {
            "Apartment", "Condo", "Semi-detached", "Single-unit", "Row-house", "Condo", "Single-unit"
        };

        foreach (string home in stringList3)   //Starts a foreach loop, going through each item in the list  
        {
            if (home.Equals(home[]))
            {
                Console.WriteLine(home + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(home + " - this item is unique");
            }
            
            
        }
        Console.ReadLine();   //Keeps the console open
    }
}

