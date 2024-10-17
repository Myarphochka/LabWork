using ConsoleApp1;

Console.WriteLine("Работа с методами");

int a = -5;
Functions.GetAbsolute(ref a); // 5

Functions.Sum(2, 7, out a);

int result1 = Functions.GetSum(); // 0
int result2 = Functions.GetSum(2, 3, 15); // 20
int[] ints = [1, 2, 3];
int result3 = Functions.GetSum(ints); // 6

int x = Functions.Sum(2, 3);                    // 5
Console.WriteLine(Functions.Sum(2.5, 3.7));     // 6.2


Console.WriteLine("Работа с классами");

//создание объекта
Person person = new() { Money = 12345, age = 15, Name = "---" };

person.Print();
person = new("Петрова И.С.", 20);
person.Print();

person.age = 10;
person.Name = "Иванов П.С.";

Console.WriteLine("Совершеннолетие через: ");
Console.WriteLine(Person.MajorityAge - person.age);

//вызов метода
person.Print();

Console.WriteLine($"поле1: {person[1]}");
Console.WriteLine($"поле2: {person[2]}");
Console.WriteLine($"поле3: {person[3]}");