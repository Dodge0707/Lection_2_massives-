int [] array = { 1, 12, 3, 45, 643, 12, 6453, 123};

int n = array.Length;
int find = 12; 

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
