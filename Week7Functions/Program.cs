﻿
//Console.WriteLine("Hello, World!"); Tuled v6i l2hed

using System.Threading.Channels;

Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();   
}
else
{
    PrintGoodBye();     
}

static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}
  
