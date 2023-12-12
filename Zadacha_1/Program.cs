// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из
//  символов этого массива.

// Задаем двумерный массив символов
char[,] array = new char[3, 4] { { 'a', 'b', 'c', 'd' }, { 'e', 'f', 'g', 'h' }, { 'i', 'j', 'k', 'l' } };


// Создаем строку из символов массива
string str = "";
for (int i = 0; i < array.GetLength(0); i++) {
  for (int j = 0; j < array.GetLength(1); j++) {
    str += array[i, j];
  }
}

// Выводим строку
Console.WriteLine(str);