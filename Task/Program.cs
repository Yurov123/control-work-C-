// Из имеющегося массива строк сформировать массив из строк,длинна которых меньше либо равна 3 символам.

Console.Clear();

string[] sourceArray = new string[] { "hello", "2", ":-)","work","list","Moscow","((","1"};
string[] sortedArray = new string[sourceArray.Length];

for (int i = 0; i < sourceArray.Length ; i++)
{
    if(sourceArray[i].Length <= 3)
    {
    sortedArray[i] = sourceArray[i];
    Console.Write(sortedArray[i] + " ");
    }
}
