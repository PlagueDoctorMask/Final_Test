Console.Clear();
Console.WriteLine("Введите массив строк");
string[] array = Console.ReadLine()!.Split(",").ToArray();
int N = array.Length;
int count = 0;
for(int i = 0; i < N; i++)
{
    if(array[i].Length <= 3)
        count++;
}
string[] result_array = new string[count];
int a = 0;
for(int i = 0; i < N; i++)
{
    if(array[i].Length <= 3)
    {
        result_array.SetValue(array[i],a);
        a++;
    }
}
Console.WriteLine($"[{string.Join("," , result_array)}]");