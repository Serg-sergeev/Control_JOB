// Написать программу, которая из имеющегося массива, формирует другой массив из слов меньше или равных 3 символам.

using ProgramClass;

string text = UserInput.inputText("Введите слова через пробел:");

string[] array = ActionsWithArray.GetArrayOfInputUser(text);
array = ActionsWithArray.GetArrayWithTextMoreFreeChar(array);
ActionsWithArray.PrintStringArray(array);