
using System.Xml.Schema;

int number;
Console.WriteLine("How much money do you want to bet");
string input = Console.ReadLine();
number = Convert.ToInt32(input);


int number2;
string text = "Red";
string text2 = "Black";
string text3 = "Green";
Console.WriteLine("Please pick a number between 0-30 or a color between Red, Black or Green");
string input2 = Console.ReadLine();


//number2 = Convert.ToInt32(input2);


Random rand = new Random();

int number3;
number3 = rand.Next(0, 30);
Console.WriteLine(number3);

bool won = false;

if (input2 == "Red")
{
    if(number3 % 2 == 1)
    {
        won = true;
    }
}
else if (input2 == "Black")
{
    if(number3 % 0 ==1)
    {
        won = true;
    }
}
else if (input2 == "Green") {
   if(number3 == 0)
    {
        won = true;
    }
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
    Console.WriteLine("yay you won 20$!!!! ^u^");
}
else
{
    Console.WriteLine("better luck next time :(  T_T");
}


