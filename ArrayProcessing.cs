/*
Задача: 
Контрольная работа по итогам блока
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] baseArray = {"Hello", "2", "world", ":-)"};
string[] newStrArr = new string[0];
string tmp = string.Empty;

for (int i = 0; i < baseArray.Length; i++)
{
    tmp = baseArray[i];
    if (tmp.Length <= 3)
    {
        Array.Resize(ref newStrArr, newStrArr.Length + 1);
        newStrArr[i] = tmp;
    }
}

if (newStrArr.Length > 0)
{
    for (int i = 0; i < newStrArr.Length; i++) Console.WriteLine(newStrArr[i]);
}