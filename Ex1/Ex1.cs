// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray (int [] massiv)
{
    for (int index = 0; index < massiv.Length; index++)
    {
        massiv[index] = new Random().Next(10,100);
    } 
}
 
void PrintArray (int [] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
    Console.Write($" {mas[i]} ");
    }
}

int[] array = new int [123];
FillArray (array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Sum of array elemets = {sum}");
