/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите размер массива  ");
int size = int.Parse(Console.ReadLine()!);
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив: ");
PrintArray(num);
int sum = 0;

for (int j = 0; j < num.Length; j+=2)
    sum = sum + num[j];

    Console.WriteLine($"Cумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}