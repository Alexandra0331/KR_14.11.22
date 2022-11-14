// Напишите программу, которая из имеющегося массива строкмформирует массив из строк,
// длина которых меньше либо равна 3 символа.
// (Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгаритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами).
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "2", "computer sciense"] -> ["2"]
// ["Russia", "Denmark", "Kazan"] -> []


string [] m;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
m = stroka.Split(' ');
var result = new string[m .Length];
 var i = 0;
 foreach (var value in m)
     {
         if (value.Length <= 3)
         {
             result[i] = value;
             i++;
        }
     }
Console.WriteLine(string.Join(Environment.NewLine, result, 0, i)); 
