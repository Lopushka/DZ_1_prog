﻿//вывод массива
static void OutputArrayToConsole(object[] newArray)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < newArray.Length; i++)
    {

        Console.Write($"({newArray[i]}) ");
    }
}


// размер массива
Console.Write("\nВведите количество элиментов массива: ");
uint quantity = Convert.ToUInt32(Console.ReadLine());
if (quantity > 0)
{
    int cnt = 0;
    object[] myArray = new object[quantity];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВведите элиментов массива под индексом {i}:\t");
        myArray[i] = Console.ReadLine();

    }
    OutputArrayToConsole(myArray);
    Console.WriteLine();

    for (var i = 0; i < myArray.Length; i++)
    {
        var mark = myArray[i];
        char[] Array = mark.ToString().ToCharArray();
        if (Array.Length <= 3)
        {
            cnt++;
        }
    }
    if (cnt >= 1)
    {
        object[] newArray = new object[cnt];
        var j = 0;
        for (var i = 0; i < myArray.Length; i++)
        {
            var mark = myArray[i];
            char[] Array = mark.ToString().ToCharArray();
            if (Array.Length <= 3)
            {
                newArray[j] = myArray[i];
                j++;
            }
        }
        Console.WriteLine("Массив из строк не более 3-х символов");
        OutputArrayToConsole(newArray);
    }
    else
    {
        Console.WriteLine("Все строки больше 3-x символов.");
    }

}
else
{
    Console.Write("Размер массива должен быть больше 0.");
}