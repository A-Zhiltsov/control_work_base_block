Console.WriteLine("Введите длину исходного массива");
int L = int.Parse(Console.ReadLine());
string[] array = new string[L];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Ввведите элемент массива номер " + (i + 1));
    array[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив - "+string.Join(",", array));

string count = "";
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
     {
        count += Convert.ToString(i);
        count += ",";
     }
}
count = count.Remove(count.Length - 1);

string[] indexes = count.Split(",");

string[] new_array = new string[indexes.Length];
for (int i = 0;i < new_array.Length; i++)
{
    new_array[i] = array[Convert.ToInt32(indexes[i])];
}

Console.WriteLine("Итоговый массив - "+string.Join(",", new_array));