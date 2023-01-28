//Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите 1-ое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1==number2) {
  Console.WriteLine($"Число {number1} равно числу {number2}");
}
else if (number1>number2) {
  Console.WriteLine($"Большее число {number1}, меньшее число {number2}");
}
else if (number1<number2)
  Console.WriteLine($"Большее число {number2}, меньшее число {number1}");