// Task12: Удалить вторую цифру трёхзначного числа

Random rnd = new Random();
int number = rnd.Next(100, 1000);

string newNumber = Convert.ToString(number);
newNumber = newNumber.Remove(1, 1);

Console.WriteLine("Начальное число " + number);
Console.WriteLine("Конечное число " + newNumber);