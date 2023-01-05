using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //String Array
        string[] stringArray = { "Red", "Yellow", "Blue", "Orange", "Purple", "Green" };   //Creates an array of strings that is 6 long

        Console.WriteLine("Choose a number between 0 and 5");   //Requests user input
        int colourIndex = Convert.ToInt32(Console.ReadLine());   //Converts to int and assigns user input to colourIndex
        bool correctIndex = false;   //Sets boolean value of correctIndex to false to start do while loop

        do   //Starts do while loop
        {
            if (colourIndex < 0 || colourIndex > 5)   //If user input is less than 0 or more than 5, write a line to prompt entry of number between 0 and 5
            {
                Console.WriteLine("Please pick a whole number between 0 and 5");   
                colourIndex = Convert.ToInt32(Console.ReadLine());   //Writes new input value to colourIndex
            }

            else   //If value is between 0 and 5, write to console the colour value at that index
            {
                Console.WriteLine("Your colour is: " + stringArray[colourIndex]);
                correctIndex = true;   //Set correctIndex to true, exiting loop
            }
        }
        while (!correctIndex);   //Sets loop to continue while correctIndex is false


        //Integer Array
        int[] intArray = { 50, 100, 40, 22, 63, 41 };   //Creates an integer array 5 in length

        Console.WriteLine("Choose another number between 0 and 5");   //Writes to console prompting user input
        int numberIndex = Convert.ToInt32(Console.ReadLine());   //Converts user input to integer and assigns to numberIndex
        bool correctIndex1 = false;   //Sets boolean correctIndex1 to false to start do while loop

        do   //Starts do while loop
        {
            if (numberIndex < 0 || numberIndex > 5)   //If user input number is less than 0 or more than 5, write a new line to console promting new user input
            {
                Console.WriteLine("Please pick a whole number between 0 and 5");
                numberIndex = Convert.ToInt32(Console.ReadLine());   //Writes new user input to numberIndex
            }

            else   //If user input is between 0 and 5, display value at that index
            {
                Console.WriteLine("The number in the array at that index is: " + intArray[numberIndex]);
                correctIndex1 = true;   //Set correctIndex1 to true, exiting loop
            }
        }
        while (!correctIndex1);   //Sets loop to continue while correctIndex1 is false


        //List of Strings
        List<string> stringList = new List<string>();   //Instantiaties a list of strings
        stringList.Add("Goodbye");   //Adds values to list
        stringList.Add("See Ya!");
        stringList.Add("Bye");
        stringList.Add("Bye Bye!");
        stringList.Add("Adios");


        Console.WriteLine("Choose one last number - this time between 0 and 4");   //Writes to console to prompt user input
        int listIndex = Convert.ToInt32(Console.ReadLine());   //Converts user input to integer and assigns to listIndex
        bool correctIndex2 = false;   //Sets boolean correctIndex2 to false to start do while loop

        do   //Starts do while loop
        {
            if (listIndex < 0 || listIndex > 4)   //If user input is less than 0 or more than 4, prompts user to re-enter a value
            {
                Console.WriteLine("Please pick a whole number between 0 and 4");
                listIndex = Convert.ToInt32(Console.ReadLine());   //Assigns new user input to listIndex
            }

            else   //If user input is between 0 and 4, write string value at that index to console
            {
                Console.WriteLine(stringList[listIndex]);
                Console.ReadLine();   //Keeps console open
                correctIndex2 = true;   //Sets correctIndex2 to true, extiing loop
            }
        }
        while (!correctIndex2);   //Sets loop to continue while correctIndex2 is false

    }
}

