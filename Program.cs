Console.Clear();
Console.WriteLine("Введите массив строк");
string[] array = Console.ReadLine()!.Split().ToArray();
int N = array.Length;
int count = 0;
for(int i = 0; i < N; i++)
{
    if(array[i].Length <= 3)
        count++;
}
