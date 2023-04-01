int lengthWord = 3;

string[] startArray = { "Hello", "See", "Work", "Smile", "Ufc" , ":=)"};
string[] tempArray = new string[startArray.Length];
int count = 0;

//Добавляем во временный массив значения, нужного размера.
//Считаем кол-во слов.

for (int i = 0, y = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= lengthWord)
    {
        tempArray[y] = startArray[i];
        y++;
        count++;
    }
}

string[] finalArray = new string[count + 1];

//В финальный массив добавляем значения
for (int i = 0; i <= count; i++)
{
    finalArray[i] = tempArray[i];
}

//Выводим финальный массив
for (int i = 0; i < finalArray.Length - 1; i++)
{
    Console.WriteLine($"{i} - > {finalArray[i]};");
}