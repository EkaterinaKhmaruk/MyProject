/* Написать программу, которая из имеющегося массива строк формирует новый
 массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте
  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
  лучше обойтись исключительно массивами.*/
  
Console.Write("Введите слова: ");
string? words = Console.ReadLine();

string[] newWords = words!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i <newWords.Length; i++)
{
    Console.WriteLine(newWords[i]);
}