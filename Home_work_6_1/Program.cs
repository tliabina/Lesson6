//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.WriteLine("Сколько чисел хотите ввести? ");
int n = Convert.ToInt32(Console.ReadLine());


int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(string.Join(",", array));
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}

Console.WriteLine("Спасибо, вводить числа больше не нужно.");
Console.WriteLine("Число введенных чисел больше 0: " + count);





