// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = new Random().Next(10, 1000);
Console.WriteLine(number);
string anyNumber = Convert.ToString(number);
if (anyNumber.Length > 2)
{
  Console.WriteLine("третья цифра:  " + anyNumber[2]);
}
else 
  Console.WriteLine("третьей цифры нет");