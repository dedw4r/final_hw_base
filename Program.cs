string[] array = new string[4];
array[0] = "hello";
array[1] = "2";
array[2] = "world";
array[3] = ":-)";

string[] array2 = new string[4];

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        array2[i] = array[i];
    }
}

foreach(string s in array2)
{
    Console.Write($"{s} ");
}