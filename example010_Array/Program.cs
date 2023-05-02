int[] array = {1, 12, 34, 81, 4, 51, 16, 17, 81};
int n = array.Length;
int find = 81;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
}
