// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д
void FillArray (int [] massiv)
{
    for (int index = 0; index < massiv.Length; index++)
    {
        massiv[index] = new Random().Next(1,10);
    } 
}
 
void PrintArray (int [] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
    Console.Write($" {mas[i]} ");
    }
}

int[] array = new int [8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int j = array.Length - 1;
int i = 0;
int size = array.Length;
while (i < size/2)
{
    int multPair = array[i] * array[j];
    Console.WriteLine($"Sum of array pairs {array[i]} x {array[j]} = {multPair}");
    i++;
    j = j - 1;
}
