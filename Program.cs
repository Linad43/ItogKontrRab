
Console.WriteLine("Итоговая контрольная работа");

string[] begin = {"Hello", "2", "world", ":-)"};
returnArr(begin, 3);


void returnArr(string[] begin, int sizeWord)
{
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
    for (int i = 0; i < indexEndArr; i++)
    {
        if (i==indexEndArr-1)
        {
            Console.Write(result[i]);
        }
        else
        {
            Console.Write(result[i] + ", ");
        }
        
    }
}