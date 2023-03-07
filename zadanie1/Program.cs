int input(string msg)
{
    System.Console.WriteLine(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] myArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = input($"Введите {i + 1}-ый элемент ");
    }
    return array;
}

void Printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"[{i}] = [{array[i]}]");
    }
}
int count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int lenght = input("Введите количество элементов > ");
int[] array;
array = myArray(lenght);
Printarray(array);
System.Console.WriteLine($"Количество чисел больше 0 равно {count(array)}");
