Console.Clear();
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = (number1*(-1));
while (number2 <= number1)
{
    Console.WriteLine(number2);
    number2=number2+1;
}