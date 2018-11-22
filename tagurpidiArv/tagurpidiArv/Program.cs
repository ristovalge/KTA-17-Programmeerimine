using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {

        List<string> list = new List<string>();


        Console.WriteLine("Sisesta nr.");
        string input = "";
        while (input != "0")
        {
            input = Console.ReadLine();
            list.Add(input);
        }


        Console.WriteLine("Kuvame sisestatu tagurpidi");
        string[] array = list.ToArray();
        //for (int i = 0; i < array.Length; i++) 

        list.Remove("0");




        list.Reverse();
        foreach (string stringValues in list)
        {
            Console.WriteLine(stringValues);      
                                                   
        }

        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();


    }
      
}