//Написать программу, которая на вход принимает число и выдает его квадрат
Console.Clear();
Console.Write("Введите 1-ое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1==number2*number2) {
  Console.WriteLine("Да");
}
else {
  Console.WriteLine("Нет");
}