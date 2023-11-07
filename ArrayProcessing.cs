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
string[] baseArray = {"Hello", "2", "world", ":-)"};        // Проверяемый масив
// string[] baseArray = {"1234", "1567", "-2", "computer science"};        // Проверяемый масив
// string[] baseArray = {"Russia", "Denmark", "Kazan"};        // Проверяемый масив
string[] newStrArr = new string[0];                         // Пустой массив для наполнения
string tmp = string.Empty;                                  // Пустая строка  
int k = 0;                                                  // Счетчик выполнений условия

for (int i = 0; i < baseArray.Length; i++)
{
    tmp = baseArray[i];
    if (tmp.Length <= 3)
    {
        Array.Resize(ref newStrArr, newStrArr.Length + 1);
        newStrArr[k] = tmp;
        k++;
    }
}

if (newStrArr.Length > 0)
{
    for (int i = 0; i < newStrArr.Length; i++) Console.Write($"\"{newStrArr[i]}\" ");
}
else Console.WriteLine("В исходном массиве нет строк длинной = 3 или менее символам");