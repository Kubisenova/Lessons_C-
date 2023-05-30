﻿

// Console.Clear();


// Вид 1 // Ничего не возвращают и ничего не принимают 
// void Method1()
// {
//     Console.WriteLine("Автор ... ");

// }
//  Method1();  // Как вызываются эти методы (обязательно скобки)


// // Вид 2 // Это метод ничего не возвращает, но в то же 
// время принимает какие-то аргументы

// // void Method2(string msg)
// // {
// //     Console.WriteLine(msg);
// // }
// // // Method2(msg:"Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(msg: "Текст", count: 4); //Для того чтобы вызвать подобный метод 
// // нам необходимо указать его индентификатор 

// Method21(count: 4, msg: "новый текст");
//  // Инкреме́нт - увеличение на единичку. 
// Декримент - уменьшение на единичку.


// Вид 3 // Методы что-то возвращают, но ничего не принимают 

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// // Вид 4 Это методы, которые что-то принимают и что-то возвращают 

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



// // for цикл 
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// \\ Цикл в цикле 
// Console.Clear();

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 5; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine("------------");
// }







//===== Работа с текстом 
//  Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” заменить маленькими “с”.

// // Ясна ли задача?

Console.Clear();

// string text = "- Я думаю, — сказал князь, улыбаясь, — что,"
//         + "ежели бы вас послали вместо нашего милого Винценгероде,"
//         + "вы бы взяли приступом согласие прусского короля."
//         + "Вы так красноречивы. Вы дадите мне чаю?";

// // // string s = "qwerty"
// // //             123
// // // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace (text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace (text, 'к', 'К');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);