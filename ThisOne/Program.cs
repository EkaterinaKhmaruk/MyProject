/* Написать программу, которая из имеющегося массива строк формирует новый
 массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте
  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
  лучше обойтись исключительно массивами.*/

Console.WriteLine();
Console.Write("Введите слова: ");
string? words = Console.ReadLine();

string[] newWords = words!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.Write("Слова, в которых меньше 4 символов: "); 
    
foreach (string word in newWords)
{
    int foundLength = 3;
    if (word.Length <= foundLength)
        {
           Console.Write($"{word} ");
        }
        
}
