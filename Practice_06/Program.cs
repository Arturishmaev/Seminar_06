/*int[,] xx =  { { 1, 2, 3, 4, 5} ,
               { 0, 9, 8, 7, 6} };

for (int i = 0; i < xx.GetLength(0); i++)
{
    for (int j = 0; j < xx.GetLength(1); j++)
    {
System.Console.Write($"{xx[i,j]}");
    }
    System.Console.WriteLine();
}
//Задача 39: Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
//[6, 7, 3, 6] -> [6, 3, 7, 6]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($" [{array[i]}] ");
    }

}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
void ReverseArray(int[] array)
{
for (int i = array.Length - 1; i >= 0; i--)
{

    System.Console.Write($" [{array[i]}] ");
}
}



//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.WriteLine("Введите размеры сторон треугольника :");
System.Console.WriteLine();
System.Console.WriteLine("Введите размеры первой стороны : \t");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите размеры второй стороны : \t");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите размеры третьей стороны : \t");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && c + a > b)
{
System.Console.WriteLine("Такой треугольник может существовать");
}
else
{
    System.Console.WriteLine("Треугольник с такими параметрами не существует");
}*/


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
//45 -> 101101    1. Делим десятичное число на 2 и записываем остаток от деления.
//3 -> 11         2. Результат деления вновь делим на 2 и опять записываем остаток.        
//                3. Повторяем операцию до тех пор пока результат деления не будет равен нулю.
//                4. Запишем полученные остатки в обратном порядке и получим искомое число.

System.Console.Write("Введите десятичное число для перевода в двоичное: ");
int x = Convert.ToInt32(Console.ReadLine());
string y = string.Empty;

while (x > 0)
{
    y = Convert.ToString(x % 2) + y;
    x /= 2;
}
System.Console.Write($"\tВаше двоичное число:\t{y}");




//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1 
//Если N = 7 -> 0 1 1 2 3 5 8

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования