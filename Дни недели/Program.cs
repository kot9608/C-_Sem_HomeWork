//Написать программу, которая на вход принимает число и выдает его квадрат
Console.Clear();
Console.Write("Введите номер дня: ");
int number1 = int.Parse(Console.ReadLine());
if (number1==1) {
  Console.WriteLine("Понедельник");
}
else if (number1==2) {
  Console.WriteLine("Вт");
}
else if (number1==3) {
  Console.WriteLine("Ср");
}
else if (number1==4) {
  Console.WriteLine("Чт");
}
else if (number1==5) {
  Console.WriteLine("Пт");
}
else if (number1==6) {
  Console.WriteLine("Сб");
}
else if (number1==7) {
  Console.WriteLine("Вс");
}
else  {
  Console.WriteLine("Вс");
}
