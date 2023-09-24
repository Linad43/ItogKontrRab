
Console.WriteLine("Итоговая контрольная работа");

start();

void start()
{
    Console.WriteLine("Ввод массива");
    Console.WriteLine("  1. с клавиатуры");
    Console.WriteLine("  2. стандартный из задания");
    Console.WriteLine("0. Выход");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
        writeArr();
        break;
        case 2:
        standartArr();
        break;
    }
}
void writeArr()
{
    Console.WriteLine("Введите массив разделяя каждый элемент пробелом");
    string text;
    text = Console.ReadLine();
    string[] words = text.Split(' ');
    returnArr(words, 3);
}
void standartArr()
{
    string[] begin = {"Hello", "2", "world", ":-)"};
    returnArr(begin, 3);
    begin = new string[] {"1234", "1567", "-2", "computer", "science"};
    returnArr(begin, 3);
    begin = new string[] {"Russia", "Denmark", "Kazan"};
    returnArr(begin, 3);
}



void returnArr(string[] begin, int sizeWord)
{
    Console.Write("[");
    Console.Write(string.Join(", ", begin));
    Console.Write("] -> ");
    int indexBeginArr = 0;
    int indexEndArr = 0;
    string[] result = new string[indexEndArr];
    string[] buf = new string[indexEndArr];
    while (indexBeginArr<begin.Length)
    {
        if (begin[indexBeginArr].Length<=sizeWord)
        {
            indexEndArr++;
            buf = new string[indexEndArr];
            for (int i = 0; i<indexEndArr-1; i++)
            {
                buf[i] = result[i];
            }
            buf[indexEndArr - 1] = begin[indexBeginArr];
            result = buf;
        }
        indexBeginArr++;
    }
    /*for (int i = 0; i < indexEndArr; i++)
    {
        if (i==indexEndArr-1)
        {
            Console.Write(result[i]);
        }
        else
        {
            Console.Write(result[i] + ", ");
        }
        
    }*/
    Console.Write("[");
    Console.Write(string.Join(", ", result));
    Console.WriteLine("]");
}