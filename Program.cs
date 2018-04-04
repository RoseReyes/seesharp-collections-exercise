using System;
using System.Collections.Generic; 

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
                //Create an array to hold integer values 0 through 9
                int [] numArray = {0,1,2,3,4,5,6,7,8,9};
                Console.WriteLine(numArray.Length);

                //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
                string [] namesArray = {"Tim", "Martin", "Nikki", "Sara"};

                //Create an array of length 10 that alternates between true and false values, starting with true
                string [] booleanArray = new string[10] {"True", "False","True", "False","True", "False","True", "False","True", "False"};
                foreach( string word in booleanArray)
                {
                    Console.WriteLine(word);
                }

            //Multiplication Table
           Console.WriteLine("Multiplication Table");
            int[,] numArray = new int[10,10]; //initialize your array = 10 rows and 10 cols
    
            for (int x = 1; x <= 10; x++) // loop for rows
            {
                Console.WriteLine("\n"); //next line

                for (int y = 1; y <= 10; y++) // loop for cols
                    {
                        numArray[x-1, y-1] = x * y;
                         Console.Write(numArray[x-1, y-1] + " ");
                    }
            }
            
            //List of Flavors
                // // //Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
                List<string> IceCream = new List<string>();
                IceCream.Add("Chocolate");
                IceCream.Add("Chocolate and Mint");
                IceCream.Add("Tiramisu");
                IceCream.Add("Mango");
               Console.WriteLine(IceCream[0]);
               Console.WriteLine(IceCream[2]);
               IceCream.Remove(IceCream[2]);
               Console.WriteLine("We have {0} flavors of ice cream.", IceCream.Count);

            //User Info Dictionary
            Dictionary<string,string> namesFlavors = new Dictionary<string,string>();
            Random flavors = new Random(); //create random flavors from the list
            string shuffleFlavors = IceCream[flavors.Next(0,3)];

            //access values from the names array
            foreach(var names in namesArray) 
            {
                //Add the names and random flavors in the dictionary
                namesFlavors.Add(names, shuffleFlavors);         
            }
            //Print the names and random flavors - var replaces the explicit typing of the data type or type-INFERENCE
            foreach(var combo in namesFlavors)
            {
                Console.WriteLine(combo.Key + "-" + combo.Value);
            }
        }
    }
}
