﻿
int number;
Console.WriteLine("How much money do you want to bet");
string input = Console.ReadLine();
number = Convert.ToInt32(input);


int number2;
Console.WriteLine("Please pick a number between 1-30");
string input2 = Console.ReadLine();
number2 = Convert.ToInt32(input2);


Random rand = new Random();
Console.WriteLine(rand.Next());

int number3;
number3 = rand.Next(1, 30);
Console.WriteLine(number3);


if(number3 == number2) {
    Console.WriteLine("yay you won!!!!");
} else {
    Console.WriteLine("better luck next time :(  T_T");
}



