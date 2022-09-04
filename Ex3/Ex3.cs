// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillArray(int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1,10);
    }
}

void PrdoubleArray(int [] mas)
{
    for (int index = 0; index < mas.Length; index++)
    {
        Console.Write($" {mas[index]} ");
    }
}

int[] array = new int [8];
FillArray(array);
PrdoubleArray(array);
 Console.WriteLine();
int max = array [0];
int min = array [0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array [i]) max = array [i];
    else if (min > array [i]) min = array [i];
}
 int diff = max - min;
Console.WriteLine($"Max {max} - Min {min} = {diff}");