﻿
using System.Xml.Schema;

int number;
Console.WriteLine("How much money do you want to bet");
string input = Console.ReadLine();
number = Convert.ToInt32(input);


int number2;
string text = "Red";
string text2 = "Black";
string text3 = "Green";
Console.WriteLine("Please pick a number between 1-30 or a color between Red, Black or Green");
string input2 = Console.ReadLine();


//number2 = Convert.ToInt32(input2);


Random rand = new Random();

int number3;
number3 = rand.Next(1, 30);
Console.WriteLine(number3);

bool won = false;

if (input2 == "Red")
{
   
}
else if (input2 == "Black")
{

}
else if (input2 == "Green") {
   
}else
{
    number2 = Convert.ToInt32(input2);
    if (number3 == number2)
    {
        won = true;
    }
}




if (won)
{
    Console.WriteLine("yay you won!!!! ^u^");
}
else
{
    Console.WriteLine("better luck next time :(  T_T");
}


