/* Написать программу, которая из имеющегося массива строк сформирует массив из строк, 
длина которых меньше либо ровна 3 символа. Первоночальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма.*/
Console.WriteLine("Введите количество строк");

bool isParsed = int.TryParse(Console.ReadLine(), out int strCount);

if (!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
Console.WriteLine("Введите данные");
string[] ArrayWithСondition = InputArray(strCount);


string[] InputArray(int strCount)
{
    string[] array = new string[strCount];
    for (int i = 0; i < strCount; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}