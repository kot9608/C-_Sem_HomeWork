//Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int ost = (number1%2);
if (ost==0) {
  Console.WriteLine($"Число {number1} чётное");
}
else if (ost==1) {
  Console.WriteLine($"Число {number1} нечётное");
}