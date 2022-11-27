/*
Задача 2: 
*/

int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNum)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNum;
    min = firstNum;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);




/*
Задача 4: 
*/

int max = 0;

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNum > max)
{
    max = firstNumber;
}
if(secondNum > max)
{
    max = secondNumber;
}
if(thirdNum > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);





/*
Задача 6:
*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = num % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}




/*
Задача 8: 
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int evenNum = 2;

if(num > 1)
{
    while(evenNum <= num)
    {
        Console.Write(evenNum+ " ");
        evenNum = evenNum + 2;
    }
}
